// See https://aka.ms/new-console-template for more information

public class KodeBuah
{
    static void Main (String [] args)
    {
        KodeBuah table_KodeBuah = new KodeBuah();
        Console.WriteLine(" ======= Tabel Buah ======");
        public enum buah {Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }
        public static int GetKodeBuah (buah buah)
    {
        int[] kodeBuah = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 010, 110, 120, 130, 140, 150 };
        return kodeBuah[(int)buah];
    }
    }

