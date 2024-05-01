using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Resume myResume = new Resume();
        myResume.Name = "John Doe";

        myResume.Jobs.Add(new Job("Microsoft", "Software Engineer", 2015, 2018));
        myResume.Jobs.Add(new Job("Google", "Software Manager", 2018, 2020));

        myResume.DisplayResume();
    }
}