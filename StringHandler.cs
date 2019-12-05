using System;
using System.Collections.Generic;

namespace AutomaticEditor
{
    public class StringHandler
    {
        List<string> commentTexts;

        // The 
        public StringHandler()
        {
            commentTexts = new List<string>(47);

            commentTexts.Add(" ----------------------------------");
            commentTexts.Add(" Please make sure I did not change your intended meaning.");
            commentTexts.Add("Wordiness (the use of many words to convey an idea) should be avoided in academic writing.");
            commentTexts.Add("To achieve conciseness, use the word “respectively” to link two or more groups of words.");
            commentTexts.Add("When using an abbreviation, the last word that the abbreviation stands for should not be repeated after it.");
            commentTexts.Add("Redundancy, that is, the unnecessary repetition of words or ideas, should be avoided in academic writing.");
            commentTexts.Add("Avoid using contractions like I’d, don’t, and can’t in academic writing.");
            commentTexts.Add("Avoid using short coordinating conjunctions like “and” and “but” at the beginning of sentences.");
            commentTexts.Add("Avoid using numerals at the beginning of sentences, titles, or headings.");
            commentTexts.Add("Maintain a formal tone in academic writing.");
            commentTexts.Add("A period is typically not used at the end of a title or heading.");
            commentTexts.Add("A comma should preferably be inserted after introductory words and phrases.");
            commentTexts.Add("Two complete sentences should not be combined with only a comma.");
            commentTexts.Add("In academic writing, insert a comma before the conjunction that precedes the last element of a series (e.g., bread, eggs, and milk).");
            commentTexts.Add("Elements in a series are usually separated by commas but are separated by semicolons if the elements themselves contain commas.");
            commentTexts.Add("Compound adjectives that modify a noun are typically hyphenated but not when the first word of the adjective is an adverb ending with “-ly.”");
            commentTexts.Add("The pronoun “which” is used to introduce nonessential or supplementary information, and the pronoun “that” is used to include essential information.");
            commentTexts.Add("“A” is an indefinite article and should be used before nouns describing any general item or person, while “the” is a definite article and should be used to describe a specific item or person.");
            commentTexts.Add("Words with opposite meanings (e.g., higher and lower) should be used in pairs and should not be mixed with other pairs.");
            commentTexts.Add("Figures and tables should be referred to in the present tense.");
            commentTexts.Add("A singular subject should be accompanied by a singular verb, and plural subject should be accompanied by a plural verb.");
            commentTexts.Add("The phrase “et al.” is accompanied by a plural verb.");
            commentTexts.Add("Phrases such as “complex 1” and “group C” should not be preceded by the article “the.”");
            commentTexts.Add("The definite article “the” is used before decades (e.g., the 1980s).");
            commentTexts.Add("The article “an” is used with nouns that begin with a vowel sound irrespective of the letter they begin with.");
            commentTexts.Add("Superlatives such as “highest” and “fastest” take the definite article “the” before them.");
            commentTexts.Add("In a series of nouns that take the same article, the article need not be repeated before every noun.");
            commentTexts.Add("Ordinal adjectives such as “first,” “fifth,” and “last” are typically preceded by the definite article “the.”");
            commentTexts.Add("The preposition “in” is used when describing a change, such as an increase or decrease, whereas “of” is used for the magnitude of the change.");
            commentTexts.Add("As a general rule, verb tenses within a sentence or a paragraph should be consistent.");
            commentTexts.Add("The word “affect” is a verb and it refers to the act of influencing someone or something. The word “effect,” on the other hand, can be used as a noun or as a verb, depending on the context. Their meanings are different.");
            commentTexts.Add("In an academic context, “paper” implies a formal written composition that is intended to be published, presented, etc. The “study,” on the other hand, is the actual work carried out.");
            commentTexts.Add("Use synonyms effectively to avoid a monotonous tone in academic papers.");
            commentTexts.Add("It is not necessary to introduce an element name before using the symbol.");
            commentTexts.Add("Units of measure accompanying numerical values must be abbreviated suitably.");
            commentTexts.Add(" This is a more natural wording.");
            commentTexts.Add("The word “since” is reserved for time-related references in technical writing. To indicate causality, replace “since” with synonyms such as “because.”");
            commentTexts.Add("Use “the” when referring to one particular instance, which the reader can identify, of a thing, rather than to a general thing.");
            commentTexts.Add("Use a semicolon rather than a comma to join sentences with a conjuntive adverb.");
            commentTexts.Add("You do not need to define an abbreviation that you never use.");
            commentTexts.Add("“Use” is almost always a better word choice than “utilize.”");
            commentTexts.Add("Use the plural noun form when referring to a category of thing rather than to a specific instance of the thing.");
            commentTexts.Add("Once you define an abbreviation, use it.");
            commentTexts.Add("The convention in English is to capitalize only the first letters of proper nouns, which are the official names of people, places, objects, or events.");
            commentTexts.Add("This was a split infinitive: in formal writing, do not put any word between “to” and the verb it goes with, even though it is common in everyday speech.");
            commentTexts.Add("Do not put a comma before the conjunction because this is not two sentences. It is one subject with a compound predicate.");
            commentTexts.Add("In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            commentTexts.Add(" This is not clear. If you contact me via your Client Manager with an explanation of your meaning, I will be happy to review and correct your wording.");
            commentTexts.Add("Compound sentences require a comma before the conjunction.");
            commentTexts.Add("Redefine the abbreviation in the main text.Some readers will not read both the abstract and the main text.");
            commentTexts.Add("Compound adjectives that modify a noun are typically hyphenated, but not when the first word of the adjective is an adverb ending with “-ly.”");
            commentTexts.Add("Research cited in the document should be referred to in the past tense.");
            commentTexts.Add("If you introduce a list with “such as,” it is redundant to use “and so on” or “etc.” at the end. “Such as” already means that the list is only a partial sampling of the items.");
            commentTexts.Add("In scientific and technical writing, the prevailing style is to write out numbers less than ten. Although the main concern should be expressing numbers consistently.");
        }

        public int GetNumStrings()
        {
            return 48;
        }

        public List<string> GetCommentStrings()
        {
            return commentTexts;
        }

    }
}
