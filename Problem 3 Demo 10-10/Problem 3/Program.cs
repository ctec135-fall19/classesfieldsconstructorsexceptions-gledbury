using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: region 1
            for(int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                //cond2 = red light is flashing
                for(int cond2 = 0; cond2 <=1; cond2++)
                {
                    for (int k=0; k<=1; k++)
                    {
                        if(printerPrintsCondition == 0 && cond2 == 0 && k == 0)
                        {
                            // call action methods
                        }
                    }
            }
            #endregion
        }

        public void CheckInk()
        {
            Console.WriteLine("Check ink");
        }
    }
}
