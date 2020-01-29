using NUnit.Framework;
using E2ETests.Cases.Registration;

namespace E2ETests.Suites.Registration
{
    [TestFixture]
    public class TC001_Verify_Email_field_conditions_Suite : BaseSuite
    {
        [Test]
        public void TC001_Verify_Email_field_conditions()
        {
            var test = new TC001();
            test.Preconditions();
            // test.Step1();
            test.Step2();
            test.Step3();
            test.Step4();
            test.Step5();
            test.Step6();
        }
    }
}
