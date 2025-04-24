using System.Windows;
using mesh_app.Data;
using mesh_app.Models;

namespace mesh_app;

public partial class ParentWindow : Window
{
    private User _parent;
    public ParentWindow(User parent)
    {
        InitializeComponent();
        _parent = parent;
        
        var student = MockDataStore.Users.FirstOrDefault(u => u.Role == UserRole.Student);
        GradesGrid.ItemsSource = MockDataStore.Grades.Where(g => g.StudentId == student.Id).ToList();
        HomeworkGrid.ItemsSource = MockDataStore.Homeworks;
    }
}