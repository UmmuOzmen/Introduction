using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction
{
    class Aritmetik
    {
     
       public  int prm1 = 25;
       public int prm2 = 45;
        private int prm3;
        //protected  öğren
        public Aritmetik(int constFirst, int constSecond)
        {
            prm1 = constFirst;
            prm2 = constSecond;
        }
        public Aritmetik()
        {
           
        }

        public int topla(int first , int second)
        {
            return first + second;
        }

       public int prm3get()
        {
            return prm3;
        }

        public void prm3set(int prm33)
        {
           this.prm3 = prm33;
        }
        public int topla()
        {
            return prm1 + prm2;
        }


    }
}
