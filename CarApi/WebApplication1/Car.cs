﻿namespace WebApplication1
{
    public class Car
    {
        public Car(string name, int year) {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }    
        public int Year { get; set; }
    }
}
