// See https://aka.ms/new-console-template for more information


string[] myFoods = {"pizza", "pasta", "polpette", "picanha", "pollo", "formaggio"};

//.1 La lunghezza della classifica
Console.WriteLine("Lunghezza Array: " + myFoods.Length);


//.2 La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)

foreach (var food in myFoods)

Console.WriteLine(food);

//.3 Il vostro cibo top (prima posizione della classifica)

Console.WriteLine("cibo top: " + myFoods[0]);

//.4 Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

Console.WriteLine("cibo non troppo top: " + myFoods[5]);

