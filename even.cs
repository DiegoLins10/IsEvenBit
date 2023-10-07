class Even{
     
    // Returns 0 if n
    // is even, else odd
    static int isEven(int n)
    {
         
        // n&1 is 1, then
        // odd, else even
        // !é um operador NOT lógico. Quando você passa um valor zero, você recebe de volta um; se você passar por um valor diferente de zero, receberá zero.
        // n & 1mascara o intwith 1, que tem uma representação binária 0000000000001, ou seja, apenas o último bit é definido
        //Os números pares têm zero no último bit; números ímpares têm um no último bit
        return (n & 1);
    }
     
    // Driver code
    public static void Main()
    {
        int n = 101;
        if(isEven(n)==0)
            Console.Write("Even");
        else
            Console.Write("Odd");
    }
}
