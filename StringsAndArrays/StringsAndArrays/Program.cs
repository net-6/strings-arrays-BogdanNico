using System;
using System.Text;
using System.Globalization;
using System.Linq;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of exercise to run: ");
            string exercise = Console.ReadLine();

            // 1.Write a method that to remove the nth index character from a nonempty string.
            if (exercise == "1")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                Console.WriteLine("Insert the index you want removed: ");
                int index = int.Parse(Console.ReadLine());

                string newAnything = anything.Remove(index, 1);
                Console.WriteLine("Anything with the index removed \n{0}", newAnything);
            }

            // 2.Write a method that to remove the characters which have odd index values of a given string.
            if (exercise == "2")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                RemoveOddIndexes r = new RemoveOddIndexes();
                Console.WriteLine(r.RemoveOdd(anything));
            }

            // 3.Write a method that takes input from the user and displays that input back in upper and lower cases.
            if (exercise == "3")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                string upperAnything = anything.ToUpper();
                Console.WriteLine(upperAnything);

                string lowerAnything = anything.ToLower();
                Console.WriteLine(lowerAnything);
            }

            // 4.Write a method that reverses a string if it's length is a multiple of 4.
            if (exercise == "4")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                if (anything.Length % 4 == 0)
                {
                    ReverseString r = new ReverseString();
                    Console.WriteLine(r.Reverse(anything));
                }
                else
                {
                    Console.WriteLine("The string's length is not multiple of 4.");
                }
            }

            // 5.Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            if (exercise == "5")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                int counter = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (char.IsUpper(anything[i]))
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    string UpperAnything = anything.ToUpper();
                    Console.WriteLine(UpperAnything);
                }
                else
                {
                    Console.WriteLine("There aren't at least 2 uppercases in the first 4 characters.");
                }
            }

            // 6.Write a method that to remove a newline. (it doesn't work !!!)
            if (exercise == "6")
            {
                Console.WriteLine("Insert anything you want, it must contain new line symbol: ");
                string anything = Console.ReadLine();

                Console.WriteLine(anything);

                string newAnything = anything.Replace("\n", String.Empty);
                Console.WriteLine(newAnything);
            }

            /* 7.Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long,
             the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.*/
            if (exercise == "7")
            {
                Console.WriteLine("Insert anything you want, it must have over 50 characters: ");
                string anything = Console.ReadLine();

                int numberOfLines = anything.Length / 50;

                StringBuilder sb = new StringBuilder();

                sb.Append(anything);

                int indexForNewLine = 50;

                for (int i = 1; i <= numberOfLines; i++)
                {
                    sb.Insert(indexForNewLine, '\n');
                    indexForNewLine = indexForNewLine + 51;
                }
                Console.WriteLine(sb);
            }

            // 8.Write a method that formats a number with a percentage.
            if (exercise == "8")
            {
                double number;
                Console.WriteLine("Insert a number: ");
                number = double.Parse(Console.ReadLine());
                string s = number.ToString("P2");
                Console.WriteLine(s);
            }

            // 9.Write a method that reverses a string.
            if (exercise == "9")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                ReverseString r = new ReverseString();
                Console.WriteLine(r.Reverse(anything));
            }

            // 10.Write a method that strips a set of characters from a string. (it doesn't work !!!)
            if (exercise == "10")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                Console.WriteLine("Insert index of the set you want to remove: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert the number of characters you want to remove: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(anything.Remove(index, number));
            }

            // 11.Write a method that transforms to lowercase first n characters in a string.
            if (exercise == "11")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                Console.WriteLine("Insert the number of the first characters to transform to lowercase: ");
                int n = int.Parse(Console.ReadLine());

                StringBuilder sb = new StringBuilder();

                string lowered = anything.Substring(0, n).ToLower();
                string maintained = anything.Substring(n, anything.Length - n);

                sb.Append(lowered);
                sb.Append(maintained);

                Console.WriteLine(sb);

            }

            // 12.Write a method to capitalize first and last letters of each word of a given string. (It works with only one space between words!!!)
            if (exercise == "12")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();

                string[] words = anything.Split(' ');

                //TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                foreach (string word in words)
                {
                    string string1 = word.Substring(0, 1).ToUpper();
                    string string2 = word.Substring(1, word.Length - 2);
                    string string3 = word.Substring(word.Length - 1, 1).ToUpper();

                    StringBuilder AbC = new StringBuilder();

                    AbC.Append(string1);
                    AbC.Append(string2);
                    AbC.Append(string3 + " ");

                    Console.Write(AbC);

                    //string upperWord = ti.ToTitleCase(word+" ");
                    //Console.Write(upperWord);
                }
            }

            // 13.Write a method to compute sum of digits of a given string (if any).
            if (exercise == "13")
            {
                Console.WriteLine("Insert numbers and letters: ");
                string numbersAndLetters = Console.ReadLine();

                int sum = 0;

                foreach (var item in numbersAndLetters)
                {
                    if (char.IsDigit(item))
                    {
                        sum = sum + int.Parse(item.ToString());
                    }
                }
                Console.WriteLine(sum);

                //FindNumbersSum f = new FindNumbersSum();
                //Console.WriteLine(f.findSum(numbersAndLetters));

            }

            /* 14.Clean the text. (Solved incomplete!!!)
            You will get a text from where you will need to clean the text because it contains a lot of strange 
            characters that don’t belong there ( ^ <, > &+ @%$)
            Input:
            Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.
            Output:
            Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later. */
            if (exercise == "14")
            {
                string text = "Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.";
                //char[] strangeChars = {'^','<','>','&','+','@','%','$'};
                StringBuilder sb = new StringBuilder();
                foreach (char c in text)
                {
                    if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '.') || (c == ' ') || (c == '!') || (c == ',') || (c == '\''))
                    //if((c != '^') || (c != '<') || (c != '>') || (c != '&') || (c != '+') || (c != '@') || (c != '%') || (c != '$'))                  
                    {
                        sb.Append(c);
                    }
                }
                Console.WriteLine(sb.ToString());

            }

            /* 15.Ing,ly.
            Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends
            with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.
            Input : 'abc'
            Output : 'abcing' 
            Input : 'string'
            Output: 'stringly' */
            if (exercise == "15")
            {
                Console.WriteLine("Insert a word: ");
                string word = Console.ReadLine();

                if (word.Length >= 3 && word.Substring(word.Length - 3) == "ing")
                {
                    word = word + "ly";
                }
                else if (word.Length >= 3 && word.Substring(word.Length - 3) != "ing")
                {
                    word = word + "ing";
                }

                Console.WriteLine(word);
            }

            /* 16.Obfucate Email
            You have some text that contains your email address. And you want to hide that. You decide to censor your email:to replace all
            characters in it with asterisks ('*') except the domain. Assume your email address will always be in format [username]@[domain].
            You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. You will get as input
            the email address you need to obfuscate
            Input: awesome@dotnet.com
            Output: *******@dotnet.com */
            if (exercise == "16")
            {
                Console.WriteLine("Insert an email address: ");
                string email = Console.ReadLine();

                int index = email.IndexOf('@');
                string domain = email.Substring(index);
                string obfuscate = "";
                for (int i = 0; i < index; i++)
                {
                    obfuscate = obfuscate + '*';
                }
                Console.WriteLine(obfuscate + domain);
            }

            /* 17.Re-string
            Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less
            than 2, return instead of the empty string.
            Sample String : “w3resource”
            Expected Result :”'w3ce”
            Sample String :”w3”
            Expected Result : “w3w3”
            Sample String : “w”
            Expected Result : Empty String */
            if (exercise == "17")
            {
                Console.WriteLine("Insert a word: ");
                string word = Console.ReadLine();

                if (word.Length >= 2)
                {
                    string string1 = word.Substring(0, 2);
                    string string2 = word.Substring(word.Length - 2, 2);

                    StringBuilder sb = new StringBuilder();
                    sb.Append(string1);
                    sb.Append(string2);

                    Console.WriteLine(sb);
                }
                else
                {
                    Console.WriteLine(String.Empty);
                }
            }

            /* 18.Replace Char 1
            Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', 
            except the first char itself.
            Sample String : 'restart'
            Expected Result : 'resta$t' */
            if (exercise == "18")
            {
                Console.WriteLine("Insert a word: ");
                string word = Console.ReadLine();

                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= word.Length - 1; i++)
                {
                    if (word[i] == word[0])
                    {
                        sb.Append("$");
                    }
                    else
                    {
                        sb.Append(word[i]);
                    }
                }
                Console.WriteLine(word[0] + sb.ToString());
            }

            /* 19.Replace Char 2
            Write a method to get a single string from two given strings, separated by a space and swap the first two characters of 
            each string.
            Input: 'abc', 'xyz' 
            Output: 'xyc abz' */
            if (exercise == "19")
            {
                Console.WriteLine("Insert first word: ");
                string word1 = Console.ReadLine();
                Console.WriteLine("Insert second word: ");
                string word2 = Console.ReadLine();

                string subWord11 = word1.Substring(0, 2);
                string subWord12 = word1.Substring(2);
                string subWord21 = word2.Substring(0, 2);
                string subWord22 = word2.Substring(2);

                StringBuilder sb = new StringBuilder();
                sb.Append(subWord21);
                sb.Append(subWord12);
                sb.Append(" ");
                sb.Append(subWord11);
                sb.Append(subWord22);

                Console.WriteLine(sb.ToString());
            }

            /* 20.Replace Char 3
            Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', 
            replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.
            Input: 'The lyrics is not that poor!'
            Output : 'The lyrics is poor!'
            Input  : 'The lyrics is good!'
            Output : 'The lyrics is poor!' */
            if (exercise == "20")
            {
                Console.WriteLine("Insert the sentence with not, good, poor .... : ");
                string sentence = Console.ReadLine();

                if (sentence.Contains("not") && sentence.IndexOf("not") < sentence.IndexOf("poor"))
                {
                    Console.WriteLine(sentence.Substring(0, sentence.IndexOf("not")) + "good!");
                }
                else
                {
                    if (sentence.Contains("good"))
                    {
                        Console.WriteLine(sentence.Substring(0, sentence.IndexOf("good") - 1) + " poor!");
                    }
                }
            }

            // 21.Longest word. Write a method that takes a list of words and returns the length of the longest one.
            if (exercise == "21")
            {
                Console.WriteLine("Insert a list of words: ");
                string words = Console.ReadLine();

                string[] list = words.Split(' ');

                int length = 0;

                foreach (var word in list)
                {
                    if (word.Length > length)
                    {
                        length = word.Length;
                    }
                }
                Console.WriteLine(length);
            }

            /* 22.Last Part 1
            Write a method to get the last part of a string before a specified character.
            Input :  https://www.siit.com/net-exercises
            -
            Output:  https://www.siit.com/net */
            if (exercise == "22")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();
                Console.WriteLine("Insert the character after that the text is removed: ");
                string spot = Console.ReadLine();

                Console.WriteLine(anything.Substring(0, anything.IndexOf(spot)));
            }

            /* 23.Last Part 2
            Write a method to check whether a string starts with specified characters
            input: awesome string
            a
            output : Yes, starts with a */
            if (exercise == "23")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();
                Console.WriteLine("Insert the character you want to check if the text starts with it: ");
                string firstChar = Console.ReadLine();

                if (anything[0] == firstChar[0])
                {
                    Console.WriteLine("Yes, starts with a " + firstChar[0]);
                }
                else
                {
                    Console.WriteLine("No, it doesn't start with an " + firstChar[0]);
                }
            }

            /* 24.Last Part 3
            Write a method to count occurrences of a substring in a string
            input: alabala portocala
            ala
            output : 3 */
            if (exercise == "24")
            {
                Console.WriteLine("Insert the larger string: ");
                string larger = Console.ReadLine();
                Console.WriteLine("Insert the substring to count for occurance: ");
                string inner = Console.ReadLine();

                int count = 0;

                for (var i = 0; i < larger.Length - inner.Length + 1; i++)
                {
                    if (larger.Substring(i, inner.Length).Equals(inner))
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine(count);
            }

            /* 25.Last Part 4
            Write a method to swap comma and dot in a string.
            Input: "32.054,23"
            Output: "32,054.23" */
            if (exercise == "25")
            {
                string input = "32.054,23";
                Console.WriteLine(input);

                string temp1 = input.Replace(".", "*");
                string temp2 = temp1.Replace(",", ".");
                string final = temp2.Replace("*", ",");

                Console.WriteLine(final);
            }

            // 26.Write a method to remove spaces from a given string.
            if (exercise == "26")
            {
                Console.WriteLine("Insert anything you want: ");
                string anything = Console.ReadLine();
                string spacesRemoved = anything.Replace(" ", string.Empty);
                Console.WriteLine(spacesRemoved);
            }

            // 27.Palindrome. Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
            if (exercise == "27")
            {
                Console.WriteLine("Insert the word to be checked if it is a palindrome: ");
                string word = Console.ReadLine();

                ReverseString r = new ReverseString();

                int result = string.Compare(word, r.Reverse(word), false);

                if (result == 0)
                {
                    Console.WriteLine("The word is a palindorme!");
                }
                else
                {
                    Console.WriteLine("The word IS NOT a palindrome!");
                }
            }


            /* 28.Write a method to create an array of 5 integers and display the array items. Access individual elements and 
            display them through indexes. */
            if (exercise == "28")
            {
                int[] fiveIntArray;
                fiveIntArray = new int[5];

                int item;

                Console.WriteLine("Enter the 5 integers items of the array: ");

                for (int i = 0; i < 5; i++)
                {
                    item = int.Parse(Console.ReadLine());
                    fiveIntArray[i] = item;
                }

                Console.WriteLine("The items of the array are: ");

                foreach (var element in fiveIntArray)
                {
                    Console.WriteLine(element);
                }
            }

            // 29.Write a method to reverse the order of the items in the array.
            if (exercise == "29")
            {
                Console.WriteLine("Insert the number of elements in the array: ");
                int numberOfElements = int.Parse(Console.ReadLine());

                int[] normalArray = new int[numberOfElements];

                Console.WriteLine("Insert the {0} elements of the array: ", numberOfElements);

                int element;

                for (int i = 0; i < numberOfElements; i++)
                {
                    element = int.Parse(Console.ReadLine());
                    normalArray[i] = element;
                }

                int[] reversedArray = new int[numberOfElements];

                for (int i = 0; i < numberOfElements; i++)
                {
                    reversedArray[i] = normalArray[numberOfElements - 1 - i];
                }

                Console.WriteLine("The elements of the array in reversed order are: ");

                foreach (var newElement in reversedArray)
                {
                    Console.WriteLine(newElement);
                }
            }

            // 30.Write a method to get the number of occurrences of a specified element in an array.
            if (exercise == "30")
            {
                Console.WriteLine("Insert the number of elements in the array: ");
                int numberOfElements = int.Parse(Console.ReadLine());

                int[] normalArray = new int[numberOfElements];

                Console.WriteLine("Insert the {0} elements of the array: ", numberOfElements);

                int element;

                for (int i = 0; i < numberOfElements; i++)
                {
                    element = int.Parse(Console.ReadLine());
                    normalArray[i] = element;
                }

                Console.WriteLine("Insert the element whoose number of occurences you want to get: ");
                int specificElement = int.Parse(Console.ReadLine());

                int count = 0;

                foreach (var item in normalArray)
                {
                    if (item.Equals(specificElement))
                    {
                        count++;
                    }
                }
                Console.WriteLine("The element occures {0} times", count);
            }

            // 31.Write a method to insert a new item before the second element in an existing array.
            if (exercise == "31")
            {
                int[] myIntArray = { 0, 1, 2, 3, 4, 5, 6 };
                int[] copyArray = myIntArray;

                Console.WriteLine("Write the element you want to insert before the second element of the array { 0, 1, 2, 3, 4, 5, 6 } : ");

                int element = int.Parse(Console.ReadLine());

                myIntArray = new int[8];
                myIntArray[0] = copyArray[0];
                myIntArray[1] = element;

                for (int i = 2; i <= 7; i++)
                {
                    myIntArray[i] = copyArray[i - 1];
                }

                foreach (var item in myIntArray)
                {
                    Console.WriteLine(item);
                }
            }

            // 32.Write a method to remove a specified item using the index from an array.
            if (exercise == "32")
            {
                string[] myStringArray = { "A", "B", "C", "D", "E", "F" };

                Console.WriteLine("What's the item you want to be removed form the array { A, B, C, D, E, F } ? ");
                string itemToRemove = Console.ReadLine();
                int itemIndex = Array.IndexOf(myStringArray, itemToRemove);

                Console.WriteLine("The corespondent index is {0}", itemIndex);

                string[] newStringArray = new string[myStringArray.Length - 1];

                for (int i = 0; i < itemIndex; i++)
                {
                    newStringArray[i] = myStringArray[i];
                }

                for (int i = itemIndex + 1; i < myStringArray.Length; i++)
                {
                    newStringArray[i - 1] = myStringArray[i];
                }

                foreach (var item in newStringArray)
                {
                    Console.WriteLine(item);
                }
            }

            // 33.Write a program to find the sum of all elements of the array.
            if (exercise == "33")
            {
                int[] myIntArray = { 0, 1, 2, 3, 4, 5, 6 };
                int sum = 0;

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    sum = sum + myIntArray[i];
                }

                Console.WriteLine("The sum of all elements of the array is {0}", sum);
            }

            // 34.Write a program to print all unique elements in an array.
            if (exercise == "34")
            {
                int[] myIntArray = { 0, 1, 2, 3, 5, 2, 4, 5, 6, 0, 2 };
                int[] uniqueArray = myIntArray.Distinct().ToArray();

                Console.WriteLine("The array with initial elements: ");
                for (int i = 0; i < myIntArray.Length; i++)
                {
                    Console.Write(myIntArray[i] + " ");
                }

                Console.WriteLine("\nThe array with unique elements: ");
                foreach (var unique in uniqueArray)
                {
                    Console.Write(unique + " ");
                }
            }

            // 35.Write a program to merge two arrays of same size sorted in ascending order.
            if (exercise == "35")
            {
                int[] firstArray = { 3, 5, 7, 4 };
                int[] secondArray = { 2, 1, 6, 8 };
                int[] mergedArray = firstArray.Concat(secondArray).OrderBy(x => x).ToArray();

                Console.WriteLine("The first array: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i] + " ");
                }

                Console.WriteLine("\nThe second array: ");
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i] + " ");
                }

                Console.WriteLine("\nThe merged sorted array is: ");
                foreach (var item in mergedArray)
                {
                    Console.Write(item + " ");
                }
            }

            // 36.Write a program to find maximum and minimum element in an array.
            if (exercise == "36")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                int min = myIntArray[0];
                int max = myIntArray[0];

                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    if (myIntArray[i] < min)
                    {
                        min = myIntArray[i];
                    }
                    if (myIntArray[i] > max)
                    {
                        max = myIntArray[i];
                    }
                }
                Console.WriteLine("The minimum element is: " + min);
                Console.WriteLine("The maximum element is: " + max);
            }

            // 37.Write a program to separate odd and even integers in separate arrays.
            if (exercise == "37")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");
                int oddCounter = 0;

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    if (myIntArray[i] % 2 != 0)
                    {
                        oddCounter++;
                    }
                }

                int[] oddArray = new int[oddCounter];
                int[] evenArray = new int[myIntArray.Length - oddCounter];

                int indexOddCounter = 0;

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    if (myIntArray[i] % 2 != 0)
                    {
                        oddArray[indexOddCounter] = myIntArray[i];
                        indexOddCounter++;
                    }
                }

                int indexEvenCounter = 0;

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    if (myIntArray[i] % 2 == 0)
                    {
                        evenArray[indexEvenCounter] = myIntArray[i];
                        indexEvenCounter++;
                    }
                }

                Console.WriteLine("Odd integers: ");
                foreach (int item in oddArray)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\nEven integers: ");
                foreach (int item in evenArray)
                {
                    Console.Write(item + " ");
                }
            }

            // 38.Write a program to sort elements of array in ascending order.
            if (exercise == "38")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");

                int[] ascendingArray = new int[myIntArray.Length];

                int min;

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    for (int j = i + 1; j < myIntArray.Length; j++)
                    {
                        if (myIntArray[j] < myIntArray[i])
                        {
                            min = myIntArray[j];
                            myIntArray[j] = myIntArray[i];
                            myIntArray[i] = min;
                        }
                    }
                    ascendingArray[i] = myIntArray[i];
                }
                foreach (var item in ascendingArray)
                {
                    Console.Write(item + " ");
                }
            }

            // 39.Write a program to sort elements of the array in descending order.
            if (exercise == "39")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");

                int[] descendingArray = myIntArray.OrderByDescending(x => x).ToArray();

                foreach (var item in descendingArray)
                {
                    Console.Write(item + " ");
                }
            }

            // 40.Write a program to find the second largest element in an array.
            if (exercise == "40")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");

                int[] ascendingArray = myIntArray.OrderBy(x => x).ToArray();

                Console.WriteLine(ascendingArray[myIntArray.Length - 2]);
            }

            // 41.Write a program to find the second smallest element in an array.
            if (exercise == "41")
            {
                int[] myIntArray = { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 };
                Console.WriteLine("The array is: { 52, 11, 1, 2, 3, 5, 2, 58, 4, 5, 6, 2, 32 }");

                int[] ascendingArray = myIntArray.OrderBy(x => x).ToArray();

                Console.WriteLine(ascendingArray[2]);
            }

            // 42.Write a program for a 2D array of size 3x3 and print the matrix. (it doesn't work!!!)
            if (exercise == "42")
            {
                Console.WriteLine("Insert the number of rows of the matrix:");
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert the number of columns of the matrix:");
                int columns = int.Parse(Console.ReadLine());
                int[,] matrix = new int[rows, columns];
                string inputNumber;

                Console.WriteLine("Insert the number of elements of the matrix, on rows:");
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        Console.Write("matrix[{0},{1}]", row, column);
                        inputNumber = Console.ReadLine();
                        matrix[row, column] = int.Parse(inputNumber);
                    }
                }

                Console.WriteLine("This is the matrix:");
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        Console.Write("{0} ", matrix[row, column]);
                    }
                    Console.WriteLine();
                }
            }

            // 43.Write a program in C# Sharp for addition of two Matrices of same size.
            if (exercise == "43")
            {
                int[,] firstArray =
                {
                    {1,2,3},
                    {2,3,4},
                    {4,5,6}
                };
                int[,] secondArray =
                {
                    {6,5,4},
                    {4,3,2},
                    {3,2,2}
                };
                int[,] sumArray = new int[3, 3];

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        sumArray[row, col] = firstArray[row, col] + secondArray[row, col];
                    }
                }

                Console.WriteLine("This is the sum matrix:");
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        Console.Write("{0} ", sumArray[row, column]);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
