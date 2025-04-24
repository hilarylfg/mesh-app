using System.Windows;
using mesh_app.Data;
using mesh_app.Models;

namespace mesh_app;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string login = LoginBox.Text;
        string password = PasswordBox.Password;
        var user = MockDataStore.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        if (user == null)
        {
            MessageBox.Show("Неверный логин или пароль!");
            return;
        }

        switch (user.Role)
        {
            case UserRole.Student:
                new StudentWindow(user).Show();
                break;
            case UserRole.Parent:
                new ParentWindow(user).Show();
                break;
            case UserRole.Teacher:
                new TeacherWindow(user).Show();
                break;
            case UserRole.Admin:
                new AdminWindow(user).Show();
                break;
        }
        this.Close();
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {
        new RegisterWindow().ShowDialog();
    }
}