using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    public class RecordNotFoundExceptiion:Exception{
        
        public RecordNotFoundExceptiion(string massage):base(massage){
            Console.WriteLine(massage);  
        
        
        }
      
    }
}
