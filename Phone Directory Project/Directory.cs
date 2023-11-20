
public class Directory
{
    private List<Person> persons = new();
    public Directory()
    {
        persons.Add(new Person("Umut", "Ozcan", "5555555555"));
        persons.Add(new Person("Yusuf", "Ozcan", "5555555556"));
        persons.Add(new Person("Ayse", "Yıldırım", "5555555557"));
        persons.Add(new Person("Mehmet", "Güneş", "5555555558"));
        persons.Add(new Person("Fimple", "Patika", "5555555559"));
    }

    public void AddNo()
    {
        Console.WriteLine("Lütfen isim giriniz : ");
        string? name = Console.ReadLine();
        Console.WriteLine("Lütfen soyisim giriniz : ");
        string? surname = Console.ReadLine();
        Console.WriteLine("Lütfen numara giriniz : ");
        string? no = Console.ReadLine();

        persons.Add(new Person(name, surname, no));

    }

    public void DeleteNo()
    {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
        string? data = Console.ReadLine();

        foreach (var item in persons)
        {
            if (item.Name.ToLower() == data.ToLower() || item.Surname.ToLower() == data.ToLower())
            {
                persons.Remove(item);
                return;
            }
        }
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Menuye dönmek için bir tuşa basınız.");



    }

    public void UpdateNo()
    {
        Console.WriteLine("Düzenlemek istediğiniz kişinin adını ya da soyadını giriniz : ");
        string? data = Console.ReadLine();

        foreach (var item in persons)
        {
            if (item.Name.ToLower() == data.ToLower() || item.Surname.ToLower() == data.ToLower())
            {
                Console.WriteLine("Yeni adı giriniz : ");
                string? name = Console.ReadLine();
                Console.WriteLine("Yeni soyadı giriniz : ");
                string? surname = Console.ReadLine();
                Console.WriteLine("Yeni numarayı giriniz : ");
                string? no = Console.ReadLine();
                item.Name = name;
                item.Surname = surname;
                item.Phone_Number = no;
                return;
            }
        }
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Menuye dönmek için bir tuşa basınız.");
    }

    public void List()
    {
        foreach (var p in persons)
        {
            Console.WriteLine(p.Name + " " + p.Surname + " " + p.Phone_Number);
        }
    }

    public void Search()
    {
        Console.WriteLine("Bulmak istediğiniz kişinin adını - soyadını ya da numarasını giriniz : ");
        string? data = Console.ReadLine();

        foreach (var item in persons)
        {
            if (item.Name.ToLower() == data.ToLower() || item.Surname.ToLower() == data.ToLower() || item.Phone_Number.ToLower() == data.ToLower())
            {
                Console.WriteLine("İsim : " + item.Name);
                Console.WriteLine("Soyisim : " + item.Surname);
                Console.WriteLine("Numara : " + item.Phone_Number);
                return;
            }
        }
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Menuye dönmek için bir tuşa basınız.");
    }

}