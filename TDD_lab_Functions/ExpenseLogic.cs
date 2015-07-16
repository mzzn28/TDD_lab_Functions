using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_lab_Functions
{
    public class ExpenseLogic
    {
         enum manager { r, M1, M2, Dir, CEO } //test comment

        public int ManagerOne(int amount, string desc)
        {
            if (desc == "entertainment" || desc == "towncars" || (desc == "hardware" && amount > 5000))
            {
                return (int)manager.r;
            }
            else if (amount < 250)
            {
                return (int)manager.M1;
            }
            else if (amount < 500)
            {
                return (int)manager.M2;
            }
            else if (amount < 1000)
            {
                return (int)manager.Dir;
            }
            else
            {
                return (int)manager.CEO;
            }
        }
    }
}
