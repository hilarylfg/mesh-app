using System.Windows;
using mesh_app.Data;
using mesh_app.Models;

namespace mesh_app;

public partial class TeacherWindow : Window
    {
        private User _teacher;
        public TeacherWindow(User teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            GradesGrid.ItemsSource = MockDataStore.Grades.ToList();
            StudentBox.ItemsSource = MockDataStore.Users.Where(u => u.Role == UserRole.Student).Select(u=>u.Name).ToList();
            HomeworkGrid.ItemsSource = MockDataStore.Homeworks.ToList();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            var studentName = StudentBox.SelectedItem as string;
            var student = MockDataStore.Users.FirstOrDefault(u => u.Name == studentName);
            if (student == null || string.IsNullOrWhiteSpace(SubjectBox.Text) || string.IsNullOrWhiteSpace(GradeBox.Text))
            {
                MessageBox.Show("Заполните все поля для оценки!");
                return;
            }
            var grade = new Grade
            {
                Id = MockDataStore.Grades.Count + 1,
                StudentId = student.Id,
                Subject = SubjectBox.Text,
                Value = GradeBox.Text,
                TeacherName = _teacher.Name,
                Date = System.DateTime.Today
            };
            MockDataStore.Grades.Add(grade);
            GradesGrid.ItemsSource = null;
            GradesGrid.ItemsSource = MockDataStore.Grades.ToList();
        }

        private void AddHomework_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HwSubjectBox.Text) || string.IsNullOrWhiteSpace(HwDescBox.Text) || HwDateBox.SelectedDate == null)
            {
                MessageBox.Show("Заполните все поля для задания!");
                return;
            }
            var hw = new Homework
            {
                Id = MockDataStore.Homeworks.Count + 1,
                Subject = HwSubjectBox.Text,
                Description = HwDescBox.Text,
                TeacherName = _teacher.Name,
                DueDate = HwDateBox.SelectedDate.Value
            };
            MockDataStore.Homeworks.Add(hw);
            HomeworkGrid.ItemsSource = null;
            HomeworkGrid.ItemsSource = MockDataStore.Homeworks.ToList();
        }
    }