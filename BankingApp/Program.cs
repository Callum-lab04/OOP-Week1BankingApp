/*
 * Classname: BankingApp
 * Information: Logical operators demo
 * Version 1
 * Author: Callum McConnell
 * Date: Sept. 2024
 */

// Call the BankingApp method to begin application
BuildBankingApp();

void BuildBankingApp()
{
    // Variable initialised with no value assigned
    int choice;
    double depositAmount;
    double withdrawalAmount;
    double accountBalance = 1000.00;

    //Display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read choice for the main menu
    // explicitly typecast the string input
    // from the keyboard and convert to
    // an intenger so we can then use it within the if statements
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1 || choice == 2)
    {
        Console.WriteLine("Please choose an option");
        Console.WriteLine("1 - Deposit funds");
        Console.WriteLine("2 - Withdraw funds");
        Console.WriteLine("Please choose an option (1-2)");

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", accountBalance);
            accountBalance += depositAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
        }
        if (choice == 2)
        {
            Console.WriteLine("How much do you want to withdraw from account?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            accountBalance -= withdrawalAmount;
            Console.WriteLine("The new balance for account is {0}", accountBalance);
        }
    }
    else
    {
        Console.WriteLine("Please choose a valid menu option between 1-2");
    }
}



﻿

