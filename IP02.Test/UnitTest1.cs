using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IP02 {
    [TestClass]
    public class UnitTest1 {

        //Test the RunEngine class
        [TestMethod]
        public void TestRunEngine() {
            IP02_Boelo_RunEngine engine = new IP02_Boelo_RunEngine();
            engine.test("checkbook.cbk");
        }

        //Test the check display
        [TestMethod]
        public void TestOutputGUI() {
            OutputGUI output = new OutputGUI();

            output.displayCheck(1001, "test name", 125.50, "One hundred twenty five and 50/100", "test memo", 1, 125.5);
        }
    }
}
