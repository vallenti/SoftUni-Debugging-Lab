namespace BePositive
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                var numbers = Console.ReadLine()
                    .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);
                        found = true;
                    }
                    else if (j + 1 < numbers.Count)
                    {
                        currentNum += numbers[j + 1];
                        
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);
                            found = true;
                        }
                        
                        numbers.RemoveAt(j + 1);
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }
                
                Console.WriteLine();
            }
        }
    }
}
