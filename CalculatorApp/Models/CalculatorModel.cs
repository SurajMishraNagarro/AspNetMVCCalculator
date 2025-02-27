namespace CalculatorApp.Models
{
    public class CalculatorModel
    {

        // I created three properties as they are diff from basic feilds/vars 
        // why property : as I have to store and retrieve in the controlled form

        public int Num1 { get; set; } // number 1
        public int Num2 { get; set; } // number 2
        public int? Result { get; set; } // result of any logic that will be executed or it.

        // Functions that will be executed over the properties
        
        // Addition
        public int Add()
        {
            return Num1 + Num2;
        }

        // subtraction
        public int Subtract()
        {
            return Num1 - Num2;
        }

        // Multiplication

        public int Multiply()
        {
            return Num1 * Num2;
        }
        //Divide
        public string Divide()
        {
            if (Num2 == 0)
            {
                return "Error: Division by zero.";
            }

            int result = Num1 / Num2;

            return result.ToString();

        }

        // while researching i also got a path where i can use return type as int? which allows me to return null and 
        // using that I can make consistenty for creating the logic in return types.
    }
}
