namespace TombokGyak
{
    internal class Program
    {
        static string[] szavak = ["hűtőszekrény", "villanykörte", "monitor", "eper", "egér"];
        static Random r = new Random();
        static string Kivalasztas()
        {
            int index = r.Next(0, szavak.Length);
            return szavak[index];
        }
        static void Jatek()
        {
            string kitalalandoSzo = Kivalasztas();
            Console.WriteLine($"A kitalálandó szó: {kitalalandoSzo}");
            string eddigiTalalatok = new string('_', kitalalandoSzo.Length);
            Console.WriteLine(eddigiTalalatok);
            foreach (var item in kitalalandoSzo)
            {
                eddigiTalalatok += "_";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"A tömb első eleme: {szavak[0]}");
            Console.WriteLine($"A tömb utolsó eleme: {szavak[szavak.Length - 1]}");
            Console.WriteLine($"A tömb hossza: {szavak.Length}");
            string kitalalandoSzo = Kivalasztas();

        }
    }
}
