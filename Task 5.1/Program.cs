int input = 0;
string result;

if (int.TryParse(Console.ReadLine(), out input))
{
    if (Enum.IsDefined(typeof(DayOfWeek), input))
    {
        result = Enum.GetName(typeof(DayOfWeek), input);
    }
    else
        throw new IndexOutOfRangeException();
}
else
    throw new Exception("Invalid int value");

Console.WriteLine(result);