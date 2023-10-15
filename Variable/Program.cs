int deger = 5; // 4 byte
Console.WriteLine(deger);

byte deger2 = 5; // 1 byte 0-255

short deger3 = 5; // 2 byte

float deger4 = 5.0f; // 4 byte

double doub = 5.0; // 8 byte

decimal de = 5; // 16 byte

char c = '2'; // 2 byte

string str = "2"; // sınırsız

bool b1 = true;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

// ---------------------------------

string st = string.Empty; // bos string olusturur
string ad = "Umut";
string soyad = "Ozcan";
st = ad + " " + soyad;
Console.WriteLine(st);

// --------------------------------

string xd = "bu sene ";
int i = 2023;
xd += i.ToString();
Console.WriteLine(xd);

// ---------------------------------

string sayi = "31";
int sayi2 = 31;
sayi2 += Convert.ToInt32(sayi);
Console.WriteLine(sayi2);

// -----------------------------------






//------------------------- Console un hemen kapanmamasi icin gerekli kod
Console.ReadKey();