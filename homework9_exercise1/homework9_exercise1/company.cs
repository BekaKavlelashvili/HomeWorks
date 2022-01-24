using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9_exercise1
{
    public class company
    {
        public bool isLocal;

        public int sum;

        

        public int deghege()
        {
            if (isLocal)
            {
                int per = sum - ((sum * 18) / 100);
                return per;
            }
            else
            {
                int per = sum - ((sum * 5) / 100);
                return per;
            }
        }

    }
}
