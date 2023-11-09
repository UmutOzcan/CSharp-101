
public class User
{

    private Dictionary<int, string> users = new();

    public User()
    {
        users = new Dictionary<int, string>
        {
            { 1, "Umut Ozcan" },
            { 2, "Yusuf Ozcan" },
            { 3, "Ozcan Ozcan" }
        };
    }

    public Dictionary<int, string> Users { get => users; set => users = value; }

}