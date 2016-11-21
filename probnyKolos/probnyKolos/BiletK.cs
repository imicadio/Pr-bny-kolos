using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnyKolos {
    class BiletK : Bilet {
        private double dlugoscTrasy;
        
        public override void ObliczCene(RodzajBiletu rodzaj){
            if (dlugoscTrasy <= 100) {
                cena = dlugoscTrasy * 1.04;
                if (rodzaj == RodzajBiletu.U)
                    cena = dlugoscTrasy * 1.04 * 0.5;
            }
            else {
                cena = dlugoscTrasy * 0.73;
                if (rodzaj == RodzajBiletu.U)
                    cena = dlugoscTrasy * 0.73 * 0.5;
            }
            Console.WriteLine(String.Format("{0}", cena));
        }

            public BiletK(int dlugoscTrasy){
                this.dlugoscTrasy = dlugoscTrasy;
            }
        }    
    }