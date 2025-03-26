

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

}