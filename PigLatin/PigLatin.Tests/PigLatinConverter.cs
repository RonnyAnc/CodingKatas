using NUnit.Framework.Internal.Execution;

namespace PigLatin.Tests;

public static class PigLatinConverter
{
    private static readonly List<string> NonConsonantInitialSounds = new()
    {
        "a", "e", "i", "o", "u", "xr", "yt"
    };
    private static readonly List<string> ConsonantsWithTwoCharacters = new()
    {
        "ch", "qu"
    };

    public static string Convert(string word)
    {
        return word switch
        {
            var str when NonConsonantInitialSounds.Any(str.StartsWith) => 
                $"{word}ay", 
            var str when ConsonantsWithTwoCharacters.Any(str.StartsWith) => 
                $"{word.Substring(2, word.Length - 2)}{word.Substring(0, 2)}ay",
            var str when !NonConsonantInitialSounds.Any(str.StartsWith) && str.Substring(1, 2) == "qu" => 
                $"{word.Substring(3, word.Length - 3)}{word.Substring(0, 3)}ay",
            _ => 
                $"{word.Substring(1, word.Length - 1)}{word.First()}ay"
        };
    }
}