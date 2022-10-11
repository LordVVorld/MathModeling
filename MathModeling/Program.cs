double number = 0.2152;
int counter = 0;
while (counter < 100)
{
    Console.WriteLine(number + "   " + number * number);
    ++counter;
    number = Randomize(number);
}

static double Randomize(double number)
{
    string squareNumber = (number * number).ToString("0.00000000");
    return double.Parse(squareNumber[0..2] + squareNumber[4..8]);
}