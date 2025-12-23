using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Compare Two Strings Using charAt");
            Console.WriteLine("2. Create Substring Using charAt");
            Console.WriteLine("3. Return Characters Without ToCharArray");
            Console.WriteLine("4. Demonstrate NullReferenceException");
            Console.WriteLine("5. Demonstrate IndexOutOfRangeException");
            Console.WriteLine("6. Demonstrate ArgumentOutOfRangeException");
            Console.WriteLine("7. Demonstrate FormatException");
            Console.WriteLine("8. Demonstrate IndexOutOfRangeException for Arrays");
            Console.WriteLine("9. Convert Text to Uppercase");
            Console.WriteLine("10. Convert Text to Lowercase");
            Console.WriteLine("11. Split Text into Words and Display Lengths");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: CompareTwoStrings(); break;
                case 2: CreateSubstring(); break;
                case 3: ReturnCharactersWithoutToCharArray(); break;
                case 4: DemonstrateNullReferenceException(); break;
                case 5: DemonstrateIndexOutOfRangeException(); break;
                case 6: DemonstrateArgumentOutOfRangeException(); break;
                case 7: DemonstrateFormatException(); break;
                case 8: DemonstrateIndexOutOfRangeExceptionArrays(); break;
                case 9: ConvertTextToUppercase(); break;
                case 10: ConvertTextToLowercase(); break;
                case 11: SplitTextIntoWords(); break;
            }
        }
    }

    public static void CompareTwoStrings()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool customResult = CompareStringsUsingCharAt(str1, str2);
        bool builtInResult = str1.Equals(str2);

        Console.WriteLine($"\nCustom comparison result: {customResult}");
        Console.WriteLine($"Built-in Equals() result: {builtInResult}");
        Console.WriteLine($"Results match: {customResult == builtInResult}");
    }

    public static bool CompareStringsUsingCharAt(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static void CreateSubstring()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.Write("Enter start index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end index: ");
        int endIndex = Convert.ToInt32(Console.ReadLine());

        if (startIndex < 0 || endIndex > text.Length || startIndex > endIndex)
        {
            Console.WriteLine("Invalid indices");
            return;
        }

        string customSubstring = CreateSubstringUsingCharAt(text, startIndex, endIndex);
        string builtInSubstring = text.Substring(startIndex, endIndex - startIndex);

        Console.WriteLine($"\nCustom substring: {customSubstring}");
        Console.WriteLine($"Built-in Substring(): {builtInSubstring}");
        Console.WriteLine($"Results match: {customSubstring.Equals(builtInSubstring)}");
    }

    public static string CreateSubstringUsingCharAt(string text, int startIndex, int endIndex)
    {
        string result = "";
        for (int i = startIndex; i < endIndex; i++)
        {
            result += text[i];
        }
        return result;
    }

    public static void ReturnCharactersWithoutToCharArray()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char[] customChars = GetCharactersWithoutToCharArray(text);
        char[] builtInChars = text.ToCharArray();

        Console.WriteLine("\nCustom method characters:");
        for (int i = 0; i < customChars.Length; i++)
        {
            Console.Write(customChars[i] + " ");
        }

        Console.WriteLine("\n\nBuilt-in ToCharArray() characters:");
        for (int i = 0; i < builtInChars.Length; i++)
        {
            Console.Write(builtInChars[i] + " ");
        }

        bool match = true;
        if (customChars.Length == builtInChars.Length)
        {
            for (int i = 0; i < customChars.Length; i++)
            {
                if (customChars[i] != builtInChars[i])
                {
                    match = false;
                    break;
                }
            }
        }
        else
        {
            match = false;
        }

        Console.WriteLine($"\n\nResults match: {match}");
    }

    public static char[] GetCharactersWithoutToCharArray(string text)
    {
        char[] chars = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            chars[i] = text[i];
        }
        return chars;
    }

    public static void DemonstrateNullReferenceException()
    {
        Console.WriteLine("Demonstrating NullReferenceException:");

        CauseNullReferenceException();

        Console.WriteLine("\nHandling NullReferenceException:");
        HandleNullReferenceException();
    }

    public static void CauseNullReferenceException()
    {
        try
        {
            string nullString = null;
            int length = nullString.Length;
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
        }
    }

    public static void HandleNullReferenceException()
    {
        try
        {
            string nullString = null;
            string upper = nullString.ToUpper();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine("Handled: String was null, cannot perform operation");
        }
    }

    public static void DemonstrateIndexOutOfRangeException()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.Write("Enter an index to access: ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWithout exception handling:");
        AccessCharAtIndex(text, index);

        Console.WriteLine("\nWith exception handling:");
        AccessCharAtIndexSafe(text, index);
    }

    public static void AccessCharAtIndex(string text, int index)
    {
        try
        {
            char ch = text[index];
            Console.WriteLine($"Character at index {index}: {ch}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
        }
    }

    public static void AccessCharAtIndexSafe(string text, int index)
    {
        try
        {
            if (index < 0 || index >= text.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range for string of length {text.Length}");
            }
            char ch = text[index];
            Console.WriteLine($"Character at index {index}: {ch}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine("Handled: Index is out of valid range");
        }
    }

    public static void DemonstrateArgumentOutOfRangeException()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.Write("Enter start index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWithout exception handling:");
        CreateSubstringWithException(text, startIndex, length);

        Console.WriteLine("\nWith exception handling:");
        CreateSubstringWithExceptionSafe(text, startIndex, length);
    }

    public static void CreateSubstringWithException(string text, int startIndex, int length)
    {
        try
        {
            string substring = text.Substring(startIndex, length);
            Console.WriteLine($"Substring: {substring}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
        }
    }

    public static void CreateSubstringWithExceptionSafe(string text, int startIndex, int length)
    {
        try
        {
            if (startIndex < 0 || startIndex > text.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex", "Start index is out of range");
            }
            if (length < 0 || startIndex + length > text.Length)
            {
                throw new ArgumentOutOfRangeException("length", "Length is out of range");
            }
            string substring = text.Substring(startIndex, length);
            Console.WriteLine($"Substring: {substring}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine("Handled: Parameters are out of valid range");
        }
    }

    public static void DemonstrateFormatException()
    {
        Console.Write("Enter a string to parse as integer: ");
        string input = Console.ReadLine();

        Console.WriteLine("\nWithout exception handling:");
        ParseStringToInt(input);

        Console.WriteLine("\nWith exception handling:");
        ParseStringToIntSafe(input);
    }

    public static void ParseStringToInt(string input)
    {
        try
        {
            int number = int.Parse(input);
            Console.WriteLine($"Parsed integer: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
        }
    }

    public static void ParseStringToIntSafe(string input)
    {
        try
        {
            int number = int.Parse(input);
            Console.WriteLine($"Parsed integer: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Handled: '{input}' is not a valid integer format");
        }
    }

    public static void DemonstrateIndexOutOfRangeExceptionArrays()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine($"\nArray created with size {size}");
        for (int i = 0; i < size; i++)
        {
            array[i] = i + 1;
        }

        Console.Write("Enter an index to access: ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWithout exception handling:");
        AccessArrayElement(array, index);

        Console.WriteLine("\nWith exception handling:");
        AccessArrayElementSafe(array, index);
    }

    public static void AccessArrayElement(int[] array, int index)
    {
        try
        {
            int value = array[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
        }
    }

    public static void AccessArrayElementSafe(int[] array, int index)
    {
        try
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range for array of length {array.Length}");
            }
            int value = array[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine("Handled: Index is out of valid range for array");
        }
    }

    public static void ConvertTextToUppercase()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string customUpper = ConvertToUppercaseCustom(text);
        string builtInUpper = text.ToUpper();

        Console.WriteLine($"\nCustom uppercase: {customUpper}");
        Console.WriteLine($"Built-in ToUpper(): {builtInUpper}");
        Console.WriteLine($"Results match: {customUpper.Equals(builtInUpper)}");
    }

    public static string ConvertToUppercaseCustom(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            result += ch;
        }
        return result;
    }

    public static void ConvertTextToLowercase()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string customLower = ConvertToLowercaseCustom(text);
        string builtInLower = text.ToLower();

        Console.WriteLine($"\nCustom lowercase: {customLower}");
        Console.WriteLine($"Built-in ToLower(): {builtInLower}");
        Console.WriteLine($"Results match: {customLower.Equals(builtInLower)}");
    }

    public static string ConvertToLowercaseCustom(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            result += ch;
        }
        return result;
    }

    public static void SplitTextIntoWords()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] words = SplitIntoWords(text);

        Console.WriteLine($"\nNumber of words: {words.Length}");
        Console.WriteLine("\nWord\t\tLength");
        Console.WriteLine("------------------------------");

        for (int i = 0; i < words.Length; i++)
        {
            int length = GetStringLengthCustom(words[i]);
            Console.WriteLine($"{words[i]}\t\t{length}");
        }

        Console.WriteLine("\nUsing built-in methods for comparison:");
        string[] builtInWords = text.Split(' ');
        Console.WriteLine($"Built-in Split() word count: {builtInWords.Length}");
        Console.WriteLine($"Results match: {words.Length == builtInWords.Length}");
    }

    public static string[] SplitIntoWords(string text)
    {
        int wordCount = 0;
        bool inWord = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ' && !inWord)
            {
                wordCount++;
                inWord = true;
            }
            else if (text[i] == ' ')
            {
                inWord = false;
            }
        }

        string[] words = new string[wordCount];
        int wordIndex = 0;
        string currentWord = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                currentWord += text[i];
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    words[wordIndex] = currentWord;
                    wordIndex++;
                    currentWord = "";
                }
            }
        }

        if (currentWord.Length > 0)
        {
            words[wordIndex] = currentWord;
        }

        return words;
    }

    public static int GetStringLengthCustom(string text)
    {
        int length = 0;
        foreach (char c in text)
        {
            length++;
        }
        return length;
    }
}