using System.Windows;
using mesh_app.Data;

namespace mesh_app;

public partial class AdminWindow : Window
{
    public AdminWindow(Models.User admin)
    {
        InitializeComponent();
        UsersGrid.ItemsSource = MockDataStore.Users;
    }
}