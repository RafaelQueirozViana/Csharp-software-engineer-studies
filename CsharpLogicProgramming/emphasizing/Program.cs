namespace CsharpLogicProgramming {
    class Program {
        static void Main(string[] args) {
            // -------------- Variables Types: ----------------

            /* 
             int age = 20;
            long longNumber = 10000000;
            double price = 2.300;
            string name = "Pedro";
            bool isTrue = false;
            char letter = 'C';

            int newAge = age;
            newAge = 2;

            System.Console.WriteLine(age);
            System.Console.WriteLine(newAge); // it cloned, because these types of variable are cloned in the stack

            string secondName = name;
            secondName = "other";

            System.Console.WriteLine(name);
            System.Console.WriteLine(secondName);

            System.Console.WriteLine(name);

            System.Console.WriteLine($"o senhor {name} tem {age} anos, e recebe ${price} de salário"); 
             */



            // --------- Inputs, conditionals structure and loops: ---------------

            /*  System.Console.WriteLine("Type your name");
             string name = Console.ReadLine();

             System.Console.WriteLine("Type your age");
             int userAge = int.Parse(Console.ReadLine());


             System.Console.WriteLine($"name: {name}, age: {userAge}");

             if (userAge >= 18)
             {
                 System.Console.WriteLine("he has permission");
             }
             else
             {
                 System.Console.WriteLine("permission denied");
             }

             System.Console.WriteLine(getFormatedName(name));

             System.Console.WriteLine($"The bigger number is: {getHigherNumber(2, 2)}");

              int correctGuess = 5;

            int guessNumber = int.Parse(Console.ReadLine());

            while (guessNumber != correctGuess)
            {
                System.Console.WriteLine("Guess wrong, try again");
                guessNumber = int.Parse(Console.ReadLine());



            }

            System.Console.WriteLine("Congratulations! you won!");

  */


            // ------------ Triangle Exercise ----------------

            System.Console.WriteLine("Type the first triangle measurements");
            double[] array = new double[3];


            for (int i = 1; i <= 2; i++) // Triangles loop
            {
                for (int j = 1; j <= 3; j++) {
                    System.Console.WriteLine($"Triangle {i} size {j}: ");
                    array[j] = double.Parse(Console.ReadLine());
                }



            }















        }

        /*   static string getFormatedName(string name)
          {
              return $"{name} was formated!";
          }

          static int getHigherNumber(int num1, int num2)
          {
              int result;
              if (num1 > num2)
              {
                  result = num1;
              }

              else
              {
                  result = num2;
              }

              return result;


          } */

    }
}
