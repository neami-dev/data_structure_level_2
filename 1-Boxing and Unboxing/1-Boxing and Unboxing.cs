
class Boxing
{
	void BoxingExample()
	{
		int valType = 10;
		object objType = valType; // Boxing

		Console.WriteLine("Value Type: " + valType);
		Console.WriteLine("Object Type: " + objType);
	}
	void UnBoxingExample()
    {
        int valType = 10;
        object objType = valType; // Boxing


        int unboxedValType = (int)objType; // Unboxing


        Console.WriteLine("Unboxed Value: " + unboxedValType);
    }
}