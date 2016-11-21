using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnyKolos {
    class BiletA : Bilet {
        private double Normal = 2.90;
        private double Ulga = 1.45;

        public override void ObliczCene(RodzajBiletu rodzaj) {
            if (rodzaj == RodzajBiletu.U)
                base.cena = Ulga;
            else
                base.cena = Normal;

            Console.WriteLine(String.Format("{0}", cena));
        }
    }
}
