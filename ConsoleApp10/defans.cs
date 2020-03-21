using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Defans : Futbolcu
    {
        public int PozisyonAlma { get; set; }
        public int Kafa { get; set; }
        public int Sicrama { get; set; }

        public Defans(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
        {
            this.PozisyonAlma = rastgele.Next(50, 90);
            this.Kafa = rastgele.Next(50, 90);
            this.Sicrama = rastgele.Next(50, 90);
        }
        public override double PasVer()
        {
            var PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;

            return PasSkor;
        }

        public override double GolVurusu()
        {
            var GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;

            return GolSkor;
        }
    }
}
