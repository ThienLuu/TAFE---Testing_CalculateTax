using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial2
{
    public class CalculateTax
    {
        public static string ValidateInput(string inputIncome)
        {
            string msg = "";

            //validation
            double income;
            bool incomeSuccessful = double.TryParse(inputIncome, out income);

            if (inputIncome == "" || inputIncome == null || inputIncome == " ")
            {
                msg = "Error – please enter a value";
            }
            else
            {
                if (incomeSuccessful == true)
                {
                    if (income < 0)
                    {
                        msg = "Error – value cannot be negative";
                    }
                    else
                    {
                        msg = CalculateTrueTax(inputIncome) + " after tax is: " + CalculateIncome(inputIncome);
                    }
                }
                else
                {
                    msg = "Error – enter numbers only";
                }
            }

            return msg;
        }
        public static string CalculateTrueTax(string inputIncome)
        {
            double income = double.Parse(inputIncome);
            double tax;

            if (income >= 0 && income <= 18200)
            {
                tax = 0;
            }
            else if (income <= 37000)
            {
                tax = (income - 18200) * 0.19;
            }
            else if (income <= 87000)
            {
                tax = (income - 37000) * 0.325 + 3572;
            }
            else if (income <= 180000)
            {
                tax = (income - 87000) * 0.37 + 19822;
            }
            else
            {
                tax = (income - 180000) * 0.45 + 54232;
            }

            return "$" + tax.ToString("0.00");
        }

        public static string CalculateIncome(string inputIncome)
        {
            double income = double.Parse(inputIncome);
            double tax;

            if (income >= 0 && income <= 18200)
            {
                tax = 0;
            }
            else if (income <= 37000)
            {
                tax = (income - 18200) * 0.19;
            }
            else if (income <= 87000)
            {
                tax = (income - 37000) * 0.325 + 3572;
            }
            else if (income <= 180000)
            {
                tax = (income - 87000) * 0.37 + 19822;
            }
            else
            {
                tax = (income - 180000) * 0.45 + 54232;
            }

            double result = income - tax;
            return "$" + result.ToString("0.00");
        }
    }
}
