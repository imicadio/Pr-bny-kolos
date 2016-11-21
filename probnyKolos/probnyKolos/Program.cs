using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnyKolos {

    enum RodzajBiletu { N, U}

    class Program {
        static void Main(string[] args) {
            BiletA bilet1 = new BiletA();
            BiletA bilet2 = new BiletA();

            BiletK bilet3 = new BiletK(100);
            BiletK bilet4 = new BiletK(1234);

            bilet1.ObliczCene(RodzajBiletu.N);
            bilet2.ObliczCene(RodzajBiletu.U);

            bilet3.ObliczCene(RodzajBiletu.N);
            bilet4.ObliczCene(RodzajBiletu.U);

            Console.ReadKey();

            //int numerDnia = (int)DniTygodnia.Piątek;
        }
    }
}
