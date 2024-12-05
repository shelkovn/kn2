using System.Runtime.InteropServices.Marshalling;

int countbits(int x)
{
    int ans = 0;

    while (x != 0)
    {
        //Console.WriteLine(x & 1);
        if ((x & 1) == 1)
        {
            ans++;
        }
        x >>= 1;
    }

    return ans;
}
//Console.WriteLine(countbits(15));


int multiply(int x)
{
    int ans = 1;

    while (x != 0)
    {
        ans *= x % 10;
        x /= 10;
    }
    return ans;
}
int persistence(int x)
{
    int ans = 0;

    while (Math.Abs(x) > 9)
    {
        x = multiply(x);
        //Console.WriteLine(x);
        ans++;
    }

    return ans;
}

//Console.WriteLine(persistence(999));

int digitalroot(int x) // ну она типа рекурсивная по приколу
{
    if (Math.Abs(x) < 10)
    {
        return x;
    }
    else
    {
        int newx = 0;

        while (x != 0)
        {
            newx += x % 10;
            x /= 10;
        }
        //Console.WriteLine(newx);
        return digitalroot(newx);
    }
}

//Console.WriteLine(digitalroot(942));