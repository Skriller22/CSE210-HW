using System;
using System.Collections.Generic;

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
