using System;
using System.Collections.Generic;

// Creativity: 
// I added a scripture manager class to manage the creation and practice of scriptures
// I added a menu class to manage the menu options
// I used the Fisher-Yates algorithm to shuffle the words in the scripture

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture manager object
        ScriptureManager scriptureManager = new ScriptureManager();

        // Create a new menu object
        Menu menu = new Menu();

        // Start the menu
        menu.StartMenu(scriptureManager);
    }

}
