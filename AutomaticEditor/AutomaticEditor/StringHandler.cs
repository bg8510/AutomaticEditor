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
            commentTexts = new List<string>();

            commentTexts.Add(" --------------------------------------------------------");
            commentTexts.Add(" Please make sure I did not change your intended meaning.");
            commentTexts.Add(" This is not clear." + Environment.NewLine + Environment.NewLine + "If you contact me via your Client Manager with an explanation of your meaning, I will be happy to review and correct your wording.");
            commentTexts.Add(" This is a more natural wording.");
            commentTexts.Add(" This is a better word here.");
            commentTexts.Add(" This was changed for consistency.");
            commentTexts.Add(" This is a simpler, clearer sentence structure.");
            commentTexts.Add(" ");
            commentTexts.Add("     MOST COMMON -------------------------");
            commentTexts.Add("Wordiness (the use of many words to convey an idea) should be avoided in academic writing.");
            commentTexts.Add("Compound sentences require a comma before the conjunction.");
            commentTexts.Add("Do not put a comma before the conjunction because this is not two sentences. It is one subject with a compound predicate.");
            commentTexts.Add("The pronoun “which” is used to introduce nonessential or supplementary information, and the pronoun “that” is used to include essential information.");
            commentTexts.Add("In academic writing, insert a comma before the conjunction that precedes the last element of a series of more than two items (e.g., bread, eggs, and milk).");
            commentTexts.Add("Compound adjectives that modify a noun are typically hyphenated (But not when the first word of the adjective is an adverb ending with “-ly.”)");
            commentTexts.Add("Hyphenate all the words in a compound adjective.");
            commentTexts.Add("For clarity, the words or phrases in a list should be parallel in form.");
            commentTexts.Add("A period is typically not used at the end of a title or heading.");
            commentTexts.Add("In an academic context, “paper” implies a formal written composition that is intended to be published, presented, etc. The “study,” on the other hand, is the actual work carried out.");
            commentTexts.Add("“Use” is almost always a better word choice than “utilize.”");
            commentTexts.Add("The convention in English is to capitalize only the first letters of proper nouns, which are the official names of people, places, objects, or events, even if they are part of a technical term.");   
            commentTexts.Add("In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            commentTexts.Add("Research cited in the document should be referred to in the past tense.");
            commentTexts.Add("The past tense is commonly used in academic writing when describing the methods and steps used in an experiment that has already been conducted.");            
            commentTexts.Add("The word “since” can have a time-related meaning or can indicating causality. To avoid confusion, replace “since” with synonyms such as “because.”");
            commentTexts.Add("Use the plural form to refer to a category of thing, as opposed to an instance of the thing.");
            commentTexts.Add("Do not start a caption with a phrase like “Flowchart of…” or “Graph of…” Just state what the image shows.");
            commentTexts.Add("Use an “en dash,” with spaces, for ranges. (In Word, an en dash is Ctrl + -)");
            commentTexts.Add("Do not start a caption with an article, “a,” “an,” or “the.”");
            commentTexts.Add("This word is acting as an adjective here, so it does not get the plural form.");
            commentTexts.Add(" ");
            commentTexts.Add("     WORDINESS, CONTRACTIONS -------------");
            commentTexts.Add("To achieve conciseness, use the word “respectively” to link two or more groups of words.");
            commentTexts.Add("When using an abbreviation, the last word that the abbreviation stands for should not be repeated after it.");
            commentTexts.Add("Redundancy, that is, the unnecessary repetition of words or ideas, should be avoided in academic writing.");
            commentTexts.Add("Avoid using contractions like I’d, don’t, and can’t in academic writing.");
            commentTexts.Add(" ");
            commentTexts.Add("     ABBREVIATIONS, --------------------------------");
            commentTexts.Add("You do not need to define an abbreviation that you never use.");
            commentTexts.Add("You do not need to define an abbreviation in the abstract that you never use in the abstract.");
            commentTexts.Add("Once you define an abbreviation, use it.");
            commentTexts.Add("Define an abbreviation the first time you use it. Please make sure this is the correct definition.");
            commentTexts.Add("Redefine the abbreviation in the main text. Some readers will not read both the abstract and the main text.");
            commentTexts.Add(" ");
            commentTexts.Add("     COMPOUND SENTENCE STUFF ----------------------------");
            commentTexts.Add("Comma splice: Two complete sentences should not be joined with only a comma. Use either a semicolon or a comma followed by a conjunction.");
            commentTexts.Add("Use a semicolon rather than a comma to join sentences with a conjunctive adverb.");
            commentTexts.Add(" ");
            commentTexts.Add("     SENTENCES ------------------------------------------");
            commentTexts.Add("Avoid using short coordinating conjunctions like “and” and “but” at the beginning of sentences.");
            commentTexts.Add("A comma should preferably be inserted after introductory words and phrases.");
            commentTexts.Add("A singular subject should be accompanied by a singular verb, and plural subject should be accompanied by a plural verb.");
            commentTexts.Add("Words with opposite meanings (e.g., higher and lower) should be used in pairs and should not be mixed with other pairs.");
            commentTexts.Add("As a general rule, verb tenses within a sentence or a paragraph should be consistent.");
            commentTexts.Add("Split infinitive: in formal writing, do not put any word between “to” and the verb it goes with, even though it is common in everyday speech.");
            commentTexts.Add("If you introduce a list with “such as,” it is redundant to use “and so on” or “etc.” at the end. “Such as” already means that the list is only a partial sampling of the items.");
            commentTexts.Add("Here, the subject is “ ___ ,” so a plural verb form should be used.");
            commentTexts.Add("Here, the subject is “ ___ ,” so a singular verb form should be used.");
            commentTexts.Add("Elements in a series are usually separated by commas but are separated by semicolons if the elements themselves contain commas.");
            commentTexts.Add("Only use “respectively” if you have two lists of items that line up with each other in the order they were listed.");
            commentTexts.Add("Only use a colon at the end of a complete sentence.");
            commentTexts.Add("When possible, the simplest and clearest sentence structure is in the order of subject-verb-object.");
            commentTexts.Add("Use commas around the “such as” clause when the items listed are non - restrictive, i.e., the sentence works with or without the list.");
            commentTexts.Add("Avoid using numerals at the beginning of sentences, titles, or headings.");
            commentTexts.Add(" ");
            commentTexts.Add("Figures and tables should be referred to in the present tense.");
            commentTexts.Add("The phrase “et al.” is accompanied by a plural verb."); 
            commentTexts.Add("The preposition “in” is used when describing a change, such as an increase or decrease, whereas “of” is used for the magnitude of the change.");
            commentTexts.Add("In scientific and technical writing, the prevailing style is to write out numbers less than ten. Although the main concern should be expressing numbers consistently.");
            commentTexts.Add("“a lot of” is too informal.");
            commentTexts.Add("This is the British spelling.");
            commentTexts.Add("This is the American spelling.");
            commentTexts.Add("This word is acting as an adjective here, so it does not use a plural form.");
            commentTexts.Add("“and/or” should be avoided in formal writing.");
            commentTexts.Add(" ");
        }

        public List<string> GetCommentStrings()
        {
            return commentTexts;
        }

    }
}
