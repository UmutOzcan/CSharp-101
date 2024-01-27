public static class Toplama
{
    // Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran,
    // sayılar aynıysa toplamının karesini ekrana yazdıran fonksiyon
    public static List<int> IkiliToplama(string input)
    {
        string[] dizi = input.Split(" ");
        List<int> sums = [];

        for (int i = 0; i < dizi.Length; i += 2)
        {
            if (int.TryParse(dizi[i], out int firstNumber) && int.TryParse(dizi[i + 1], out int secondNumber))
            {
                int sum = firstNumber + secondNumber;

                if (firstNumber != secondNumber)
                {
                    sums.Add(sum);
                }
                else
                {
                    int square = sum * sum;
                    sums.Add(square);
                }
            }
            else
            {
                Console.WriteLine($"Hata: {dizi[i]} veya {dizi[i + 1]} geçerli bir sayı değil.");
            }
        }

        return sums;
    }
}
