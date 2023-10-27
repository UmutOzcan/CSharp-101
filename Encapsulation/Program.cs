


Student student = new();
student.Name = "Umut";
student.Surname = "Ozcan";
student.No = 800;

student.GetStudentInfo();
Console.ReadKey();




class Student
{
    private string name;
    private string surname;
    private int no;

    public string Name { get => name; set => name = value; }

    public string Surname { get => surname; set => surname = value; }

    public int No { get => no; set => no = value; }

    public Student() { }

    public Student(string name, string surname, int no)
    {
        Name = name;
        Surname = surname;
        No = no;
    }

    public void GetStudentInfo()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Surname);
        Console.WriteLine(this.No);

    }


}