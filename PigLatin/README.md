Instructions

Implement a program that translates from English to Pig Latin.

Pig Latin is a made-up children's language that's intended to be confusing. It obeys a few simple rules (below), but when it's spoken quickly it's really difficult for non-children (and non-native speakers) to understand.

* **Rule 1:** If a word begins with a vowel sound, add an "ay" sound to the end of the word. Please note that "xr" and "yt" at the beginning of a word make vowel sounds (e.g. "xray" -> "xrayay", "yttria" -> "yttriaay"). 
* **Rule 2:** If a word begins with a consonant sound, move it to the end of the word and then add an "ay" sound to the end of the word. Consonant sounds can be made up of multiple consonants, a.k.a. a consonant cluster (e.g. "chair" -> "airchay"). 
* **Rule 3:** If a word starts with a consonant sound followed by "qu", move it to the end of the word, and then add an "ay" sound to the end of the word (e.g. "square" -> "aresquay").
* **Rule 4:** If a word contains a "y" after a consonant cluster or as the second letter in a two letter word it makes a vowel sound (e.g. "rhythm" -> "ythmrhay", "my" -> "ymay").

There are a few more rules for edge cases, and there are regional variants too.

See http://en.wikipedia.org/wiki/Pig_latin for more details.

## Examples

```kotlin
// Ay is added to words that start with vowels
arrayOf("apple",  "appleay"),
arrayOf("ear",    "earay"),
arrayOf("igloo",  "iglooay"),
arrayOf("object", "objectay"),
arrayOf("under",  "underay"),

// Ay is added to words that start with vowels followed by qu
arrayOf("equal",  "equalay"),

// First letter and ay are moved to the end of words that start with consonants
arrayOf("pig",    "igpay"),
arrayOf("koala",  "oalakay"),
arrayOf("xenon",  "enonxay"),
arrayOf("qat",    "atqay"),

// Ch is treated like a single consonant
arrayOf("chair", "airchay"),

// Qu is treated like a single consonant
arrayOf("queen", "eenquay"),

// Qu and a single preceding consonant are treated like a single consonant
arrayOf("square", "aresquay"),

// Th is treated like a single consonant
arrayOf("therapy", "erapythay"),

// Thr is treated like a single consonant
arrayOf("thrush", "ushthray"),

// Sch is treated like a single consonant
arrayOf("school", "oolschay"),

// Yt is treated like a single vowel
arrayOf("yttria", "yttriaay"),

// Xr is treated like a single vowel
arrayOf("xray", "xrayay"),

// Y is treated like a consonant at the beginning of a word
arrayOf("yellow", "ellowyay"),

// Y is treated like a vowel at the end of a consonant cluster
arrayOf("rhythm", "ythmrhay"),

// Y as second letter in two letter word
arrayOf("my",     "ymay"),

// Phrases are translated
arrayOf("quick fast run", "ickquay astfay unray")
```