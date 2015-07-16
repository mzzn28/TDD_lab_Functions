using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_lab_Functions;
using Xunit;

namespace TDD_lab_Function.Test
{
    public class ExpenseTests
    {
        [Fact]
        public void RejectEntertainment()
        {
            var ourTest = new ExpenseLogic();
            int answer = ourTest.ManagerOne(200,"Entertainment");
            Assert.Equal(1,answer);
        }
        
    }
}
