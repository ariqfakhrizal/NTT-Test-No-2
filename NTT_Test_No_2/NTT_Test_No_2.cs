using System;
using System.Collections.Generic;
using System.Text;

namespace NTT
{
    public class NTT_Test_No_2
    {
        static void Main(string[] args)
        {
            Console.Write("Input X: ");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input Y: ");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            string result = functionHitung(x, y, z);

            Console.WriteLine();
            Console.WriteLine("Output Z(" + z + "), i.e : " + result.ToString());
        }

        public static string functionHitung(int x, int y, int z)
        {
            try
            {
                StringBuilder result = new StringBuilder();

                for (int start = x; start <= y; start++)
                {
                    if (start % z == 0)
                    {
                        result.Append(start);

                        if (start < y)
                            result.Append(", ");
                    }
                }

                return result.ToString();
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
