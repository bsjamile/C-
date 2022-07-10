    //Solução Challenge 2
    
    public static int simpleArraySum(List<int> ar)
    {

        int resultado = 0;
        // result += ar[0];
        // result += ar[1];
        // result += ar[2];
        // result += ar[3];
        // result += ar[4];
        // result += ar[5];

        // return result;

        foreach (int number in ar)
        {
            resultado += number;
        }
        return result;
    }


//-----------------------------------------------------------------

int [] a = new int[] {2,3,5};
int result = 0;
// result += a[0];
// result += a[1];
// result += a[2];


foreach(int number in a)
{
  result += number;
}

Console.WriteLine(result);
Console.ReadKey();