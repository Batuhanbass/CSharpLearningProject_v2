using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hata_Yönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<string> students = new List<string> { "Batuhan", "Ahmet", "Mehmet", "Derin" };
            if (!students.Contains("Ahme2t"))
            {

                throw new RecordNotFoundExceptiion("record not found!");


            }
            else { 
            
            
            }

            HandleException(() =>
            {
                //Find();
            }); 
        }


        private static void HandleException(Action action) {
            try { }
            catch(Exception exception) { }
            
        }
    }
}