using System;

/*
    Creativity:
    - Added more complex animations to the breathing activity
    - Added options to choose the duration before starting an activity 
      since it really doesn't make sense to me to have a fixed duration for all activities
    - Added an option to return to the menu if the user decides not to start the activity
    - I also couldn't find any way to make everything private, specifically the Run method
      and the Activity constructors, since they are the entry points for the activities
*/
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.MenuChoices();
    }
}