// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int valType = 10;
object objType = valType; // Boxing


int unboxedValType = (int)objType; // Unboxing


Console.WriteLine("Unboxed Value: " + unboxedValType);