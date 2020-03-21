using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Forvet : Futbolcu
    {
        public int Bitiricilik { get; set; }
        public int IlkDokunus { get; set; }
        public int Kafa { get; set; }
        public int SogukKanlilik { get; set; }
        public int OzelYetenek { get; set; }

        public Forvet(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
        {
            this.Bitiricilik = rastgele.Next(70, 100);
            this.IlkDokunus = rastgele.Next(70, 100);
            this.Kafa = rastgele.Next(70, 100);
            this.SogukKanlilik = rastgele.Next(70, 100);
            this.OzelYetenek = rastgele.Next(70, 100);
        }
        public override double PasVer()
        {
            var PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            return PasSkor;
        }
        public override double GolVurusu()
        {
            var GolSkor = Yetenek * 0.2 + this.OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + this.IlkDokunus * 0.1 + this.Bitiricilik * 0.1 + this.SogukKanlilik * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            return GolSkor;
        }
    }
}
