namespace mesh_app.Models;

public class Homework
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public string TeacherName { get; set; }
    public System.DateTime DueDate { get; set; }
}