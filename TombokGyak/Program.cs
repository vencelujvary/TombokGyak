namespace TombokGyak
{
    internal class Program
    {
        static string[] szavak = {"alma", "körte", "barack", "szilva", "cseresznye", "kutya", "macska",
                                 "oroszlán", "elefánt", "zsiráf", "iskola", "tanulás", "füzet", "ceruza",
                                 "tábla", "asztal", "szék", "ablak", "ajtó", "lámpa", "autó", "vonat",
                                 "repülő", "kerékpár", "hajó", "erdő", "hegy", "folyó", "tenger", "sziget",
                                 "napraforgó", "virág", "tulipán", "rózsa", "levél", "kenyér", "sajt", "leves",
                                 "palacsinta", "csokoládé", "telefon", "számítógép", "billentyűzet", "monitor",
                                 "internet", "labda", "focista", "úszás", "kirándulás", "karácsony"};

        static Random r = new Random();
        static string Kivalasztas()
        {
            int index = r.Next(0, szavak.Length);
            return szavak[index];
        }
        static char BetuBekeres()
        {
            Console.Write("Kérek egy betűt: ");
            char betu = Console.ReadLine()[0];
            return betu;
        }
        static void Jatek()
        {
            string kitalalandoSzo = Kivalasztas();
            string eddigiTalalatok = new string('', kitalalandoSzo.Length);
            int tippekSzama = 0;
            string eddigiBetuk = "";
            Console.WriteLine(eddigiTalalatok);
            //foreach (var item in kitalalandoSzo)
            //{
            //    eddigiTalalatok += "";
            //}
            while (kitalalandoSzo != eddigiTalalatok)
            {
                char betu = BetuBekeres();
                tippekSzama++;
                if (eddigiBetuk.Contains(betu))
                {
                    Console.WriteLine("Ez a betű már volt!");
                }
                else if (kitalalandoSzo.Contains(betu))
                {
                    eddigiBetuk += betu;
                    string seged = "";
                    for (int i = 0; i < kitalalandoSzo.Length; i++)
                    {
                        if (betu == kitalalandoSzo[i])
                        {
                            seged += betu;
                        }
                        else
                        {
                            seged += eddigiTalalatok[i];
                        }
                    }
                    eddigiTalalatok = seged;
                }
                else
                {
                    Console.WriteLine("Nincs ilyen betű a szóban!");
                }
                Console.WriteLine("\n" + eddigiTalalatok);
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gratulálunk! Eltaláltad!");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine($"A tömb első eleme: {szavak[0]}");
            //Console.WriteLine($"A tömb utolsó eleme: {szavak[szavak.Length - 1]}");
            //Console.WriteLine($"A tömb hossza: {szavak.Length}");
            Jatek();
        }
    }
}