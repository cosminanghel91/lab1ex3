/*
* Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastatura
*/

Console.WriteLine("Va rog introduceti numarul intreg pentru care doriti sa afisati ultima cifra");
int numar = int.Parse(Console.ReadLine());

int lastDigit = numar % (10);
Console.WriteLine("Ultima cifra din numarul " + numar + " este: " + lastDigit);