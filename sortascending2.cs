class Program
{
    static void Main()
    {
        System.Console.Write("Enter the number of elements: ");
        int n = int.Parse(System.Console.ReadLine());

        int[] numbers = new int[n];
        System.Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(System.Console.ReadLine());
        }

      for (int i = 0; i < n; i++)
      {
        for (int j = 0 ; j < n-i-1; j++)
        {
          if (numbers[j] > numbers[j+1])
          {
            int temp = numbers[j];
            numbers[j] = numbers[j+1];
            numbers[j+1] = temp;
            
          }
        }
      }

        foreach (int number in numbers)
        {
            System.Console.WriteLine(number);
        }
        
    }
}  


