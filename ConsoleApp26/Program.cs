// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Calculating(int x, int y)
{
    return x == y ? (x + y) * 3 : x + y;
}
Console.WriteLine(
Calculating(2, 2));
int CalculatingThisPart(int x, int y)
{
    if(y>51)
    {
       return (y - x) * 3;
    }
    else
    {
        return x- y;
    }
}
Console.WriteLine(CalculatingThisPart(51, 53));
bool CalculatingTheseParts(int x, int y)
{
    if (x + y == 30||x==30||y==30)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Calculating(30, 0);

bool NumbersCalculating(int n)
{
    if ((n >= 90 && n <= 110) || (n >= 190 && n <= 210))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(NumbersCalculating(105));

string IfElse(string s)
{
    if (s.StartsWith("if"))
    {
        return s;
    }
    else
    {
        return "if" + s;
    }
}
IfElse("else");