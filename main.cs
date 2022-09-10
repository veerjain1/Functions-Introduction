using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Test code Part 1: Square()");
    Console.WriteLine("Expect: The square of 10 is 100");
    Square(10);
    Console.WriteLine("Expect: The square of 0 is 0");
    Square(0);
    Console.WriteLine("Expect: The square of -5 is 25");
    Square(-5);
    Console.WriteLine("\n\nTest code Part 2: ConcatN()");
    Console.WriteLine("Expect: AAAAAAAAAA");
    ConcatN("A", 10);
    Console.WriteLine("Expect: ");
    ConcatN("Hello", 0);
    Console.WriteLine("Expect: World");
    ConcatN("World", 1);

    Console.WriteLine("\n\nTest code Part 3: Guess()");
    Guess(12); // Type in 13, 11, 12 as in the example above to test.

    Console.WriteLine("\n\nTest code Part 4: Factors()");
    Console.WriteLine("Expect: 1, 2, 3, 4, 6, 12");
    Factors(12);
    Console.WriteLine("Expect: 1, 13");
    Factors(13);
    Console.WriteLine("Expect: 1, 5, 25");
    Factors(25);

    Console.WriteLine("\n\nTest code Part 5: Prime()");
    Console.WriteLine("Expect: 12 is composite");
    Prime(12);
    Console.WriteLine("Expect: 13 is prime");
    Prime(13);
    Console.WriteLine("Expect: 25 is composite");
    Prime(25);

    Sig();



  }

  static void Square(int b)
  {
    Console.WriteLine("The square of "+b+" is "+(b*b) );
  }

  static void ConcatN(string a,int n)
  {
    for(int s=1; s<=n; s++){
    Console.Write(a);
    }
    Console.WriteLine("");
  }

  static void Guess(int n)
  {
    bool guess1 = false;

    while (guess1 == false)
    {
    Console.Write("Guess a number: ");
    string num = Console.ReadLine();
    int num1 = int.Parse(num);
    if(num1==n)
    {
      Console.WriteLine("Correct!");
      guess1 = true;

    }
    if(num1<n)
    {
      Console.WriteLine("Wrong! You guessed too low!");
    }
    if(num1>n)
    {
      Console.WriteLine("Wrong! You guessed too high!");
    }
    }
    
  }

   static void Factors(int n)
  {
    for(int i = 1; i<=n; i++)
    {
      if( n%i==0)
      {
        Console.WriteLine(i+" is a factor");
      }
    }
    
  }
  static void Prime(int b)
  {
    bool isPrime = true;

    for(int i =2; i<=12; i++)
    {
      
      if(b%i==0)
      {
        isPrime = false;
        Console.WriteLine(b+" is composite");
        break;
      }


    }
    if (isPrime == true)
    {
      Console.WriteLine(b+" is prime");
    }

    
  }

   static void Sig()
{
Console.WriteLine(@" __  _, ____, ____, ___,       ____, ___,   ____, ____,  
(-\ |  (-|_, (-|_, (-|_)      (-|   (-|_\_,(-|   (-|  |  
   \|   _|__, _|__, _| \_,    _ |    _|  )  _|__, _|  |_,
       (     (     (         (__/   (      (     (       ");

}


  
}