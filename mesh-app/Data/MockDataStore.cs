using mesh_app.Models;

namespace mesh_app.Data;

public static class MockDataStore
{
    public static List<User> Users = new List<User>
    {
        new User { Id=1, Login="student1", Password="123", Role=UserRole.Student, Name="Коля Поляков" },
        new User { Id=2, Login="student2", Password="123", Role=UserRole.Parent, Name="Марат Ниязов" },
        new User { Id=3, Login="parent", Password="123", Role=UserRole.Parent, Name="Мария Петрова" },
        new User { Id=4, Login="teacher", Password="123", Role=UserRole.Teacher, Name="Сергей Иванов" },
        new User { Id=5, Login="admin", Password="123", Role=UserRole.Admin, Name="Администратор" }
    };

    public static List<Grade> Grades = new List<Grade>
    {
        new Grade { Id=1, StudentId=1, Subject="Математика", Value="5", TeacherName="Сергей Иванов", Date=System.DateTime.Today },
        new Grade { Id=2, StudentId=2, Subject="Русский язык", Value="4", TeacherName="Сергей Иванов", Date=System.DateTime.Today }
    };

    public static List<Homework> Homeworks = new List<Homework>
    {
        new Homework { Id=1, Subject="Русский язык", Description="Написать сочинение", TeacherName="Сергей Иванов", DueDate=System.DateTime.Today.AddDays(2) }
    };

    public static List<Schedule> Schedules = new List<Schedule>
    {
        new Schedule { Id=1, Day="Понедельник", Time="09:00", Subject="Математика" },
        new Schedule { Id=2, Day="Понедельник", Time="10:00", Subject="Русский язык" }
    };
}