public class Student
{
    internal int _id { get; set; }
    internal string _fullName { get; set;}
    internal string _email { get; set;}
    internal string _birthDate { get; set;}
    internal double _mark { get; set;}

    public Student(int id, string fullName, string email, string birthDate, double mark)
    {
        _id = id;
        _fullName = fullName;
        _email = email;
        _birthDate = birthDate;
        _mark = mark;
    }

    public override string? ToString()
    {
        return $"Name: {_fullName}, Email: {_email}, BirthDate: {_birthDate}, Mark: {_mark}";
    }
}
public class Linq
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student(5,"Nguyen Quang R", "quanghuyR@gmail.com", "2002-02-03",4),
            new Student(1,"Nguyen Quang Huy", "quanghuy@gmail.com", "2002-05-06",9.123),
            new Student(2,"Nguyen Van B", "bnv12@gmail.com", "2001-02-06",5.123),
            new Student(3,"Nguyen Quang C", "quanghuyC@gmail.com", "2002-01-02",7.8),
            new Student(4,"Nguyen Quang D", "quanghuyD@gmail.com", "2002-01-02",8.5),

        };
        IEnumerable<Student> linq = from student in students
                                    where student._fullName.Contains('Q')
                                    orderby student._id
                                    select student;
        linq.ToList<Student>().ForEach(n => Console.WriteLine(n));
    }
}