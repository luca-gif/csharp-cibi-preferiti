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

Console.WriteLine("ultimo cibo: " + myFoods[myFoods.Length -1]);

// Bonus Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
// Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
// In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.


if (myFoods.Length % 2 == 1)
{
    Console.WriteLine(myFoods[myFoods.Length / 2]);
}
else
{
    Console.WriteLine(myFoods[myFoods.Length / 2]);
    Console.WriteLine(myFoods[myFoods.Length / 2 - 1]);
}