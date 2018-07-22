using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTrial2;

namespace CalculateTaxTestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region Req 1.
        [TestMethod]
        public void Req1_1_CheckValidations()
        {
            //step 1 - Arrange
            string inputIncome = "10.50";
            string incomeExpectedResult = "$10.50";
            string incomeActualResult;
            string taxExpectedResult = "$0.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult,taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }
        #endregion

        #region Req 2.
        [TestMethod]
        public void Req2_1_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "10000";
            string incomeExpectedResult = "$10000.00";
            string incomeActualResult;
            string taxExpectedResult = "$0.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_2_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "20000";
            string incomeExpectedResult = "$19658.00";
            string incomeActualResult;
            string taxExpectedResult = "$342.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_3_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "45000";
            string incomeExpectedResult = "$38828.00";
            string incomeActualResult;
            string taxExpectedResult = "$6172.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_4_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "151111";
            string incomeExpectedResult = "$107567.93";
            string incomeActualResult;
            string taxExpectedResult = "$43543.07";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_5_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "199955.55";
            string incomeExpectedResult = "$136743.55";
            string incomeActualResult;
            string taxExpectedResult = "$63212.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_6_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "0";
            string incomeExpectedResult = "$0.00";
            string incomeActualResult;
            string taxExpectedResult = "$0.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_7_1_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "18200";
            string incomeExpectedResult = "$18200.00";
            string incomeActualResult;
            string taxExpectedResult = "$0.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_7_2_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "37000";
            string incomeExpectedResult = "$33428.00";
            string incomeActualResult;
            string taxExpectedResult = "$3572.00";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }

        [TestMethod]
        public void Req2_8_ValidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "37001";
            string incomeExpectedResult = "$33428.68";
            string incomeActualResult;
            string taxExpectedResult = "$3572.33";
            string taxActualResult;

            //step 2 - Act
            taxActualResult = CalculateTax.CalculateTrueTax(inputIncome);
            incomeActualResult = CalculateTax.CalculateIncome(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(taxExpectedResult, taxActualResult);
            Assert.AreEqual(incomeExpectedResult, incomeActualResult);
        }
        #endregion

        #region Req 3.
        [TestMethod]
        public void Req3_1_InvalidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "abc";
            string expectedResult = "Error – enter numbers only";
            string actualResult;

            //step 2 - Act
            actualResult = CalculateTax.ValidateInput(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Req3_2_InvalidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "";
            string expectedResult = "Error – please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = CalculateTax.ValidateInput(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Req3_3_InvalidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = " ";
            string expectedResult = "Error – please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = CalculateTax.ValidateInput(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Req3_4_InvalidNumbers()
        {
            //step 1 - Arrange
            string inputIncome = "-100";
            string expectedResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = CalculateTax.ValidateInput(inputIncome);

            //step 3 - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion
    }
}
