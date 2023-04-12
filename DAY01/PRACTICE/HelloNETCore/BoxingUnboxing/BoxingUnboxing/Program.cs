//***************Boxing------Unboxing***************************

//---------------Create an empty List of type object--------------

List<object> myList = new List<object>();


//---------------Add the following values to the list: 7, 28, -1, true, "chair"---------------

myList.Add(7);
myList.Add(28);
myList.Add(-1);
myList.Add(true);
myList.Add("chair");


//---------------Loop through the list and print all values-------------------------------


for(int i =0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}


//-----------------Add all values that are Int type together and output the sum-----------------------------


int somme = 0;
foreach(object element in myList)
{
    
    if (element is int)
    {
        somme += (int)element;
    }
}
Console.WriteLine("La somme des entiers dans la liste est : " + somme);