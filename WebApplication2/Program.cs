using System;

namespace HayvanatBahcesi
{

    public class Hayvan
    {
        // Kapsülleme: Özellikler private, eriþim için getter/setter var
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

        // Ortak davranýþlar
        public virtual void SesCikar()
        {
            Console.WriteLine($"{isim} bir ses çýkardý!");
        }

        public virtual void BilgiGoster()
        {
            Console.WriteLine($"Ýsim: {isim}, Yaþ: {yas}");
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
            Console.WriteLine($"{Isim} (Memeli) bir ses çýkardý!");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
            Console.WriteLine($"Sütle Beslenir mi?: {sutleBeslenirMi}");
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
            Console.WriteLine($"{Isim} (Kuþ) ötüyor!");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
            Console.WriteLine($"Uçar mý?: {ucarMi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nesneler oluþturuluyor
            Memeli aslan = new Memeli("Aslan", 5, true);
            Kus kartal = new Kus("Kartal", 3, true);

            // Davranýþlar test ediliyor
            aslan.BilgiGoster();
            aslan.SesCikar();

            Console.WriteLine("------------------------");

            kartal.BilgiGoster();
            kartal.SesCikar();

            Console.ReadLine();
        }
    }
}
