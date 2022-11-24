//Task: I will write a program that “throws” a die three times.

// Creating random number generator object
Random RandomNumbers = new Random();

// Repeatedly throwing a die
int number1 = RandomNumbers.Next(0, 100 + 0);
int number2 = RandomNumbers.Next(0, 100 + 0);
int number3 = RandomNumbers.Next(0, 100 + 0);

// Output
Console.WriteLine("Thrown numbers: " +
    number1 + "-" + number2 +
    "-" + number3);

// Waiting for Enter
Console.ReadLine();