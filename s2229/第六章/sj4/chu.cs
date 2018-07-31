using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj4
{
    class chu:operation
    {
        public override double get()
        {
        
           
             double  get= onenumber / twonumber;
            
            return get;
            
        }
        public bool s() { 
              if (onenumber==0||twonumber==0)
            	{
                    Console.WriteLine("除数和被除数不能为0");
                    return false;
	                                    }
              else
              {
                  return true;
              }
        
        }
    }
}
