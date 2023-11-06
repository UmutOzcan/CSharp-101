
public class Board
{
    public List<Card> inProgress = new();
    public List<Card> toDo = new();
    public List<Card> done = new();

    public Board()
    {
        toDo = new List<Card>();
        inProgress = new List<Card>();
        done = new List<Card>();
    }

    public void AddCard()
    {

    }

    public void List(Board board1)
    {
        Console.WriteLine("\nTODO Line\n************************");
        foreach (var item in board1.toDo)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n", item.Size);
        }
        Console.WriteLine("\nIN PROGRESS Line\n************************");
        foreach (var item in board1.inProgress)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n", item.Size);
        }
        Console.WriteLine("\nDONE Line\n************************");
        foreach (var item in board1.done)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n\n\n", item.Size);
        }
    }

    public void MoveCard()
    {

    }

    public void DeleteCard()
    {

    }

    public void UpdateCard()
    {

    }

}