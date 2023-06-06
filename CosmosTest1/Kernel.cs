using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosTest1
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun() // Boot message.
        {
            Console.WriteLine("\nCodename Mooses booted successfully. Type 'help' for a list of commands.");
        }

        protected override void Run() // Main Shell
        {
            Console.Write("\nC:\\>");
            var input = Console.ReadLine();
            if (input == "help") // Help command
            {
                Console.WriteLine("\nHelp display:");
                Console.WriteLine("\nhelp: Opens a help display with an overview of the commands.");
                Console.WriteLine("osver: Shows the version of the Operating System.");
                Console.WriteLine("shutdown: Shuts down your computer.");
                Console.WriteLine("restart: Restarts your computer.");
                Console.WriteLine("color: Changes the shell color. Type 'help shell' for a list of colors.");
                Console.WriteLine("calc: Basic calculator program. Supports addition, subtraction, multiplication \nand division.");
            }

            if (input == "help color") // Help command for colors
            {
                Console.WriteLine("\nColor help display:");
                Console.WriteLine("\nDefault (Black): Trigger by typing 'color default'.");
                Console.WriteLine("Red: Trigger by typing 'color red'.");
                Console.WriteLine("Green: Trigger by typing 'color green'.");
                Console.WriteLine("Blue: Trigger by typing 'color blue'.");
                Console.WriteLine("Cyan: Trigger by typing 'color cyan'.");
                Console.WriteLine("Brown: Trigger by typing 'color brown'.");
                Console.WriteLine("Magenta: Trigger by typing 'color magenta'.");
            }

            if (input == "osver") // Version command
            {
                Console.WriteLine("\nCodename Mooses Version 0.0056 (Pre-Alpha) \n AZ Corporation 2020");
            }

            if (input == "shutdown") // Shutdown command
            {
                Cosmos.System.Power.Shutdown();
            }

            if (input == "restart") // Restart command
            {
                Cosmos.System.Power.Reboot();
            }

            if (input == "color blue") // Blue
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Color changed to blue.");
            }
            if (input == "color red") // Red
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Color changed to red.");
            }
            if (input == "color green") // Green
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Color changed to green.");
            }
            if (input == "color default") // Default
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Color changed to default.");
            }
            if (input == "color cyan") // Cyan
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Color changed to cyan.");
            }
            if (input == "color brown") // Brown
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Color changed to brown.");
            }
            if (input == "color magenta") // Magenta
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Color changed to magenta.");
            }
            if (input == "color") // Custom Error Message
            {
                Console.WriteLine("Type 'help color' to see a list of colors you can apply.");
            }

            if (input == "calc") // Calculator
            {
                float number1 = 0;
                float number2 = 0;

                Console.Write("CALCULATOR WIZARD\n\nHello, welcome to the calculator. Press any key to start calculating.");
                Console.ReadKey();

                Console.WriteLine("\n\nEnter the first number:");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nNow, enter the second number:");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDo you want to add, substract, multiply or divide?");
                Console.WriteLine("+ add = 1");
                Console.WriteLine("- substract = 2");
                Console.WriteLine("* multiply = 3");
                Console.WriteLine("/ divide = 4");
                Console.Write("\nSelection : ");

                switch (Console.ReadLine())
                {
                    case "1":
                    case "+":
                        Console.WriteLine($"\n{number1} + {number2} = " + (number1 + number2));
                        break;
                    case "2":
                    case "-":
                        Console.WriteLine($"\n{number1} - {number2} = " + (number1 - number2));
                        break;
                    case "3":
                    case "*":
                        Console.WriteLine($"\n{number1} * {number2} = " + (number1 * number2));
                        break;
                    case "4":
                    case "/":
                        Console.WriteLine($"\n{number1} / {number2} = " + (number1 / number2));
                        break;
                    case "My_Dear_Beta_Tester":
                        Console.WriteLine("Ok");
                        break;
                }
                Console.WriteLine("\nPress any key to return to shell");
                Console.ReadKey();
            }

            if (input == "test")
            {
                Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII driver = new Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII();
                driver.SetMode(800, 600);
                driver.Clear(0x255);

            }

            if (input == "caat")
            {
                Console.WriteLine("Hallo liebe Gäste, ich habe das Programm gemacht und ich heiße Caat und ja, das dauert bisschen und ich freue mich dass ihr da seid und das Programm wird jetzt loslegen.");
                Console.ReadKey();
                Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII driver = new Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII();
                driver.SetMode(800, 600);
                driver.Clear(0x255);
            }

            if (input == "res")
            {
                Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII driver = new Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII();
                driver.SetMode(1600, 900);
                Console.Write("\nC:\\>");
                Console.ReadLine();
            }




        }
    }
}






