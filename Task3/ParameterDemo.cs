public class ParameterDemo
{
    // Method using ref parameter
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // Method using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Pratyush Thapa";   
    }

    // Method using params keyword
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
