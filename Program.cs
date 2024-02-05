using System;

class Program
{
    static void Main()
    {
        // // Set the width and height of the console window
        // Console.WindowWidth = 80;  // Set the width to 80 columns
        // Console.WindowHeight = 25; // Set the height to 25 rows

        // // Your code here
        // Console.BackgroundColor = ConsoleColor.Blue;
        // Console.ForegroundColor = ConsoleColor.White;
        // Console.WriteLine("White on blue.");
        // Console.WriteLine("Another line.");
        // Console.ResetColor();

        // ConsoleKeyInfo keyInfo = Console.ReadKey();
        // Console.WriteLine("Key: " + keyInfo.Key + ", Char: " + keyInfo.KeyChar);


        // Console.WriteLine("This is a sample program with a custom console window size.");
        // Console.ReadLine(); // Pause to see the result
        int option = 1;
        mainMenu(option);
    }

    static void mainMenu(int option)
    {
        if(option == 1){
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Option 1");
            Console.ResetColor();
        }else{
            Console.WriteLine("Option 1");
        }

        if(option == 2){
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Option 2");
            Console.ResetColor();
        }else{          
            Console.WriteLine("Option 2");
        }

        if(option == 3){
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Option 3");
            Console.ResetColor();
        }else{
            Console.WriteLine("Option 3");
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if(keyInfo.Key == ConsoleKey.UpArrow){
            if(option > 1){
                option--;
                Console.Clear();
                mainMenu(option);
            }else{
                Console.Clear();
                mainMenu(option);
            }
        }else if(keyInfo.Key == ConsoleKey.DownArrow){          
            if(option < 3){
                option++;
                Console.Clear();
                mainMenu(option);
            }else{
                Console.Clear();
                mainMenu(option);
            }
        }else if(keyInfo.Key == ConsoleKey.Enter){
            Console.Clear();
            finalMenu(option);
        }else{
            Console.Clear();
            mainMenu(option);
        }

        Console.ReadLine();
    }

    static void finalMenu(int option)
    {
        Console.WriteLine("Selected option: " + option);
        Console.ReadLine(); // Pause to see the result
    }
}
