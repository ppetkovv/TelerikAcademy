using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Task

            //string someString = Console.ReadLine();
            //Console.WriteLine(new string(someString.Reverse().ToArray()));

            //Second Task

            //string someString = Console.ReadLine();
            //if (someString.Where(currentChar => currentChar.Equals('(')).Count() == someString.Where(currentChar => currentChar.Equals(')')).Count())
            //    Console.WriteLine("Correct");
            //else
            //    Console.WriteLine("Incorrect");

            //Third Task

            //string pattern = Console.ReadLine();
            //string someString = Console.ReadLine();

            //int counter = 0;
            //int currentIndex = someString.IndexOf(pattern, StringComparison.InvariantCultureIgnoreCase);
            //while (currentIndex != -1)
            //{
            //    counter++;
            //    currentIndex = someString.IndexOf(pattern, currentIndex + 1,StringComparison.InvariantCultureIgnoreCase);
            //}
            //Console.WriteLine(counter);

            //Fourth Task

            //string upCaseStartPattern = "<upcase>";
            //string upCaseEndPattern = "</upcase>";
            //string input = Console.ReadLine();
            //int currentStartIndex = input.IndexOf(upCaseStartPattern);
            //int currentEndIndex = input.IndexOf(upCaseEndPattern);
            //while (currentStartIndex != -1 && currentEndIndex != -1)
            //{
            //    string textForChanging = input.Substring(currentStartIndex+8, currentEndIndex-(currentStartIndex+8)).ToUpper();
            //    input = input.Replace(input.Substring(currentStartIndex,(currentEndIndex+9)-currentStartIndex), textForChanging.ToUpper());
            //    currentStartIndex = input.IndexOf(upCaseStartPattern);
            //    currentEndIndex = input.IndexOf(upCaseEndPattern);
            //}
            //Console.WriteLine(input);

            //Fifth Task

            //string input = Console.ReadLine();
            //Console.WriteLine(input.PadRight(20, '*'));

            //Sixth Task First Way --- 20 points

            //string word = Console.ReadLine();
            //string text = Console.ReadLine();

            //long searchedSum = word.Select(charr => (int)charr).Sum();
            //List<int> startingIndexesOfWords = new List<int>();

            //for (int i = 0; i < text.Length - (word.Length - 1); i++)
            //{
            //    long currentSum = 0;
            //    for (int j = i; j < i + word.Length; j++)
            //    {
            //        currentSum += text[j];
            //    }
            //    if ((currentSum == searchedSum) && (i - 1 < 0 || !Char.IsLetter(text[i - 1])) && (i + 1 >= text.Length || !Char.IsLetter(text[i + word.Length])))
            //    {
            //        startingIndexesOfWords.Add(i);
            //    }
            //}

            //int sentenceStartIndex = 0;
            //int currentIndexOfDot = text.IndexOf('.');
            //while (currentIndexOfDot != -1)
            //{
            //    for (int i = 0; i < startingIndexesOfWords.Count; i++)
            //    {
            //        if (startingIndexesOfWords[i] < currentIndexOfDot)
            //        {
            //            Console.Write(text.Substring(sentenceStartIndex, currentIndexOfDot - sentenceStartIndex) + ".");
            //            startingIndexesOfWords.RemoveAt(i);
            //            i--;
            //        }
            //    }

            //    sentenceStartIndex = currentIndexOfDot + 1;
            //    currentIndexOfDot = text.IndexOf('.', currentIndexOfDot + 1);
            //}

            //Sixth Task Second Way --- 20 points

            //string pattern = string.Format("\\b{0}\\b", Console.ReadLine());
            //string[] sentences = Console.ReadLine().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    if(Regex.IsMatch(sentences[i],pattern))
            //    {
            //        Console.Write(sentences[i]+".");
            //    }
            //}

            //Sixth Task Third Way --- 100 points

            //string word = Console.ReadLine();
            //string text = Console.ReadLine();
            //StringBuilder finalResult = new StringBuilder();

            //int lowerBorder = 0;
            //int indexOfDot = text.IndexOf('.');
            //while (indexOfDot != -1)
            //{
            //    string currentSentence = text.Substring(lowerBorder, indexOfDot - lowerBorder);
            //    bool isCurrentSentenceForPrinting = false;
            //    int indexOfWord = currentSentence.IndexOf(word);

            //    while (indexOfWord != -1)
            //    {
            //        if ((indexOfWord - 1 < 0 || !Char.IsLetter(currentSentence[indexOfWord - 1])) && (indexOfWord + word.Length >= currentSentence.Length || !Char.IsLetter(currentSentence[indexOfWord + word.Length])))
            //        {
            //            isCurrentSentenceForPrinting = true;
            //            break;
            //        }
            //        indexOfWord = currentSentence.IndexOf(word, indexOfWord + 1);
            //    }

            //    if (isCurrentSentenceForPrinting)
            //    {
            //        finalResult.Append(currentSentence.Trim()).Append(". ");
            //    }

            //    lowerBorder = indexOfDot + 1;
            //    indexOfDot = text.IndexOf('.', indexOfDot + 1);
            //}

            //Console.WriteLine(finalResult.ToString().Trim());

            //Sixth Task Fourth Way --- 10 points

            //string word = Console.ReadLine();
            //string text = Console.ReadLine();
            //HashSet<string> finalSentences = new HashSet<string>();

            //int indexOfWord = text.IndexOf(word);
            //while (indexOfWord != -1)
            //{
            //    if ((indexOfWord - 1 < 0 || !Char.IsLetter(text[indexOfWord - 1])) && (indexOfWord + word.Length >= text.Length || !Char.IsLetter(text[indexOfWord + word.Length])))
            //    {
            //        StringBuilder currentSentence = new StringBuilder();
            //        int sentenceStartIndex = 0;
            //        int sentenceEndIndex = 0;
            //        for (int i = indexOfWord; i >= 0; i--)
            //        {
            //            if(Char.IsUpper(text[i]))
            //            {
            //                sentenceStartIndex = i;
            //                break;
            //            }
            //        }
            //        for (int i = indexOfWord; i < text.Length; i++)
            //        {
            //            if(text[i]=='.')
            //            {
            //                sentenceEndIndex = i;
            //                break;
            //            }
            //        }
            //        currentSentence.Append(text.Substring(sentenceStartIndex, (sentenceEndIndex - sentenceStartIndex) + 1)).Append(" ");
            //        finalSentences.Add(currentSentence.ToString());
            //    }
            //    indexOfWord = text.IndexOf(word, indexOfWord + 1);
            //}

            //for (int i = 0; i < finalSentences.Count; i++)
            //{
            //    if (i != finalSentences.Count - 1)
            //    {
            //        Console.Write(finalSentences.ElementAt(i));
            //    }
            //    else
            //    {
            //        Console.Write(finalSentences.ElementAt(finalSentences.Count - 1).Trim());
            //    }
            //}

            //Seventh Task

            //string input = Console.ReadLine();
            //foreach (char character in input)
            //{
            //    Console.Write(string.Format("\\u{0}",((int)character).ToString("X4")));
            //}
            //Console.WriteLine();

            //Eight Task

            //string URL = Console.ReadLine();
            //int indexOfDoubleDots = URL.IndexOf(':');
            //StringBuilder finalResult = new StringBuilder();
            //finalResult.Append(string.Format("[protocol] = {0}", URL.Substring(0, indexOfDoubleDots))).Append('\n');
            //int indexOfSecondSlash = URL.IndexOf('/', URL.IndexOf('/') + 1);
            //int indexOfThirdSlash = URL.IndexOf('/', indexOfSecondSlash + 1);
            //finalResult.Append(string.Format("[server] = {0}", URL.Substring(indexOfSecondSlash + 1, indexOfThirdSlash - (indexOfSecondSlash + 1)))).Append('\n');
            //finalResult.Append(string.Format("[resource] = {0}", URL.Substring(indexOfThirdSlash))).Append('\n');
            //Console.Write(finalResult.ToString());

            //Nineth Task

            //string input = Console.ReadLine();
            //input = Regex.Replace(input, "(<a href=\")(.*?)(\">)(.*?)(</a>)", m=>string.Format("[{0}]({1})",m.Groups[4].Value,m.Groups[2].Value));
            //Console.WriteLine(input);

            //Tenth Task

            //string input = Console.ReadLine();
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    int secI = i;
            //    while (secI < input.Length - 1 && input[secI].Equals(input[secI + 1]))
            //    {
            //        secI++;
            //    }
            //    result.Append(input[i]);
            //    i = secI;
            //}
            //Console.WriteLine(result.ToString());
        }
        //private static bool IsEnglishLetter(char c)
        //{
        //    return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        //}
    }
}