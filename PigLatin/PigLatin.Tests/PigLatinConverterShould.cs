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
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("xr", "xray")]
    [TestCase("yt", "ytay")]
    public void add_ay_suffix_when_word_starts_with_vowel_sound(string word, string pigLatinWord)
    {
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("pig", "igpay")]
    [TestCase("koala", "oalakay")]
    [TestCase("koala", "oalakay")]
    [TestCase("xenon",  "enonxay")]
    [TestCase("qat",    "atqay")]
    [TestCase("yellow",    "ellowyay")]
    [TestCase("my",    "ymay")]
    public void move_initial_letter_to_the_end_followed_by_ay_when_word_starts_with_consonant(string word, string pigLatinWord)
    {
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("queen", "eenquay")]
    [TestCase("chair", "airchay")]
    [TestCase("therapy", "erapythay")]
    [TestCase("rhythm", "ythmrhay")]
    public void move_two_characters_consonants_together_to_the_end(string word, string pigLatinWord)
    {
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("square", "aresquay")]
    [TestCase("rquare", "arerquay")]
    public void consider_a_consonant_with_three_characters_when_word_starts_with_consonant_followed_by_qu(
        string word, string pigLatinWord)
    {
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }
    
    [TestCase("school", "oolschay")]
    [TestCase("thrush", "ushthray")]
    public void move_three_characters_consonants_to_the_end_followed_by_ay(
        string word, string pigLatinWord)
    {
        PigLatinTranslator.Translate(word).Should().Be(pigLatinWord);
    }

    [Test]
    public void convert_a_complete_sentence()
    {
        const string sentence = "quick fast run";
        const string expectedPigLatinSentence = "ickquay astfay unray";
        PigLatinTranslator.Translate(sentence).Should().Be(expectedPigLatinSentence);
    }
}