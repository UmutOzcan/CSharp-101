public class Person
{
    private readonly string name;
    private readonly string surName;
    private readonly string phoneNumber;

    public Person(string name, string surName, string phoneNumber)
    {
        this.Name = name;
        this.Surname = surName;
        this.Phone_Number = phoneNumber;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone_Number { get; set; }
}
