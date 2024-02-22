using System;
using System.Collections.Generic;
using System.Text;

namespace NTT
{
    public class NTT_Test_No_2
    {
        public static void Main(string[] args)
        {
            Console.Write("Input X: ");
            int numberEnteredX = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input Y: ");
            int numberEnteredY = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input Z: ");
            int numberEnteredZ = Convert.ToInt32(Console.ReadLine());

            string numberEnteredResult = functionHitung(numberEnteredX, numberEnteredY, numberEnteredZ);

            Console.WriteLine();
            Console.WriteLine("Output Z(" + numberEnteredZ + "), i.e : " + numberEnteredResult.ToString());
        }

        public static string functionHitung(int numberEnteredX, int numberEnteredY, int numberEnteredZ)
        {
            try
            {
                StringBuilder stringBuilderResult = new StringBuilder();

                for (int start = numberEnteredX; start <= numberEnteredY; start++)
                {
                    if (start % numberEnteredZ == 0)
                    {
                        stringBuilderResult.Append(start);

                        if (start < numberEnteredY)
                            stringBuilderResult.Append(", ");
                    }
                }

                return stringBuilderResult.ToString();
            }
            catch (Exception ex)
            {
                // Log Data Error disini
                Console.WriteLine("Error  : " + ex.Message);
                throw;
            }

        }
    }
}
