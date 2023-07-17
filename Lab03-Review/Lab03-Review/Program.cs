namespace Lab03_Review
{
    public class Review
    {
        public static void Main(string[] args)
        {
            // Main entry point of the program
            // Invokes each challenge method
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();

            Console.ReadLine(); // Pause console window before exiting
        }

        public static void Challenge1()
        {
            // Challenge 1: Product of Three Numbers
            Console.WriteLine("Enter 3 numbers: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int product = 1;
            for (int i = 0; i < 3 && i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int number))
                {
                    product *= number;
                }
                else
                {
                    product *= 1;
                }
            }

            Console.WriteLine("Challenge1 Output: " + product);
        }

        public static void Challenge2()
        {
            // Challenge 2: Calculate Average
            Console.WriteLine("Enter a number between 2-10: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 2 && number <= 10)
            {
                int[] randomNumbers = new int[number];

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine((i + 1) + " of " + number + " - Enter a number: ");
                    string randomNumberInput = Console.ReadLine();

                    if (int.TryParse(randomNumberInput, out int randomNumber) && randomNumber >= 0)
                    {
                        randomNumbers[i] = randomNumber;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Use a positive number.");
                        i--;
                    }
                }

                double average = CalculateAverage(randomNumbers);
                Console.WriteLine("The average of these " + number + " numbers is: " + average);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 2 and 10.");
            }
        }

        public static void Challenge3()
        {
            // Challenge 3: Print Pattern
            Console.WriteLine("Challenge3 Output:");
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
            Console.WriteLine(" *******");
            Console.WriteLine("  *****");
            Console.WriteLine("   ***");
            Console.WriteLine("    *");
        }

        public static void Challenge4()
        {
            // Challenge 4: Most Frequent Number
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int mostFrequentNumber = FindMostFrequentNumber(numbers);

            Console.WriteLine("Challenge 4 Output: " + mostFrequentNumber);
        }

        public static void Challenge5()
        {
            // Challenge 5: Find Maximum Value
            Console.WriteLine("Enter a series of numbers separated by commas:");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i].Trim(), out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid array of integers.");
                    return;
                }
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
                Console.WriteLine("The maximum value is: " + max);
            }
        }

        public static void Challenge6()
        {
            // Challenge 6: Save Word to File
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            SaveWordToFile(word);
        }

        public static void Challenge7()
        {
            // Challenge 7: Read File Content
            string content = ReadFileContent();
            Console.WriteLine("Challenge7 Output:");
            Console.WriteLine(content);
        }

        public static void Challenge8()
        {
            // Challenge 8: Remove Word from File
            Console.WriteLine("Enter a word to remove: ");
            string wordToRemove = Console.ReadLine();
            RemoveWordFromFile(wordToRemove);
        }

        public static void Challenge9()
        {
            // Challenge 9: Word Length Array
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] wordArray = GetWordLengthArray(sentence);
            Console.WriteLine("Challenge9 Output:");
            foreach (string word in wordArray)
            {
                Console.WriteLine(word);
            }
        }

        private static double CalculateAverage(int[] numbers)
        {
            // Calculates the average of an array of numbers
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (double)sum / numbers.Length;
        }

        private static int FindMostFrequentNumber(int[] numbers)
        {
            // Finds the most frequent number in an array
            int mostFrequent = numbers[0];
            int maxCount = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = numbers[i];
                }
            }

            return mostFrequent;
        }

        private static int FindMaximumValue(int[] numbers)
        {
            // Finds the maximum value in an array
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }

        private static void SaveWordToFile(string word)
        {
            // Saves a word to a file
            using (StreamWriter file = new StreamWriter("words.txt", true))
            {
                file.WriteLine(word);
            }
        }

        private static string ReadFileContent()
        {
            // Reads the content of a file
            return File.ReadAllText("words.txt");
        }

        private static void RemoveWordFromFile(string wordToRemove)
        {
            // Removes a word from a file
            string filePath = "words.txt";
            string[] lines = File.ReadAllLines(filePath);
            File.WriteAllText(filePath, string.Empty);

            foreach (string line in lines)
            {
                if (line != wordToRemove)
                {
                    using (StreamWriter file = new StreamWriter(filePath, true))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        private static string[] GetWordLengthArray(string sentence)
        {
            // Splits a sentence into words and returns an array with word lengths
            if (sentence == null)
            {
                return Array.Empty<string>();
            }

            string[] words = sentence.Split(' ');
            string[] wordArray = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string wordInfo = word + ": " + word.Length;
                wordArray[i] = wordInfo;
            }
            return wordArray;
        }
    }
}
