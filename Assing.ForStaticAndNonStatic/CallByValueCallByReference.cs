using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assing.ForStaticAndNonStatic
{
    internal class CallByValueCallByReference
    {
        #region Call By Value
         public void CallByValue(int num1 , int num2)
        {
            num1 = 100;
            num2 = 200;
        }
        #endregion





        #region Call By Reference
        public void CallByReference(ref int num1, ref int num2)
        {
            num1= 100;
            num2 = 200;
        }
        #endregion
    }
}
