using System;

namespace c
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("sayi ; ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch(Exception error)
            {
                 Console.WriteLine(error.Message.ToString());
            }
            finally
            {
                 Console.WriteLine("finally");
            }

            try
            {
                int a = int.Parse(null);
                
            }
            catch (ArgumentException ex)
            {
                
                 Console.WriteLine("Null");
                  Console.WriteLine(ex);
            }

        }
        
      
    }
    
}