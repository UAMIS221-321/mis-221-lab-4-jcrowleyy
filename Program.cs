using System;
 
class Program
{
    // This function prints the pepperoni pizza slice
    static void DisplayPepperoniPizza(int rows)
    {
        Random random = new Random(); // Create a random number generator
 
        for (int i = 1; i <= rows; i++) // Loop through each row from 1 to the maximum number of rows
        {
            if (i == 1 || i == rows) // The first and last rows should only have stars (*)
            {
                for (int j = 0; j < i; j++) // Print the stars (*)
                {
                    Console.Write("* ");
                }
            }
            else // For the middle rows, we need stars on the edges and either # or [] in the middle
            {
                Console.Write("* "); // Print the left side star (*)
                // Now we loop through the middle part, where pepperoni or # can appear
                for (int j = 0; j < i - 2; j++) 
                {
                    if (random.Next(0, i - 2) == j) // Randomly place a pepperoni ([])
                    {
                        Console.Write("[] "); // Print the pepperoni
                    }
                    else
                    {
                        Console.Write("# "); // Otherwise print the hash (#) symbol
                    }
                }
 
                Console.Write("*"); // Print the right side star (*)
            }
 
            Console.WriteLine(); // Move to the next line after printing the current row
        }
    }
 
    // Main menu that lets the user pick a pizza type
    static void PizzaMenu()
    {
        bool keepRunning = true; // Boolean to keep the menu running until the user exits
 
        while (keepRunning) // Loop until the user chooses to exit
        {
            // Display the menu options
            Console.WriteLine("\nLab 4 - Menu");
            Console.WriteLine("1. Display a plain pizza slice");
            Console.WriteLine("2. Display a cheese pizza slice");
            Console.WriteLine("3. Display a pepperoni pizza slice");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine(); // Get the user's choice as input
 
            // Check the user's input and run the corresponding function
            if (choice == "1") // User chose plain pizza
            {
                int rows = new Random().Next(8, 13); // Generate a random number of rows between 8 and 12
                Console.WriteLine("\nPlain Pizza Slice:");
                DisplayPlainPizza(rows); // Call the plain pizza function
            }
            else if (choice == "2") // User chose cheese pizza
            {
                int rows = new Random().Next(8, 13); // Generate a random number of rows between 8 and 12
                Console.WriteLine("\nCheese Pizza Slice:");
                DisplayCheesePizza(rows); // Call the cheese pizza function
            }
            else if (choice == "3") // User chose pepperoni pizza
            {
                int rows = new Random().Next(8, 13); // Generate a random number of rows between 8 and 12
                Console.WriteLine("\nPepperoni Pizza Slice:");
                DisplayPepperoniPizza(rows); // Call the pepperoni pizza function
            }
            else if (choice == "4") // User chose to exit
            {
                keepRunning = false; // Set keepRunning to false, which will stop the loop
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else // User entered an invalid option
            {
                Console.WriteLine("Invalid choice, please select again."); // Prompt the user to try again
            }
        }
    }
 
    // Function to display a plain pizza slice with stars (*)
    static void DisplayPlainPizza(int rows)
    {
        for (int i = rows; i > 0; i--) // Start from the largest number of stars and decrease
        {
            for (int j = 0; j < i; j++) // Print stars (*)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
 
    // Function to display a cheese pizza slice (with stars and #)
    static void DisplayCheesePizza(int rows)
    {
        for (int i = rows; i > 0; i--) // Loop through the rows, starting from the largest
        {
            if (i == rows || i == 1) // First and last rows are all stars (*)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
            }
            else // Middle rows have * on the sides and # in the middle
            {
                Console.Write("* "); // Left side star (*)
                for (int j = 0; j < i - 2; j++) // Print the hashes (#)
                {
                    Console.Write("# ");
                }
 
                Console.Write("*"); // Right side star (*)
            }
 
            Console.WriteLine(); // Move to the next line
        }
    }
 
    // Main entry point of the program
    static void Main(string[] args)
    {
        PizzaMenu(); // Start the menu system
    }
}