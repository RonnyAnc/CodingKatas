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
        "ch", "qu", "th", "rh"
    };
    private static readonly List<string> ConsonantsWithThreeCharacters = new()
    {
        "thr", "sch"
    };

    public static string Convert(string sentence)
    {
        bool DoesStartWithTwoConsonants(string word) => ConsonantsWithTwoCharacters.Any(word.StartsWith);

        bool DoesStartWithConsonantFollowedByQu(string word) => 
            !NonConsonantInitialSounds.Any(word.StartsWith) && word[1..3] == "qu";

        bool DoesStartWithThreeConsonants(string word) =>
            word.Length > 2 
            && (ConsonantsWithThreeCharacters.Any(word.StartsWith) ||
                DoesStartWithConsonantFollowedByQu(word));

        bool DoesStartWithVowelSound(string word) => NonConsonantInitialSounds.Any(word.StartsWith);

        string ConvertWord(string word) => word switch
            {
                _ when DoesStartWithVowelSound(word) => $"{word}ay",
                _ when DoesStartWithThreeConsonants(word) => $"{word[3..]}{word[..3]}ay",
                _ when DoesStartWithTwoConsonants(word) => $"{word[2..]}{word[..2]}ay",
                _ => $"{word[1..]}{word.First()}ay"
            };

        return sentence
            .Split(" ")
            .Select(ConvertWord)
            .Aggregate((w1, w2) => $"{w1} {w2}");
    }
}