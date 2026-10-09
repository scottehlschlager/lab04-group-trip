/*
* Name: Scott Ehlschlager
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person
*/

Console.WriteLine("=== Part 1: Road Trip ===");
Console.Write("What is the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

//do the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

//do the outpout

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

Console.WriteLine();

//part 2

Console.WriteLine("=== Part 2: Pizza Party ===");
Console.Write("How many people are going? ");
int tripMembers = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas did we need? ");
int pizzaCount = Convert.ToInt32(Console.ReadLine());

Console.Write("How mcuh does a pizza cost? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

const int slicesPerPizza = 8;

double totalSlices = pizzaCount * slicesPerPizza;

double slicesPerPerson = totalSlices / tripMembers;

double pizzaCost = pizzaCount * pricePerPizza;

Console.WriteLine("Total slices: " + totalSlices.ToString());
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

Console.WriteLine();

//part 3

Console.WriteLine("=== Part 3: Paycheck ===");
Console.Write("How many hours were worked this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("How much are you paid per hour? ");
double hourlyPay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

const double taxRate = 0.18;

double grossPay = hoursWorked * hourlyPay;

double taxWithheld = grossPay * taxRate;

double takeHomePay = grossPay - taxWithheld;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withhed: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

Console.WriteLine();

//part 4

Console.WriteLine("=== Part 4: The Whole Trip ===");
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / tripMembers;

double hourlyTakeHomePay = takeHomePay / hoursWorked;

double hoursMustWork = costPerPerson / hourlyTakeHomePay;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + hourlyTakeHomePay.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("F2"));