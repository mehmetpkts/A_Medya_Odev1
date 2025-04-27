using System;

namespace HayvanatBahcesi
{

    public class Hayvan
    {
        // Kaps�lleme: �zellikler private, eri�im i�in getter/setter var
        private string isim;
        private int yas;

        // Constructor
        public Hayvan(string isim, int yas)
        {
            this.isim = isim;
            this.yas = yas;
        }

        // Getter ve Setter'lar
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        // Ortak davran��lar
        public virtual void SesCikar()
        {
            Console.WriteLine($"{isim} bir ses ��kard�!");
        }

        public virtual void BilgiGoster()
        {
            Console.WriteLine($"�sim: {isim}, Ya�: {yas}");
        }
    }
    public class Memeli : Hayvan
    {
        private bool sutleBeslenirMi;

        public Memeli(string isim, int yas, bool sutleBeslenirMi) : base(isim, yas)
        {
            this.sutleBeslenirMi = sutleBeslenirMi;
        }

        public bool SutleBeslenirMi
        {
            get { return sutleBeslenirMi; }
            set { sutleBeslenirMi = value; }
        }

        public override void SesCikar()
        {
            Console.WriteLine($"{Isim} (Memeli) bir ses ��kard�!");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
            Console.WriteLine($"S�tle Beslenir mi?: {sutleBeslenirMi}");
        }
    }

    public class Kus : Hayvan
    {
        private bool ucarMi;

        public Kus(string isim, int yas, bool ucarMi) : base(isim, yas)
        {
            this.ucarMi = ucarMi;
        }

        public bool UcarMi
        {
            get { return ucarMi; }
            set { ucarMi = value; }
        }

        public override void SesCikar()
        {
            Console.WriteLine($"{Isim} (Ku�) �t�yor!");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
            Console.WriteLine($"U�ar m�?: {ucarMi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nesneler olu�turuluyor
            Memeli aslan = new Memeli("Aslan", 5, true);
            Kus kartal = new Kus("Kartal", 3, true);

            // Davran��lar test ediliyor
            aslan.BilgiGoster();
            aslan.SesCikar();

            Console.WriteLine("------------------------");

            kartal.BilgiGoster();
            kartal.SesCikar();

            Console.ReadLine();
        }
    }
}
