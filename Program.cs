using System;

namespace dowhileloop
{
    class Program
    {
        static void Main(string[] args)
        {
           int counter = 5;
           //while execute zero or more times
           //check then execute
          /*  while(counter < 5){
               Console.WriteLine("{0}- Hello", counter + 1);
               counter++;
           } */
          do{
               Console.WriteLine("{0}- Hello", counter + 1);
               counter++;
           } while(counter < 5);
        }
    }
}
