using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_20211109
{
    public class Ucet
    {
        public string jmeno;
        public int stav;
        private int vklad;
        public int limit1;

       
        public Ucet(string jmeno, int stav)
        {
            this.jmeno = jmeno;
            this.stav = stav;
        }

        public int vlozit(int castka)
        {
            if (stav + castka > limit1 )
            {;
                int rozdilvkladu = limit1 - vklad;
                vklad = limit1;
                return rozdilvkladu;
            }
            else
            {
                vklad += castka;
                return castka;
            }
        }



        public int vybrat(int castka)
        {
            if (stav - castka >= 0)
                {
                vklad -= castka;
                return castka;
            }
            else
            {
                var vyber = vklad;
                vklad = 0;
                return vyber;
            }
        }

        public int zaplat(int castka)
        {
            int zaplaceno = limit1 - vklad;
            return castka;
        }
    }



}
