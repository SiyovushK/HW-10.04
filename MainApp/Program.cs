using Domain;

var Students = new List<Student>()
{
    new Student(1, "Alex", "Ivanov", 20, Gender.Male, Status.Active, DateTimeOffset.Now.AddYears(-2), DateTimeOffset.Now.AddMonths(2)),
    new Student(2, "Maria", "Petrova", 22, Gender.Female, Status.Active, DateTimeOffset.Now.AddYears(-4), DateTimeOffset.Now.AddDays(-30)),
    new Student(3, "Ivan", "Sidorov", 19, Gender.Male, Status.Active, DateTimeOffset.Now.AddMonths(-3), DateTimeOffset.Now.AddYears(3)),
    new Student(4, "Elena", "Smirnova", 21, Gender.Female, Status.InActive, DateTimeOffset.Now.AddYears(-2), DateTimeOffset.Now.AddYears(1)),
    new Student(5, "Dmitry", "Kuznetsov", 23, Gender.Male, Status.Active, DateTimeOffset.Now.AddYears(-5), DateTimeOffset.Now.AddDays(-100)),
    new Student(6, "Anna", "Mikhailova", 20, Gender.Female, Status.Active, DateTimeOffset.Now.AddMonths(-8), DateTimeOffset.Now.AddMonths(16)),
    new Student(7, "Nikolay", "Popov", 24, Gender.Male, Status.InActive, DateTimeOffset.Now.AddYears(-4), DateTimeOffset.Now.AddMonths(-1)),
    new Student(8, "Olga", "Volkova", 18, Gender.Female, Status.Active, DateTimeOffset.Now.AddMonths(-1), DateTimeOffset.Now.AddYears(4)),
    new Student(9, "Sergey", "Morozov", 21, Gender.Male, Status.InActive, DateTimeOffset.Now.AddYears(-3), DateTimeOffset.Now.AddYears(1)),
    new Student(10, "Irina", "Lebedeva", 22, Gender.Female, Status.Active, DateTimeOffset.Now.AddYears(-4), DateTimeOffset.Now)
};


// Task1
var Male = Students.Where(s => s.Gender == Gender.Male).Select(s => s).ToList();

var Male2 = (
    from s in Students
    where s.Gender == Gender.Male
    select s
    ).ToList();

foreach (var student in Male)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task2
var InActive = Students.Where(s => s.Status == Status.InActive).Select(s => s).ToList();

var InActive2 = (
    from s in Students
    where s.Status == Status.InActive
    select s    
).ToList();

foreach (var student in InActive2)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task3
var Age = Students.Where(s => s.Age <= 25 ).Select(s => s).ToList();

var Age2 = (
    from s in Students
    where s.Age <= 25
    select s
).ToList();

foreach (var student in Age)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task4
var AgeAndActive = Students.Where(s => s.Age > 20 && s.Status == Status.Active ).Select(s => s).ToList();

var AgeAndActive2 = (
    from s in Students
    where s.Age <= 25 && s.Status == Status.Active
    select s
).ToList();

foreach (var student in AgeAndActive2)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task5
var StartAge = Students.Where(s => s.DateOfStart.Year == DateTime.Now.Year - 16).Select(s => s).ToList();

var StartAge2 = (
    from s in Students
    where s.DateOfStart.Year == DateTime.Now.Year - 16
    select s
).ToList();

foreach (var student in StartAge)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task6
var StartAgeOld = Students.Where(s => s.DateOfStart.Year >= DateTime.Now.Year - 18).Select(s => s).ToList();

var StartAgeOld2 = (
    from s in Students
    where s.DateOfStart.Year >= DateTime.Now.Year - 18
    select s
).ToList();

foreach (var student in StartAgeOld2)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task7
var NameAorI = Students.Where(s => s.FirstName.StartsWith("A") || s.FirstName.StartsWith("I")).Select(s => s).ToList();

var NameAorI2 = (
    from s in Students
    where s.FirstName.StartsWith("A") || s.FirstName.StartsWith("I")
    select s
).ToList();

foreach (var student in NameAorI)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task8
var FirstAndLastName = Students.Where(s => s.FirstName[0] == s.LastName[0]).Select(s => s).ToList();

var FirstAndLastName2 = (
    from s in Students
    where s.FirstName[0] == s.LastName[0]
    select s
).ToList();

foreach (var student in FirstAndLastName2)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task9
var TurnAdult = Students.Where(s => s.Age + (s.DateOfFinish.Year - s.DateOfStart.Year) >= 18).Select(s => s).ToList();

var TurnAdult2 = (
    from s in Students
    where s.Age + (s.DateOfFinish.Year - s.DateOfStart.Year) >= 18
    select s
).ToList();

foreach (var student in TurnAdult)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}

System.Console.WriteLine();

//Task10
var stud = Students
    .Where(s => 
        s.Gender != Gender.Female && 
        s.Status == Status.Active &&
        (s.DateOfFinish.Year - s.DateOfStart.Year) > 2 &&
        s.Age < 16
    ).Select(s => s).ToList();

var stud2 = (
    from s in Students
    where s.Gender != Gender.Female && 
        s.Status == Status.Active &&
        (s.DateOfFinish.Year - s.DateOfStart.Year) > 2 &&
        s.Age < 16
    select s
).ToList();

foreach (var student in TurnAdult)
{
    System.Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Age} {student.Gender} {student.Status} {student.DateOfStart} {student.DateOfFinish}");
}