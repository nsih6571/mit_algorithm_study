using System;


public class Alg
{
    static void Main(string[] args)
    {
        string a;

        Console.Write("h : ");
        a = Console.ReadLine();
        int h = Convert.ToInt32(a);

        Console.Write("v : ");
        a = Console.ReadLine();
        int v = Convert.ToInt32(a);

        Solution(h, v);
    }

    public static int Solution(int h, int v)
    {
        int all = h * v;// 전체


        int gcd = Gcd(h,v); //최대 공약수
        int lcm = Lcm(h,v); //최소 공배수

        if( h == 1 || v == 1)
        {
            Console.WriteLine("멀쩡한 사각형 없음");
            return 0;
        }
        else
        {
            int answer = ((h * v) - (Measure(Lcm(h / gcd, v / gcd)) * gcd));

            Console.WriteLine(answer);

            return 0;
        }
    }

    public static int Gcd(int h, int v)//최대 공약수
    {
        while(v != 0)
        {
            int r = h % v;
            h = v;
            v = r;
        }
        return h;
    }
    public static int Lcm(int h, int v)//최소공배수
    {
        return h * v / Gcd(h, v);
    }
    public static int Measure(int hv) //약수의 갯수
    {
        int Mall = 0;
        for(int i = 1; i<= hv; i++)
        {
            if( hv % i == 0 )
            {
                Mall++;
            }
        }
        return Mall;
    }
}