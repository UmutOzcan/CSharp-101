Board board = new();
User u1 = new();
u1.Users.Add(1, "Umut Ozcan");
u1.Users.Add(2, "Yusuf Ozcan");
u1.Users.Add(3, "Irem Ozcan");
board.toDo.Add(new Card("Do works", "Do C# Project", u1.Users[1], Size.XS, "toDo"));
board.inProgress.Add(new Card("Exercise", "Run", u1.Users[2], Size.M, "inProgress"));
board.inProgress.Add(new Card("Interview", "Interview at 15:00", u1.Users[3], Size.XXL, "inProgress"));
Menu(board);


static void Menu(Board board)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
    Console.WriteLine("1- Kart Ekle");
    Console.WriteLine("2- Kart Sil");
    Console.WriteLine("3- Kart Güncelle");
    Console.WriteLine("4- Kart Taşı");
    Console.WriteLine("5- Board Listele");
    Console.WriteLine("6- Cıkış Yap \n");

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
            board.UpdateCard();
            break;

        case "4":
            board.MoveCard();
            break;

        case "5":
            board.List(board);
            break;

        case "6":
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

