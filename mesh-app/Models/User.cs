namespace mesh_app.Models;

public enum UserRole { Student, Parent, Teacher, Admin }

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public string Name { get; set; }
}