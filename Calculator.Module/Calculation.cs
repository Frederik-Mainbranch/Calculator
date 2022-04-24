using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Module
{
    public class Calculation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Sum { get; set; }
        public string Operator { get; set; }
        public bool CommaIsEnabled { get; set; }
        public bool EqualSignIsEnabled { get; set; }

        public void AddUserInput(string input)
        {
            if(string.IsNullOrEmpty(Operator)) //add imput to Number1
            {
                string number1_string = Number1.ToString(); //Converting Number1 to string, because so the user input can be appended
                number1_string = number1_string + input; //appending the user imput
                double number1 = 0;
                if (double.TryParse(number1_string, out number1) == false) //trying to parse the new value back to double. If this fails, a error message will be displayed
                {
                    HelperClasses.Helper.Log_helper.Create_errorMessage($"Unable to parse the value '{number1_string}' to the type 'double'" +
                        $" in the method 'AddUserInput' from the class 'Calculation'");
                }
                else
                {
                    Number1 = number1;
                }
            }
            else
            {
                string number2_string = Number2.ToString(); //Converting Number1 to string, because so the user input can be appended
                number2_string = number2_string + input; //appending the user imput
                double number2 = 0;
                if (double.TryParse(number2_string, out number2) == false) //trying to parse the new value back to double. If this fails, a error message will be displayed
                {
                    HelperClasses.Helper.Log_helper.Create_errorMessage($"Unable to parse the value '{number2_string}' to the type 'double'" +
                        $" in the method 'AddUserInput' from the class 'Calculation'");
                }
                else
                {
                    Number1 = number2;
                }
            }
        }

        public void SetOperator(string _operator)
        {
            Operator = _operator;
        }

        public void SumUp()
        {
            double sum = 0;

            if(Operator == "+")
            {
                sum = Number1 + Number2;
            }
            else if(Operator == "-")
            {
                sum = Number1 - Number2;
            }
            else if(Operator == "*")
            {
                sum = Number1 * Number2;
            }
            else if(Operator == "/")
            {
                if (Number2 == 0) //Its not allowed to divide by zero
                {
                    HelperClasses.Helper.Log_helper.Create_errorMessage("It is mathematically not allowed to divide by 0.");
                }
                else
                {
                    sum = Number1 / Number2;
                }
            }

            Sum = sum;
        }
    }
}
