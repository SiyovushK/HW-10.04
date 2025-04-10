namespace Domain;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Status Status { get; set; }
    public DateTimeOffset DateOfStart { get; set; }
    public DateTimeOffset DateOfFinish { get; set; }

    public Student(int id, string firstName, string lastName, int age, Gender gender, Status status, DateTimeOffset dateOfStart, DateTimeOffset dateOfFinish)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
        Status = status;
        DateOfStart = dateOfStart;
        DateOfFinish = dateOfFinish;
    }
}