/*
* Name: Your Full Name
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: October 02, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

using System;
class Program
{
    static void Main()
    {
        const int SlicesPerPizza = 8;
        const double TaxRate = 0.18; 

        Console.WriteLine("=== Part 1: Road Trip ===");
        Console.Write("Round trip miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.Write("Miles per gallon: ");
        double mpg = double.Parse(Console.ReadLine());
        Console.Write("Price per gallon: ");
        double pricePerGallon = double.Parse(Console.ReadLine());

        double gallonsNeeded = miles / mpg;
        double fuelCost = gallonsNeeded * pricePerGallon;

        Console.WriteLine();
        Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
        Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
        Console.WriteLine();

        Console.WriteLine("=== Part 2: Pizza Party ===");
        Console.Write("How many people are going: ");
        int people = int.Parse(Console.ReadLine());
        Console.Write("How many pizzas: ");
        int pizzas = int.Parse(Console.ReadLine());
        Console.Write("Price per pizza: ");
        double pricePerPizza = double.Parse(Console.ReadLine());

        int totalSlices = pizzas * SlicesPerPizza;
        double slicesPerPerson = (double)totalSlices / people; 
        double pizzaCost = pizzas * pricePerPizza;

        Console.WriteLine();
        Console.WriteLine("Total slices: " + totalSlices);
        Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
        Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
        Console.WriteLine();

        Console.WriteLine("=== Part 3: Paycheck ===");
        Console.Write("Hours worked this week: ");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Hourly rate: ");
        double rate = double.Parse(Console.ReadLine());

        double grossPay = hours * rate;
        double taxWithheld = grossPay * TaxRate;
        double takeHomePay = grossPay - taxWithheld;

        Console.WriteLine();
        Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
        Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
        Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
        Console.WriteLine();

        Console.WriteLine("=== Part 4: The Whole Trip ===");
        double tripTotal = fuelCost + pizzaCost;
        double costPerPerson = tripTotal / people;
        double takeHomePerHour = takeHomePay / hours;
        double hoursToWork = costPerPerson / takeHomePerHour;

        Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
        Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
        Console.WriteLine("Take home pay per hour: " + takeHomePerHour.ToString("C"));
        Console.WriteLine("Hours you must work to cover your share: " + hoursToWork.ToString("F2"));
    }
}