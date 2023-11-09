
public class Board
{
    public List<Card> inProgress = new();
    public List<Card> toDo = new();
    public List<Card> done = new();
    private readonly User user = new();

    public Board()
    {
        toDo = new List<Card>();
        inProgress = new List<Card>();
        done = new List<Card>();

        toDo.Add(new Card("Complete project", " Complete C# project today.", user.Users[1], Size.XS, "toDo"));
        inProgress.Add(new Card("Exercise", "Run", user.Users[2], Size.M, "inProgress"));
        done.Add(new Card("Interview", "Interview at 15:00", user.Users[3], Size.XXL, "done"));
    }

    public void AddCard()
    {
        Console.WriteLine("****************** Card Ekleme ******************");
        Console.WriteLine("Başlık Giriniz                                  :");
        string? title = Console.ReadLine();
        Console.WriteLine("İçerik Giriniz                                  :");
        string? content = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        int size = int.Parse(Console.ReadLine());
        if (size > 5) { Console.WriteLine("Geçersiz Giriş Yaptınız !!                      :"); return; }
        Console.WriteLine("Kişi Seçiniz                                    :");
        int id = int.Parse(Console.ReadLine());
        if (id > 3) { Console.WriteLine("Geçersiz Giriş Yaptınız !!                      :"); return; }
        toDo.Add(new Card(title, content, user.Users[id], (Size)size, "done"));
    }


    public void List()
    {
        Console.WriteLine("\nTODO Line\n************************");
        if (toDo.Count == 0) Console.WriteLine("~ BOŞ ~");
        foreach (var item in toDo)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n", item.Size);
        }
        Console.WriteLine("\nIN PROGRESS Line\n************************");
        if (inProgress.Count == 0) Console.WriteLine("~ BOŞ ~");
        foreach (var item in inProgress)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n", item.Size);
        }
        Console.WriteLine("\nDONE Line\n************************");
        if (done.Count == 0) Console.WriteLine("~ BOŞ ~");
        foreach (var item in done)
        {
            Console.WriteLine("Title: {0}", item.Title);
            Console.WriteLine("Content: {0}", item.Content);
            Console.WriteLine("User: {0}", item.User);
            Console.WriteLine("Size: {0}\n\n", item.Size);
        }
    }

    public void MoveCard()
    {
        Console.WriteLine("****************** Card Taşıma ******************");
        Console.WriteLine("Taşımak istediğiniz yeri seçiniz : DONE (1) - INPROGRESS (2) ");
        string? status = Console.ReadLine();
        List();
        Console.WriteLine("Lütfen kart başlığını yazınız: ");
        string? title = Console.ReadLine();
        foreach (var item in toDo)
        {
            if (item.Title == title && status == "1")
            {
                done.Add(item);
                toDo.Remove(item);
                return;
            };

            if (item.Title == title && status == "2")
            {
                inProgress.Add(item);
                toDo.Remove(item);
                return;
            };
        }
        foreach (var item in inProgress)
        {
            if (item.Title == title && status == "1")
            {
                done.Add(item);
                inProgress.Remove(item);
                return;
            };
        }
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı.");

    }

    public void DeleteCard()
    {
        Console.WriteLine("****************** Card Silme ******************");
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız: ");
        string? title = Console.ReadLine();
        foreach (var item in done)
        {
            if (item.Title == title) { done.Remove(item); return; };
        }
        Console.WriteLine("Aradığınız krtiterlere uygun tamamlanmış kart board'da bulunamadı.");
    }


}