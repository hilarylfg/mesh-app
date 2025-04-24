using System.Windows;
using mesh_app.Data;
using mesh_app.Models;

namespace mesh_app;

public partial class StudentWindow : Window
{
    private User _student;
    public StudentWindow(User student)
    {
        InitializeComponent();
        _student = student;
        GradesGrid.ItemsSource = MockDataStore.Grades.Where(g => g.StudentId == _student.Id).ToList();
        HomeworkGrid.ItemsSource = MockDataStore.Homeworks;
        ScheduleGrid.ItemsSource = MockDataStore.Schedules;
    }
}