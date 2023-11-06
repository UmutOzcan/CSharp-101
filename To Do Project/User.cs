
public class User
{

    private Dictionary<int, string> users = new();

    public User()
    {
        users = new Dictionary<int, string>();
    }

    public Dictionary<int, string> Users { get => users; set => users = value; }

}