namespace mesh_app.Models;

public class Grade
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public string Subject { get; set; }
    public string Value { get; set; }
    public string TeacherName { get; set; }
    public System.DateTime Date { get; set; }
}