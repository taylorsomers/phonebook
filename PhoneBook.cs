using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for yes, 'Enter' for no]");
      string finishedAnswer = Console.ReadLine();
      if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Main();
      }
    }
  }

  static void AddContact()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact's name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a new contact's phone number");
    string number = Console.ReadLine();
    if (phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
    }
    else
    {
      phoneNumbers.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Whose number would you like to look up?");
    string friend = Console.ReadLine();
    if (phoneNumbers.ContainsKey(friend))
    {
      string value = phoneNumbers[friend];
      Console.WriteLine(friend + "\'s phone number is " + value);
    }
    else
    {
      Console.WriteLine("That person is not in your phone book.");
    }
    Main();
  }
}