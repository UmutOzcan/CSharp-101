public class Person
{
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
