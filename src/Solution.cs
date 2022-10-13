using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution {
    static void Main(String[] args) {

        Console.WriteLine("Input: ");

        var input = Console.ReadLine();
        
        Console.WriteLine(CamelCase(input));
    }

    public static string CamelCase(string input)
    {
        string S_C = input.Split(";")[0];
        string M_C_V = input.Split(";")[1];
        string words = input.Split(";")[2];              

    switch (S_C)
        {
            case "S":
                if (M_C_V.Equals("M")) {
                    words = words.Remove(words.Length - 2 , 2);
                }
                return SplitWords(words).ToLower();
            case "C": 
                words = CombineWords(words);
                if (!M_C_V.Equals("C")) {
                    words = char.ToLower(words[0]) + words.Substring(1);
                    if (M_C_V.Equals("M")) {
                        words = words + "()";
                    }
                }
                return words;
            default:
                return null;
            
        }
    }

    private static string CombineWords(string words)
    {
        string[] listWords = words.Split(" ");
        string[] newListWords = { };

        foreach (string word in listWords)
        {
            string newWord = char.ToUpper(word[0]) + word.Substring(1);
            newListWords = newListWords.Append(newWord).ToArray();
        }

        words = String.Join("", newListWords);

        return words;
    }

    private static string SplitWords(string words)
    {        
        int[] indexes = words
            .Select((ch, index) => (ch, index))
            .Where(letter => Char.IsUpper(letter.ch))
            .Select(letter => letter.index)
            .ToArray();

        for (int i = 0; i < indexes.Count(); i++)
        {
            words = words.Insert(indexes[i] + i, " ");
        }
        
        return words.Trim();
    }
}
