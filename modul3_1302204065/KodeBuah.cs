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

public class PosisiKarakterGame
{
    public enum PosisiKarakter {Tengkurap, Jongkok, Landing, Berdiri, Terbang, takeOff }
    public enum Tombol { TombolW, TombolS, TombolX}

    class transition
    {
        public PosisiKarakter prevPosisi;
        public PosisiKarakter nextPosisi;
        public Tombol tombol;

        public transition (PosisiKarakter prevPosisi, PosisiKarakter nextPosisi, Tombol tombol)
        {
            this.prevPosisi = prevPosisi;
            this.nextPosisi = nextPosisi;
            this.tombol = tombol;
        }
    }
    transition[] transitions =
    {
        new transition (PosisiKarakter.Terbang, PosisiKarakter.Berdiri, Tombol.TombolS),
        new transition (PosisiKarakter.Berdiri, PosisiKarakter.Jongkok, Tombol.TombolS),
        new transition (PosisiKarakter.Jongkok, PosisiKarakter.Tengkurap, Tombol.TombolS),
        new transition ( PosisiKarakter.Tengkurap, PosisiKarakter.Jongkok, Tombol.TombolW),
        new transition (PosisiKarakter.Jongkok, PosisiKarakter.Berdiri, Tombol.TombolW),
        new transition (PosisiKarakter.Berdiri, PosisiKarakter.Terbang, Tombol.TombolW),
        new transition (PosisiKarakter.Terbang, PosisiKarakter.Jongkok, Tombol.TombolX),
    };

}


