using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiChisla
{
    public class Prime
    {
        public bool Prosto(int num)
        {
            bool result = true;
            for (int i = 2; i < num; i++)
            {
                if(num%i==0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
