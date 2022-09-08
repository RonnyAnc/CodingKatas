using FluentAssertions;

namespace PigLatin.Tests;

public class PigLatinConverterShould
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("apple", "appleay")]
    [TestCase("e", "eay")]
    [TestCase("i", "iay")]
    [TestCase("o", "oay")]
    [TestCase("u", "uay")]
    public void add_ay_suffix_when_word_starts_with_vowel(string word, string pigLatinWord)
    {
        PigLatinConverter.Convert(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("xr", "xray")]
    [TestCase("yt", "ytay")]
    public void add_ay_suffix_when_word_starts_with_vowel_sound(string word, string pigLatinWord)
    {
        PigLatinConverter.Convert(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("pig", "igpay")]
    [TestCase("koala", "oalakay")]
    [TestCase("koala", "oalakay")]
    [TestCase("xenon",  "enonxay")]
    [TestCase("qat",    "atqay")]
    public void move_initial_letter_to_the_end_followed_by_ay_when_word_starts_with_consonant(string word, string pigLatinWord)
    {
        PigLatinConverter.Convert(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("queen", "eenquay")]
    [TestCase("chair", "airchay")]
    public void move_two_characters_consonants_together_to_the_end(string word, string pigLatinWord)
    {
        PigLatinConverter.Convert(word).Should().Be(pigLatinWord);
    }
    
    [Test]
    public void consider_a_consonant_with_three_characters_when_word_starts_with_consonant_followed_by_qu()
    {
        var wordWithThreeCharactersConsonant = "square";
        const string pigLatinWord = "aresquay";
        PigLatinConverter.Convert(wordWithThreeCharactersConsonant).Should().Be(pigLatinWord);
    }
}