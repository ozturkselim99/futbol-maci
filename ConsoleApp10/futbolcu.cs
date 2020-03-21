using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Futbolcu
    {
        public Random rastgele = new Random();
        public string AdSoyad { get; set; }
        public int FormaNo { get; set; }
        public int Hiz { get; set; }
        public int Dayaniklik { get; set; }
        public int Pas { get; set; }
        public int Sut { get; set; }
        public int Yetenek { get; set; }
        public int DogalForm { get; set; }
        public int Sans { get; set; }
        public int Kararlik { get; set; }

        public Futbolcu(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            this.Dayaniklik = rastgele.Next(50, 100);
            this.Hiz = rastgele.Next(50, 100);
            this.Pas = rastgele.Next(50, 100);
            this.Sut = rastgele.Next(50, 100);
            this.Yetenek = rastgele.Next(50, 100);
            this.DogalForm = rastgele.Next(50, 100);
            this.Sans = rastgele.Next(50, 100);
        }
        public virtual double PasVer()
        {
            var PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.2;

            return PasSkor;
        }
        public virtual double GolVurusu()
        {
            var GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;

            return GolSkor;
        }
    }
}
