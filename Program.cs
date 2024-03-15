namespace Prog_Fundamentals_Midterm
{
    internal class Program
    {
        private static object circumference;

        static void Main(string[] args)
        {

        // Label : Start of our Menu
        Start:
            // Display program information
            Console.WriteLine("// Name: Your Name");
            Console.WriteLine("// Date: The Current Date");
            Console.WriteLine("// Assignment: Programming 120 - Midterm\n");


            Console.WriteLine("Midterm App Main Menu:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Financial Calculator");
            Console.WriteLine("3. Geometry Calculator");
            Console.WriteLine("4. Cartesian Plane");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();


            //---- Calculator----------------
            if (choice == "1")
            {
            // Calculator

            // Label : Start of calculator
            CalculatorStart:
                // Display the name of the Calculator app and prompt the user to enter a number or type 'exit' to return to the main menu.
                Console.WriteLine("\nCalculator App:");
                Console.WriteLine("Enter a number (or type 'exit' to return to the main menu):");
                string input = Console.ReadLine();

                // Check if the user wants to exit the calculator app.
                if (input.ToLower() == "exit") goto Start;

                double initialNumber; // Variable to store the first user input as a number.

                // Attempt to parse the user input into a double. If the input is not a valid number, catch the FormatException and prompt again.
                try
                {
                    initialNumber = double.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto CalculatorStart; // Go back to the start of the calculator app to allow the user to enter a number again.
                }

                // Prompt the user for a second number.
                Console.WriteLine("Enter a second number: ");
                string userSecondNumber = Console.ReadLine();

                double secondNumber; // Variable to store the second user input as a number.

                // Attempt to parse the second user input into a double. If the input is not a valid number, catch the FormatException and prompt again.
                try
                {
                    secondNumber = double.Parse(userSecondNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto CalculatorStart; // Go back to the start of the calculator app to allow the user to enter the second number again.
                }

                // Display options for mathematical operations: Add, Subtract, Multiply, Divide, or Exit the calculator app.
                Console.WriteLine("Options: 1. Add, 2. Subtract, 3. Multiply, 4. Divide, 5. Exit");
                Console.Write("Select an operation: ");
                string operation = Console.ReadLine();

                // At this point, further implementation would be needed to handle the operation selection and perform the desired calculation.

                if (operation == "1")
                {
                    // Addition Operation
                    double sum = initialNumber + secondNumber;
                    Console.WriteLine($"The sum of {initialNumber} + {secondNumber} = {sum}");

                }
                else if (operation == "2")
                {
                    // Subtract operation
                }
                else if (operation == "3")
                {
                    // Multiply operation
                }
                else if (operation == "4")
                {
                    // Divide operation
                }
                else if (operation == "5")
                {
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Invalid operation, please try again.");
                    goto CalculatorStart;
                }
                goto Start;
            }


            //---- Financial Calculator ----------------
            else if (choice == "2")
            {
            StartFinancialCalculator:
                Console.WriteLine("Finance Calculator Options:");
                Console.WriteLine("1. Net Income");
                Console.WriteLine("2. Rule of 72");
                Console.WriteLine("3. Net Worth");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string financialChoice = Console.ReadLine();

            if (financialChoice == "1")
                {
                    Console.WriteLine("Calculate Net Income:");
                    Console.Write("Enter your income: $");
                    double income = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your costs: $");
                    double costs = Convert.ToDouble(Console.ReadLine());
                    double netIncome = income - costs;
                    Console.WriteLine("Your net income is: $" + netIncome);
                }
            else if (financialChoice == "2")
                {
                    Console.WriteLine("Calculate Rule of 72:");
                    Console.Write("Enter the annual interest rate (%): ");
                    double interestRate = Convert.ToDouble(Console.ReadLine());
                    double yearsToDouble = 72 / interestRate;
                    Console.WriteLine("It will take approximately " + yearsToDouble.ToString("0.00") + " years to double your money.");
                }
            else if (financialChoice == "3")
                {
                    Console.WriteLine("Calculate Net Worth:");
                    Console.Write("Enter your total assets: $");
                    double assets = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your total liabilities: $");
                    double liabilities = Convert.ToDouble(Console.ReadLine());
                    double netWorth = assets - liabilities;
                    Console.WriteLine("Your net worth is: $" + netWorth);
                }
            else if (financialChoice == "4")
                {
                    Console.WriteLine("Exiting the Financial Calculator. Returning to the main menu.");
                    goto Start;
                }
            else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1, 2, 3, or 4).");
                    goto StartFinancialCalculator;
                }

                goto Start;
            }

            //---- Geomertry Calculator ----------------
            else if (choice == "3")
            {
            StartGeometryCalculator:
                Console.WriteLine("Geometry Calculator Options:");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Right Circular Cone");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string geometryChoice = Console.ReadLine();

                if (geometryChoice == "1")
                {
                    Console.WriteLine("Calculate Square:");
                    Console.Write("Enter the side length: ");
                    double sideLength = Convert.ToDouble(Console.ReadLine());
                    double area = sideLength * sideLength;
                    double perimeter = 4 * sideLength;
                    Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");
                }
                else if (geometryChoice == "2")
                {
                    Console.WriteLine("Calculate Rectangle:");
                    Console.Write("Enter the length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double area = length * width;
                    double perimeter = 2 * (length + width);
                    Console.WriteLine($"Area: {area}, Circumference: {circumference}");
                }
                else if (geometryChoice == "3")
                {
                    Console.WriteLine("Calculate Circle:");
                    Console.Write("Enter the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area = Math.PI * radius * radius;
                    double circumference = 2 * Math.PI * radius;
                    Console.WriteLine($"Area: {area}, Circumference: {circumference}");
                }
                else if (geometryChoice == "4")
                {
                    Console.WriteLine("Calculate Right Circular Cone:");
                    Console.Write("Enter the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double volume = (1.0 / 3.0) * Math.PI * radius * radius * height;
                    Console.WriteLine($"Volume: {volume}");
                }
                else if (geometryChoice == "5")
                {
                    Console.WriteLine("Exiting the Geometry Calculator. Returning to the main menu.");
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1, 2, 3, 4, or 5).");
                    goto StartGeometryCalculator;
                }

                goto Start;
            }

            //---- Cartesian Plane ----------------
            else if (choice == "4")
            {
                Console.WriteLine("Cartesian Plane:");
                Console.Write("Enter the x-coordinate: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the y-coordinate: ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x == 0 && y == 0)
                {
                    Console.WriteLine("The point is at the origin.");
                }
                else if (x == 0)
                {
                    Console.WriteLine($"The point is on the y-axis at y = {y}.");
                }
                else if (y == 0)
                {
                    Console.WriteLine($"The point is on the x-axis at x = {x}.");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("The point is in Quadrant I.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("The point is in Quadrant II.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("The point is in Quadrant III.");
                }
                else
                {
                    Console.WriteLine("The point is in Quadrant IV.");
                }

                goto Start;
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the program. Have a nice day!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
                goto Start;
            }
        }
    }
}
