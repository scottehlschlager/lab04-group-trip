/*
* Name: Scott Ehlschlager
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person
*/

Console.Write("What is the round trip in miles? ");
int miles = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas did we need? ");
int pizzaCount = Convert.ToInt32(Console.ReadLine());

Console.Write("How much does a pizza cost? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const int slicesPerPizza = 8;

const double taxRate = 0.18;

Console.WriteLine();

//part 1

System.Console.WriteLine("=== Part 1: The Trip ===");

double fuel = FuelCost(miles, milesPerGallon, pricePerGallon);
System.Console.WriteLine("Fuel cost: " + fuel.ToString("C"));

double pizzaCost = pizzaCount * pricePerPizza;
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

double tripTotal = fuel + pizzaCost;
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

Console.WriteLine();

//part 2

Console.WriteLine("=== Part 2: The Group ===");

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
System.Console.WriteLine("People going: " + names.Length);

double[] hoursWorked = { 22, 15, 30, 18};

double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

double slicesPerPerson = pizzaCount * slicesPerPizza / names.Length;
Console.WriteLine("Slices each: " + slicesPerPerson.ToString("F1"));

double costPerPerson = tripTotal / names.Length;
System.Console.WriteLine("Cost per person: " +  costPerPerson.ToString("C"));

Console.WriteLine();

//part 3

Console.WriteLine("=== Part 3: Who Works How Long ===");

double totalHours = 0;
double totalTakeHomePay = 0;
double longestMustWork = 0;

for (int i = 0; i < names.Length; i++)
{
    double pay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double hourlyAfterTax = hourlyRates[i] - (hourlyRates[i] * taxRate);
    double takeHomePerHour = (TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate)) / hoursWorked[i];
    double hoursToCover = HoursToCover(costPerPerson, takeHomePerHour);
    Console.WriteLine($"{names[i]}: takes home {pay.ToString("C")} for {hoursWorked[i]} hours, {hourlyAfterTax.ToString("C")} per hour, must work {hoursToCover.ToString("F2")} hours");

    totalHours += hoursWorked[i];
    totalTakeHomePay += pay;
    longestMustWork = Math.Max(longestMustWork, hoursToCover);
}

System.Console.WriteLine();

System.Console.WriteLine("Total hours worked: " + totalHours);
System.Console.WriteLine("Total take home pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest anyone must work: " + longestMustWork.ToString("F2"));

//methods

//calculates the cost of fuel for the trip
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

//calculates the amount of take home pay for each trip member
static double TakeHomePay(double hours, double hourlyPay, double taxRate)
{
    double grossPay = hours * hourlyPay;
    double taxWithheld = grossPay * taxRate;
    double pay = grossPay - taxWithheld;
    return pay;
}

//calculates how many hours each member must work to cover their cost
static double HoursToCover(double costPerPerson, double takeHomePerHour)
{
    return costPerPerson / takeHomePerHour;
}