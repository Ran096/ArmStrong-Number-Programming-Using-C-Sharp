/*
class ArmStrong
{
    public void DigitFindMethod(int a)
    {
        int m;
        while(m !=0)
        {
            a=
        }

    }
    static void Main()
    {
        int num, n, qsum, r, Start, end, digit;
        Console.WriteLine(" Armstrong starting Number Enter");
        Start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong Ending Number Enter");
        end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong Number from starting :" + Start + " to Ending: " + end);

  


        for (num = Start; num <= end; num++)
        {
            qsum = 0;
            n = num;
            while (n != 0)
            {
                r = n % 10;
                qsum = qsum +pow(r * r * r);
                n = n / 10;
            }
            if (num == qsum)
                Console.WriteLine(num);
        }

        Console.WriteLine();

    }


}

/*

    // A simple countdown counter.
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        public void Reset(int n)
        {
            val = n;
        }
        public int Count()
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
    class NameSpaceDemo
{
    public static void Main()
    {

        CountDown ob = new CountDown(1);
        Console.WriteLine("  " + ob.Reset(0));
        ob.Count();

    }
}

}

#define EXPERIMENTAL
#define TRAL
using System;

    class test
        {
            static void Main()
            {
             #if EXPERIMENTAL
                
              Console.WriteLine("Compiled for experimental version.");

             #endif
             #if EXPERIMENTAL && TRAL
             Console.Error.WriteLine("Testing experimental trial version.");
             #endif

             Console.WriteLine("This is in all versions.");
                
            }
    }

using System;
namespace GenClassDemo
{
    class Gen<T>
    { 
        T ob;
   
    public Gen( T o)
    {
        ob = o;
    }
    public T GetOb()
    {
        return ob;
    }
    public void ShowType()
    {
        Console.WriteLine("Type of T is " + typeof(T));
    }
 }
    class GenDemo
    {
        public static void Main()
        {
            Gen<int> iOb = new Gen<int>(102); ; 
            iOb.ShowType();
            int v = iOb.GetOb();
            Console.WriteLine("value: " + v);
            Console.WriteLine();
            Gen<string> obs= new Gen<string>("Add The Gen String");
            obs.ShowType();
            string str = obs.GetOb();
            Console.WriteLine("value: " + str);
            Gen<double> obsf = new Gen<double>(1.5);
            obsf.ShowType();
            double strf = obsf.GetOb();
            Console.WriteLine("value: " + strf);
        }
    }

}
 */
using System;
public class Program
{
    
   
    public static void Main()
    {
        int digit;
        int cnt = 0, Start, end;
        Console.WriteLine(" Armstrong starting Number Enter");
        Start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong Ending Number Enter");
        end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong Number from starting :" + Start + " to Ending: " + end);
        Console.WriteLine("Enter Digit ");
        digit = Convert.ToInt32(Console.ReadLine());

        for (int m = Start; m <= end; m++)
        {
            int num = m, rem, res = 0;
            num = m;
            while (num != 0)
            {
                rem = num % 10;
                res = res + (int)Math.Pow(rem, digit);
                num = num / 10;
            }

            if (m == res)
                Console.WriteLine(" " + res);
            if (cnt == Start)
                Console.WriteLine(" " + cnt);
        }
        
    }
}

