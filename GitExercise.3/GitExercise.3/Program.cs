using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExercise._3
{
    class Program
    {
        public static bool isExerciseComplete = false;
        static void Main(string[] args)
        {
            ExpressYoSelf();
            if (!isExerciseComplete == false)
            {
                Console.WriteLine("Great job another one for the books! Keep up the good habits!!");
            }
            else
            {
                Console.WriteLine("...Your not done cupcake... get back to work... Wussy");
            }

            Console.ReadLine();
        }

        public static bool ExpressYoSelf()
        {
            Console.WriteLine("..Heading to Florida no time to chat gottta bust out this exercise");
            //todo come up with better dailoy program string maipulation, bobs example programs? Homework Solutions...

            isExerciseComplete = true;
            return isExerciseComplete;

        }
    }
}
