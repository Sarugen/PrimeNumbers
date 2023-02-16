using System.Globalization;

List<Task> FindPrimesAsync = new();
int endNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= endNumber; i++)
{
    var task = NumberFormatInfo.InvariantInfo;
    List<Task> PrimesNumbers = new();
    bool isSimple = true;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            isSimple = false;
        }
        else
        {
            break;
        }
    }

    if (isSimple)
    {
        Console.Write(" " + i);
    }
}

Console.ReadKey();
await Task.WhenAll(FindPrimesAsync);


/*var thread = new Thread (FindPrimesAsync);
thread.Start();
void FindPrimesAsync
{
    for (int i = 1; i <= endNumber; i++)
{
        var task = NumberFormatInfo.InvariantInfo;
        List<Task> PrimesNumbers = new();
        bool isSimple = true;
        for (int j = 1; j < i; j++)
        {
            if (i % j == 0)
            {
                isSimple = false;
            }
            else
            {
                break;
            }
        }

        if (isSimple)
        {
            Console.Write(" " + i);
        }
    }

    Console.ReadKey();
}
*/