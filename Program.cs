// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// 1. Find the first eruption that is in Chile and print the result:

var firstChileEruption = eruptions.FirstOrDefault(e => e.Location == "Chile");
Console.WriteLine(firstChileEruption != null ? firstChileEruption.ToString() : "No Chile Eruption found");

//2. Find the first eruption from the “Hawaiian Is” location and print it. If none is found, print “No Hawaiian Is Eruption found.”:
 
var firstHawaiianEruption = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
Console.WriteLine(firstHawaiianEruption != null ? firstHawaiianEruption.ToString() : "No Hawaiian Is Eruption found");

//3. Find the first eruption that is after the year 1900 AND in “New Zealand”, then print it:

var firstNewZealandEruptionAfter1900 = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
Console.WriteLine(firstNewZealandEruptionAfter1900 != null ? firstNewZealandEruptionAfter1900.ToString() : "No New Zealand Eruption found after 1900");

//4. Find all eruptions where the volcano’s elevation is over 2000m and print them:

var eruptionsOver2000m = eruptions.Where((e) => e.ElevationInMeters > 2000).ToList();
PrintEach(eruptionsOver2000m, "Eruptions with elevation over 2000m:");

//5. Find all eruptions where the volcano’s name starts with “L” and print them. Also print the number of eruptions found:

var eruptionsStartingWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
PrintEach(eruptionsStartingWithL, "Eruptions with volcano name starting with 'L':");
Console.WriteLine($"Number of eruptions starting with 'L': {eruptionsStartingWithL.Count()}");

//6. Find the highest elevation, and print only that integer:

var highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest Elevation: {highestElevation}");

// 7. Use the highest elevation variable to find and print the name of the Volcano with that elevation:

var highestElevationVolcano = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElevation);
Console.WriteLine(highestElevationVolcano != null ? highestElevationVolcano.Volcano : "No Volcano found with the highest elevation");

//8. Print all Volcano names alphabetically:

var volcanoNamesAlphabetically = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano);
PrintEach(volcanoNamesAlphabetically, "Volcano names alphabetically:");

///9. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name:

var eruptionsBefore1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
PrintEach(eruptionsBefore1000, "Eruptions before the year 1000 CE:");

//10.  BONUS: Redo the last query, but this time use LINQ to only select the volcano’s name so that only the names are printed:

var volcanoNamesBefore1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano);
PrintEach(volcanoNamesBefore1000, "Volcano names before the year 1000 CE:");


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}




