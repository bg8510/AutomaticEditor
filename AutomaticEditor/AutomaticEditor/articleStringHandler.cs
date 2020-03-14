using System.Collections.Generic;

namespace AutomaticEditor
{
    public class ArticleStringHandler
    {
        List<string> commentTexts;

        // The 
        public ArticleStringHandler()
        {
            commentTexts = new List<string>(65);

            commentTexts.Add(" --------------------------------------------------------");
            commentTexts.Add("Use the indefinite article “a” when referring to a single, nonspecific object that begins with a consonant.");
            commentTexts.Add("Use the indefinite article “an” when referring to a single, nonspecific object if the next word begins with a vowel sound.​");
            commentTexts.Add("Use the definite article “the” when referring to a specific object that both the person speaking and the listener are familiar with.");
            commentTexts.Add("The first time you reference something use an indefinite article, then use a definite article when you repeat that object. (Because once it has been introduced, it is then known to the reader.)");
            commentTexts.Add("Do not use an article with countries, states, counties or provinces, lakes and mountains, except when the country is a collection of states such as “the” United Kingdom.");
            commentTexts.Add("Use an article with bodies of water, oceans, and seas");
            commentTexts.Add("Do not use an article when you are speaking about things in general, rather than an instance of the thing, and use the plural noun form if it is a countable object.");
            commentTexts.Add("When you are speaking about a thing in general rather than a specific instance of the thing, use the plural noun form.");
            commentTexts.Add("Do not use an article when you are speaking about meals, places, and transport");
            commentTexts.Add(" ");
            commentTexts.Add("“A” is an indefinite article and should be used before nouns describing any general item or person, while “the” is a definite article and should be used to describe a specific item or person.");
            commentTexts.Add("Use “the” when referring to one particular instance, which the reader can identify, of a thing, rather than to a general thing.");
            commentTexts.Add("Phrases such as “complex 1” and “group C” should not be preceded by the article “the,” because the letter or number appearing after the noun makes the noun unique, thus eliminating the need for an article.");
            commentTexts.Add("The definite article “the” is used before decades (e.g., the 1980s).");
            commentTexts.Add("Do not use “the” or “a” when referring to a category of thing rather than to a specific instance of the thing.");
            commentTexts.Add("Superlatives such as “highest” and “fastest” take the definite article “the” before them.");
            commentTexts.Add("In a series of nouns that take the same article, the article need not be repeated before every noun.");
            commentTexts.Add("Ordinal adjectives such as “first,” “fifth,” and “last” are typically preceded by the definite article “the.”");
            commentTexts.Add("The article “an” is used with nouns that begin with a vowel sound irrespective of the letter they begin with.");
            commentTexts.Add("Articles such as “a,” “an,” and “the” are generally not required in titles, headings, or captions.");
            commentTexts.Add(" ");
        }

        public List<string> GetArticleCommentStrings()
        {
            return commentTexts;
        }
    }
}