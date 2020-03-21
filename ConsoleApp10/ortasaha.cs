using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class OrtaSaha : Futbolcu
    {
        public int UzunTop { get; set; }
        public int IlkDokunus { get; set; }
        public int Uretkenlik { get; set; }
        public int TopSurme { get; set; }
        public int OzelYetenek { get; set; }

        public OrtaSaha(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
        {
            this.UzunTop = rastgele.Next(60, 100);
            this.IlkDokunus = rastgele.Next(60, 100);
            this.Uretkenlik = rastgele.Next(60, 100);
            this.TopSurme = rastgele.Next(60, 100);
            this.OzelYetenek = rastgele.Next(60, 100);
        }
        public override double PasVer()
        {
            var PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;

            return PasSkor;
        }

        public override double GolVurusu()
        {
            var GolSkor = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            return GolSkor;
        }
    }
}
