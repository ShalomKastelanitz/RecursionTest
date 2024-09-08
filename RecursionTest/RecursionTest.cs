using System;

public class RecursionTest
{
    public static void Main(string[] args)
    {
        //int[] arr = {1, 2, 3, 4, 5}; 
        //Console.WriteLine(multiply(4, 3));
        //Console.WriteLine(sumOfDigits(467));
        //Console.WriteLine(power(5,3));
        //reversed(423);
        //Console.WriteLine("");
        //Console.WriteLine(findSum(arr,4));
        Console.WriteLine(divide(15,4)); 
        Console.WriteLine(isPalindrome("ababav"));
    }
    //question1
    public static int multiply(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a + multiply(a, b - 1);

    }
    //question2
      public static int sumOfDigits(int num)
    {
        if(num == 0)
        {
            return 0;
        }
        
        return (num%10)+sumOfDigits(num/10);

    }
    //question3

    public static int power(int a, int b)
    {
        if (b == 0)
        {
            return 1;
        }
        return a* power(a, b-1);
    }
    //question4
    public static void reversed(int num)
    {
        if (num == 0)
        {
            return;
        }
        Console.Write(num%10);
        reversed (num/10);
    }
    //question5

    public static int findSum(int[] arr, int Length)
    {
        if(Length == 0)
        {
            return arr[Length];
        }
       int sum = arr[Length];
        return sum+=  findSum(arr, Length-1);
    }
    //question6
    public static int divide(int a, int b)
    {
        if (a < 1)
        {
            return 0;

        }
        int cnt = 0;
        if (a - b >= 0)
        {
            cnt = 1;
        }
        return cnt+divide(a-b, b);
    }
    //question7

    public static bool isPalindrome(string str)
    {
        
        if (str.Length <=1)
        {
            return true;
        }
        bool Palindrome=false;
        if (str[0] == str[str.Length - 1])
        {
            Palindrome = true;
        }
        else
        {
            return Palindrome;
        }
        string str2 = str.Substring(1, str.Length - 2);
        return Palindrome = isPalindrome(str2);
    }
    //question8

   public static string DecimalToBinary(int n)
    {
        if (n == 0)
        {
            return "0";
        }
        if (n == 1)
        {
            return "1";
        }

        return DecimalToBinary(n / 2) + (n % 2).ToString();
    }
    //question9
  public static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a % b);
    }


}