using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Count Vowels and Consonants");
            Console.WriteLine("2. Reverse a String");
            Console.WriteLine("3. Palindrome String Check");
            Console.WriteLine("4. Remove Duplicates from String");
            Console.WriteLine("5. Find Longest Word in Sentence");
            Console.WriteLine("6. Find Substring Occurrences");
            Console.WriteLine("7. Toggle Case of Characters");
            Console.WriteLine("8. Compare Two Strings");
            Console.WriteLine("9. Find Most Frequent Character");
            Console.WriteLine("10. Remove Specific Character");
            Console.WriteLine("11. Check Anagrams");
            Console.WriteLine("12. Replace Word in Sentence");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: CountVowelsConsonants(); break;
                case 2: ReverseString(); break;
                case 3: PalindromeCheck(); break;
                case 4: RemoveDuplicates(); break;
                case 5: FindLongestWord(); break;
                case 6: FindSubstringOccurrences(); break;
                case 7: ToggleCase(); break;
                case 8: CompareTwoStringsLexicographically(); break;
                case 9: FindMostFrequentCharacter(); break;
                case 10: RemoveSpecificCharacter(); break;
                case 11: CheckAnagrams(); break;
                case 12: ReplaceWord(); break;
            }
        }
    }

    public static void CountVowelsConsonants()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        int vowelCount = 0;
        int consonantCount = 0;

        CountVowelsAndConsonants(text, ref vowelCount, ref consonantCount);

        Console.WriteLine($"\nVowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");
    }

    public static void CountVowelsAndConsonants(string text, ref int vowels, ref int consonants)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                if (IsVowel(ch))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
    }

    public static bool IsVowel(char ch)
    {
        char lower = ch;
        if (ch >= 'A' && ch <= 'Z')
        {
            lower = (char)(ch + 32);
        }
        return lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u';
    }

    public static void ReverseString()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string reversed = ReverseStringMethod(text);

        Console.WriteLine($"\nOriginal String: {text}");
        Console.WriteLine($"Reversed String: {reversed}");
    }

    public static string ReverseStringMethod(string text)
    {
        string reversed = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }
        return reversed;
    }

    public static void PalindromeCheck()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        bool isPalindrome = IsPalindrome(text);

        Console.WriteLine($"\n'{text}' is {(isPalindrome ? "" : "not ")}a palindrome");
    }

    public static bool IsPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    public static void RemoveDuplicates()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string result = RemoveDuplicateCharacters(text);

        Console.WriteLine($"\nOriginal String: {text}");
        Console.WriteLine($"String without duplicates: {result}");
    }

    public static string RemoveDuplicateCharacters(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < result.Length; j++)
            {
                if (text[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result += text[i];
            }
        }

        return result;
    }

    public static void FindLongestWord()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string longestWord = GetLongestWord(sentence);

        Console.WriteLine($"\nLongest Word: {longestWord}");
        Console.WriteLine($"Length: {longestWord.Length}");
    }

    public static string GetLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }

    public static void FindSubstringOccurrences()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();
        Console.Write("Enter the substring to find: ");
        string substring = Console.ReadLine();

        int count = CountSubstringOccurrences(mainString, substring);

        Console.WriteLine($"\nThe substring '{substring}' occurs {count} time(s) in '{mainString}'");
    }

    public static int CountSubstringOccurrences(string mainString, string substring)
    {
        int count = 0;

        for (int i = 0; i <= mainString.Length - substring.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                count++;
            }
        }

        return count;
    }

    public static void ToggleCase()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string toggled = ToggleCaseOfString(text);

        Console.WriteLine($"\nOriginal String: {text}");
        Console.WriteLine($"Toggled String: {toggled}");
    }

    public static string ToggleCaseOfString(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }

            result += ch;
        }

        return result;
    }

    public static void CompareTwoStringsLexicographically()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStringsLexicographically(str1, str2);

        Console.WriteLine();
        if (result < 0)
        {
            Console.WriteLine($"'{str1}' comes before '{str2}' in lexicographical order");
        }
        else if (result > 0)
        {
            Console.WriteLine($"'{str2}' comes before '{str1}' in lexicographical order");
        }
        else
        {
            Console.WriteLine($"'{str1}' and '{str2}' are equal");
        }
    }

    public static int CompareStringsLexicographically(string str1, string str2)
    {
        int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1;
            }
            else if (str1[i] > str2[i])
            {
                return 1;
            }
        }

        if (str1.Length < str2.Length)
        {
            return -1;
        }
        else if (str1.Length > str2.Length)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static void FindMostFrequentCharacter()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char mostFrequent = GetMostFrequentCharacter(text);
        int frequency = GetCharacterFrequency(text, mostFrequent);

        Console.WriteLine($"\nMost Frequent Character: '{mostFrequent}'");
        Console.WriteLine($"Frequency: {frequency}");
    }

    public static char GetMostFrequentCharacter(string text)
    {
        if (text.Length == 0)
        {
            return '\0';
        }

        char mostFrequent = text[0];
        int maxFrequency = 0;

        for (int i = 0; i < text.Length; i++)
        {
            int frequency = GetCharacterFrequency(text, text[i]);
            if (frequency > maxFrequency)
            {
                maxFrequency = frequency;
                mostFrequent = text[i];
            }
        }

        return mostFrequent;
    }

    public static int GetCharacterFrequency(string text, char ch)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ch)
            {
                count++;
            }
        }
        return count;
    }

    public static void RemoveSpecificCharacter()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.Write("Enter character to remove: ");
        char charToRemove = Console.ReadLine()[0];

        string result = RemoveCharacter(text, charToRemove);

        Console.WriteLine($"\nOriginal String: {text}");
        Console.WriteLine($"Modified String: {result}");
    }

    public static string RemoveCharacter(string text, char charToRemove)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != charToRemove)
            {
                result += text[i];
            }
        }

        return result;
    }

    public static void CheckAnagrams()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool areAnagrams = AreAnagrams(str1, str2);

        Console.WriteLine($"\n'{str1}' and '{str2}' are {(areAnagrams ? "" : "not ")}anagrams");
    }

    public static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        int[] charCount = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            charCount[str1[i]]++;
            charCount[str2[i]]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (charCount[i] != 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void ReplaceWord()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter replacement word: ");
        string newWord = Console.ReadLine();

        string result = ReplaceWordInSentence(sentence, oldWord, newWord);

        Console.WriteLine($"\nOriginal Sentence: {sentence}");
        Console.WriteLine($"Modified Sentence: {result}");
    }

    public static string ReplaceWordInSentence(string sentence, string oldWord, string newWord)
    {
        string result = "";
        string currentWord = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord == oldWord)
                {
                    result += newWord;
                }
                else
                {
                    result += currentWord;
                }
                result += ' ';
                currentWord = "";
            }
        }

        if (currentWord == oldWord)
        {
            result += newWord;
        }
        else
        {
            result += currentWord;
        }

        return result;
    }
}