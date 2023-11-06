
public class Card
{
    public Card(string _title, string _content, string _user, Size _size, string _status)
    {
        this.Title = _title;
        this.Content = _content;
        this.User = _user;
        this.Size = _size;
        this.Status = _status;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string User { get; set; }
    public Size Size { get; set; }
    public string Status { get; set; }
}