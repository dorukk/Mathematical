using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematic
{
    class MathematicalClass
    {

        public int faktoriyel(int a)
        {
            int fakt = 1;

            for (int i = 1; i <= a; i++)
			{
			 fakt=fakt*i;
            }
            return fakt;
        }
            public int power(int nom,int pow)
            {   
                int multi=1;
                for (int i = 0; i <pow; i++)
                {
                    multi=multi*i;
                }
                return multi;
			
            }
                public bool armstrong(int number)
             {      bool control;

                    int hundreds=number/100;
                    int tens=(number % 10)/ 10 ;
                    int ones=number%10;

                    if(power(hundreds,3)+power(tens,3)+power(ones,3)==number)
                    {
                        control=true;
                    }
                    {
                        control=false;
                    }
                    return control;
             }

                public double avarage(double[] numbers)
                {
                    double all = 0;
                    for (int i = 0; i <numbers.Length; i++)
                    {
                        all = all + numbers[i];
                    }
                    double avg = all / numbers.Length;
                    return avg;
                }
                
    



			
 }
}
    

