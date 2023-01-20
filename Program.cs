internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, \n World! \n isminiz nedir?");
        string isim = Console.ReadLine();
        Console.WriteLine("Şimdi de doğum yılınızı giriniz");
        int yil = Convert.ToInt32(Console.ReadLine());
        int yas = DateTime.Now.Year - yil;
        Console.WriteLine($"{isim}'in yasi {yas}");
    }
}