using System.Collections.Generic;

namespace TextSummary
{
    public class StringUtility
    {
         public static string SummerizeText(string text, int maxLength = 25)
                {
        
        
        
                    if (text.Length < maxLength)
                        return text;
        
                    var words = text.Split(' ');
                    var totalCharacters = 0;
                    var summaryWords = new List<string>();
        
                    foreach (var word in words)
                    {
                        summaryWords.Add(word);
                        totalCharacters += words.Length + 1;
        
        
                        if (totalCharacters > maxLength)
                            break;
                    }
        
                    return string.Join(" ", summaryWords) + "...";
                }
    }
}