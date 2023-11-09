Board board = new();
Menu(board);

static void Menu(Board board)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
    Console.WriteLine("1- Kart Ekle");
    Console.WriteLine("2- Kart Sil");
    Console.WriteLine("3- Kart Taşı");
    Console.WriteLine("4- Board Listele");
    Console.WriteLine("5- Cıkış Yap \n");

    string? input = Console.ReadLine();
    Console.Clear();

    switch (input)
    {
        case "1":
            board.AddCard();
            break;

        case "2":
            board.DeleteCard();
            break;

        case "3":
            board.MoveCard();
            break;

        case "4":
            board.List();
            break;

        case "5":
            Environment.Exit(1);
            break;

        default:
            Console.WriteLine("Hatalı seçim yaptınız!");
            break;
    }

    Console.WriteLine("\n\nMenuye donmek icin herhangi bir tusa basin !!");
    Console.ReadKey();
    Console.Clear();
    Menu(board);
}

