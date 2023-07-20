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
            Console.WriteLine("Enter 3 numbers: "); // askss user for their input
            string input = Console.ReadLine();
            string[] numbers = input.Split(' '); // put it in a string

            int product = 1; // initilized variable, this will store the multiplied ints
            for (int i = 0; i < 3 && i < numbers.Length; i++) // loops thru input nums
            {
                if (int.TryParse(numbers[i], out int number)) // nums to int
                {
                    product *= number; // multplies current product with nums
                }
                else
                {
                    product *= 1; // if fails, it'll mutliply by 1 
                }
            }

            Console.WriteLine("Challenge1 Output: " + product);
        }

        public static void Challenge2()
        {
            // Challenge 2: Calculate Average
            Console.WriteLine("Enter a number between 2-10: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 2 && number <= 10) // checking to make sure between 2 and 10
            {
                int[] randomNumbers = new int[number]; // int array = to parsed nums

                for (int i = 0; i < number; i++) //loop
                {
                    Console.WriteLine((i + 1) + " of " + number + " - Enter a number: ");
                    string randomNumberInput = Console.ReadLine();

                    if (int.TryParse(randomNumberInput, out int randomNumber) && randomNumber >= 0)
                    {
                        randomNumbers[i] = randomNumber; // parsing is successful, num is stored in array
                    }
                    else
                    {
                        // parse fails / negative num will display this error
                        Console.WriteLine("Invalid input. Use a positive number.");
                        i--;
                    }
                }

                double average = CalculateAverage(randomNumbers);
                Console.WriteLine("The average of these " + number + " numbers is: " + average);
            }
            else
            {

                // displays if user puts something in that's not a num between 2 and 10
                Console.WriteLine("Invalid input. Please enter a number between 2 and 10.");
            }
        }

        public static void Challenge3()
        {
            // Challenge 3: Print Pattern
            Console.WriteLine("Challenge3 Output:"); // outputting the text 
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
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }; // array of nums
            int mostFrequentNumber = FindMostFrequentNumber(numbers);
            // finds the most freuqnet by passing the nums as an argu

            Console.WriteLine("Challenge 4 Output: " + mostFrequentNumber);
            // displays the solution
        }

        public static void Challenge5()
        {
            // Challenge 5: Find Maximum Value
            Console.WriteLine("Enter a series of numbers separated by commas:");
            // user input
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            // split input into indivudal strings
            int[] numbers = new int[numberStrings.Length];
            // new int = new array 
            for (int i = 0; i < numberStrings.Length; i++) //loop thru strings and parse to integars
            {
                if (int.TryParse(numberStrings[i].Trim(), out int number)) // attempt to parse
                {
                    numbers[i] = number; // successful = stored in array
                }
                else
                {
                    // not successful
                    Console.WriteLine("Invalid input. Please enter a valid array of integers.");
                    return;
                }
            }

            if (numbers.Length == 0)
            {
                // empty
                Console.WriteLine("The array is empty.");
            }
            else
            {
                int max = numbers[0]; // assumes first num is max initially
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max) // iterates thru array to find max
                        max = numbers[i]; // updates max variable from initial one
                }
                Console.WriteLine("The maximum value is: " + max);
            }
        }

        public static void Challenge6()
        {
            // Challenge 6: Save Word to File
            Console.WriteLine("Enter a word: "); // input a word in the strings
            string word = Console.ReadLine(); // puts the string in readline
            SaveWordToFile(word); // it saves the word to a file
        }

        public static void Challenge7()
        {
            // Challenge 7: Read File Content
            string content = ReadFileContent(); // reads the file from 6
            Console.WriteLine("Challenge7 Output:"); // outputs teh saved info
            Console.WriteLine(content); // content = word
        }

        public static void Challenge8()
        {
            // Challenge 8: Remove Word from File
            Console.WriteLine("Enter a word to remove: ");
            string wordToRemove = Console.ReadLine();
            RemoveWordFromFile(wordToRemove); // removes one of 2 words added t the file
        }

        public static void Challenge9()
        {
            // Challenge 9: Word Length Array
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] wordArray = GetWordLengthArray(sentence); // gets array with word length
            Console.WriteLine("Challenge9 Output:");
            foreach (string word in wordArray)
            {
                Console.WriteLine(word); // displays the words w/ its length from array
            }
        }

        private static double CalculateAverage(int[] numbers) // returns avg doubled
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

            // loop to count the occurance of each number
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                }
                // if current coutn is greater than prev max, update
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = numbers[i];
                }
            }

            return mostFrequent; // returns most frequent number
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

            // writes back all words but the one removed
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
            // loop
            for (int i = 0; i < words.Length; i++) // creates a string w/ word & length
            {
                string word = words[i];
                string wordInfo = word + ": " + word.Length;
                wordArray[i] = wordInfo; // stores 
            }
            return wordArray;
        }
    }
}
