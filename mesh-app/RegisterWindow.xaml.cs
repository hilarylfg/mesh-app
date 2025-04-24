using System.Windows;
using mesh_app.Data;
using mesh_app.Models;

namespace mesh_app;

public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
    }

    private void RoleBox_Loaded(object sender, RoutedEventArgs e)
    {
        RoleBox.ItemsSource = new[] { "Ученик", "Родитель", "Учитель", "Администратор" };
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {
        string name = NameBox.Text;
        string login = LoginBox.Text;
        string password = PasswordBox.Password;
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || RoleBox.SelectedItem == null)
        {
            MessageBox.Show("Заполните все поля!");
            return;
        }
        UserRole role = UserRole.Student;
        switch (RoleBox.SelectedIndex)
        {
            case 0: role = UserRole.Student; break;
            case 1: role = UserRole.Parent; break;
            case 2: role = UserRole.Teacher; break;
            case 3: role = UserRole.Admin; break;
        }
        var newUser = new User
        {
            Id = MockDataStore.Users.Count + 1,
            Name = name,
            Login = login,
            Password = password,
            Role = role
        };
        MockDataStore.Users.Add(newUser);
        MessageBox.Show("Регистрация прошла успешно!");
        this.Close();
    }
}