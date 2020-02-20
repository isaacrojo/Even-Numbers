using System;

namespace P_1__Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //print pares del 0 al 10 usando un loop

            for(int i =0; i <= 10; i++)
            {
               if((i % 2) ==0)
              Console.WriteLine(i);
            }
                    //otra forma saltandose los impares
           // for(int = 0; int <= 10; int= i +2){
               // Console.WriteLine(i);
            //}
        }
    }
}
