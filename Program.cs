


using System.Globalization;

OperatorExamples();

void OperatorExamples()
{
    // this statement delcares a variable and sets it to 3
    int width = 3;

    // the ++ operator increments a variable (adds 1 to it)
    width++;

    // declare two more int variables ato hold numbers and
    // use the + and * operators to add and umltiply values
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);
    while (area < 20)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area > 25);


    // the next two statements declare string variables
    // and use + to concatenate them
    string result = "The area:";
    result = result + " is " + area;
    Console.WriteLine(result);

    // a boolean variable is either true or false
    bool truthValue = true;
    Console.WriteLine(truthValue);

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Iteration #" + i);
    }

    int p = 2;
    for ( int q = 2; q < 32; q = q * 2)
    {
        while (p<q)
        {
            p = p * 2;
        }
        q = p - q;
    }

}

TryAnIf();

void TryAnIf()
{
    int someValue = 4;
    string name = "Bob";
    if ( (someValue == 3) && ( name == "Joe") )
    {
        Console.WriteLine("x is 3 and the name is Joe");
    }
    Console.WriteLine("This line runs no matter what");
}

TrySomeLoops();

void TrySomeLoops()
{
    int count = 0;
    while (count < 10)
    {
        count = count + 1;
    }
    for (int i = 0; i < 5; i++)
    {
        count = count - 1;
    }
    Console.WriteLine("The answer is " + count);
}

TryAnIfElse();

void TryAnIfElse()
{
    int x = 5;
    if (x == 10)
    {
        Console.WriteLine("x must be 10");
    }
    else
    {
        Console.WriteLine("x isn't 10");
    }
}