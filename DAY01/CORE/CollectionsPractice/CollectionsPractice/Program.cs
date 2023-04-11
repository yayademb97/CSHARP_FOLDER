// *******************************Three Basic Arrays**************************************************************
// ----------Create an array to hold integer values 0 through 9---------------------------------
int[] array = {1,2,3,4,5,6,7,8,9};

// ----------Create an array of the names "Tim", "Martin", "Nikki", & "Sara"------------------------------

string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};

// ------------------Create an array of length 10 that alternates between true and false values, starting with true-----------------------------------------


// *********************************List of Flavors****************************************************************

//-----------------------------Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)---------------------------------------------

List<string> cream = new List<string>();

cream.Add("Baskin Robbins");
cream.Add("Haagen Datz");
cream.Add("Movenpick");
cream.Add("Blue Bell");
cream.Add("Cornetto");


//--------Output the length of this list after building it----------------
Console.WriteLine($"the length of this list after building it is { cream.Count }" );


// ------------------Output the third flavor in the list, then remove this value--------------------------------
Console.WriteLine(cream[2]);
cream.Remove(cream[2]);


//-----------------------Output the new length of the list (It should just be one fewer!)---------------------------------

Console.WriteLine($"the new length of this list after building it is { cream.Count }");



//*******************************User Info Dictionary*****************************************

//---------------Create a dictionary that will store both string keys as well as string values-----------------------------------------------

Dictionary<string, string>   mydict = new  Dictionary<string, string>();


//---------------Add key/value pairs to this dictionary where--------------------------


/*
each key is a name from your names array
each value is a randomly selected flavor from your flavors list.

*/ 

mydict.Add("Tim", "Haagen Datz");
mydict.Add("Martin", "Baskin Robbins");
mydict.Add("Nikki", "Movenpick");
mydict.Add("Sara", "Cornetto");



//-----------------Loop through the dictionary and print out each user's name and their associated ice cream flavor-----------------------------------


//The var keyword takes the place of a type in type-inference
foreach (var entry in mydict)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}



