namespace Learning.module1;

public class FizzBazz
{
    // Fizzbuz. Print integers one-to-100, but print “Fizz” if an integer is divisible by three, “Buzz” if an integer is divisible by five, and “FizzBuzz” if an integer is divisible by both three and five
    public FizzBazz(int end)
    {
        for (int num = 1; num <= end; num++)
        {
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("FizzBazz");
            }
            if (num % 3 ==  0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 ==  0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}