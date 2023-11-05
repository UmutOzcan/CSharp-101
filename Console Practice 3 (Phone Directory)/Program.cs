// Kullanicidan alinan inputlara gore islem yaptiran console uygulamasi

Directory directory = new();
Menu(directory);


static void Menu(Directory directory)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
    Console.WriteLine("1- Yeni Numara Kaydet");
    Console.WriteLine("2- Numara Sil");
    Console.WriteLine("3- Numara Güncelle");
    Console.WriteLine("4- Rehberi Listele");
    Console.WriteLine("5- Rehberde Arama Yap");
    Console.WriteLine("6- Cıkış Yap \n");



    string? input = Console.ReadLine();
    Console.Clear();

    switch (input)
    {
        case "1":
            directory.AddNo();
            break;

        case "2":
            directory.DeleteNo();
            break;

        case "3":
            directory.UpdateNo();
            break;

        case "4":
            directory.List();
            break;

        case "5":
            directory.Search();
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
    Menu(directory);
}
