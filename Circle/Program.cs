Console.Write("Dairenin yarıçapını 0-13 giriniz: ");
int yaricap = Convert.ToInt32(Console.ReadLine());

if (yaricap <= 0)
    Console.WriteLine("Lütfen geçerli bir pozitif sayı giriniz.");
else
    Circle.DrawCircle(yaricap);

Console.ReadKey();