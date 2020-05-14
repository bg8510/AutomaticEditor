namespace AutomaticEditor
{
    partial class CommonPhrases
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button CommentsToggle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonPhrases));
            this.AbbreviationsCB = new System.Windows.Forms.ComboBox();
            this.AbbreviationsLabel = new System.Windows.Forms.Label();
            this.AdjectivesLabel = new System.Windows.Forms.Label();
            this.AdjectivesCB = new System.Windows.Forms.ComboBox();
            this.ArticlesLabel = new System.Windows.Forms.Label();
            this.ArticlesCB = new System.Windows.Forms.ComboBox();
            this.BetterWordsLabel = new System.Windows.Forms.Label();
            this.BetterWordsCB = new System.Windows.Forms.ComboBox();
            this.CaptionsLabel = new System.Windows.Forms.Label();
            this.CaptionsCB = new System.Windows.Forms.ComboBox();
            this.ContractionsLabel = new System.Windows.Forms.Label();
            this.ContractionsCB = new System.Windows.Forms.ComboBox();
            this.FormalityLabel = new System.Windows.Forms.Label();
            this.FormalityCB = new System.Windows.Forms.ComboBox();
            this.RepeatableCommentsLabel = new System.Windows.Forms.Label();
            this.RepeatableCommentsCB = new System.Windows.Forms.ComboBox();
            this.SentencesLabel = new System.Windows.Forms.Label();
            this.SentencesCB = new System.Windows.Forms.ComboBox();
            this.WordinessLabel = new System.Windows.Forms.Label();
            this.WordinessCB = new System.Windows.Forms.ComboBox();
            this.ΩLabel = new System.Windows.Forms.Label();
            this.ΩCB = new System.Windows.Forms.ComboBox();
            CommentsToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommentsToggle
            // 
            CommentsToggle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            CommentsToggle.BackColor = System.Drawing.Color.MistyRose;
            CommentsToggle.Enabled = false;
            CommentsToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CommentsToggle.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CommentsToggle.ForeColor = System.Drawing.Color.DarkGreen;
            CommentsToggle.Location = new System.Drawing.Point(166, 719);
            CommentsToggle.Name = "CommentsToggle";
            CommentsToggle.Size = new System.Drawing.Size(184, 66);
            CommentsToggle.TabIndex = 2;
            CommentsToggle.Text = "Toggle to LFTE Comments";
            CommentsToggle.UseVisualStyleBackColor = false;
            CommentsToggle.Click += new System.EventHandler(this.CommentsToggleButton_Click);
            // 
            // AbbreviationsCB
            // 
            this.AbbreviationsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbbreviationsCB.FormattingEnabled = true;
            this.AbbreviationsCB.Items.AddRange(new object[] {
            "You do not need to define an abbreviation that you never use.",
            "You do not need to define an abbreviation in the abstract that you never use in t" +
                "he abstract.",
            "Once you define an abbreviation, use it.",
            "Define an abbreviation the first time you use it. Please make sure this is the co" +
                "rrect definition.",
            "Redefine the abbreviation in the main text. Some readers will not read both the a" +
                "bstract and the main text.",
            "When using an abbreviation, the last word that the abbreviation stands for should" +
                " not be repeated after it.",
            resources.GetString("AbbreviationsCB.Items"),
            "“al” is an abbreviation and requires a period."});
            this.AbbreviationsCB.Location = new System.Drawing.Point(7, 40);
            this.AbbreviationsCB.Name = "AbbreviationsCB";
            this.AbbreviationsCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AbbreviationsCB.Size = new System.Drawing.Size(500, 24);
            this.AbbreviationsCB.TabIndex = 3;
            this.AbbreviationsCB.SelectedIndexChanged += new System.EventHandler(this.AbbreviationsCB_Pick);
            // 
            // AbbreviationsLabel
            // 
            this.AbbreviationsLabel.AutoSize = true;
            this.AbbreviationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbbreviationsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.AbbreviationsLabel.Location = new System.Drawing.Point(10, 16);
            this.AbbreviationsLabel.Name = "AbbreviationsLabel";
            this.AbbreviationsLabel.Size = new System.Drawing.Size(105, 20);
            this.AbbreviationsLabel.TabIndex = 4;
            this.AbbreviationsLabel.Text = "Abbreviations";
            // 
            // AdjectivesLabel
            // 
            this.AdjectivesLabel.AutoSize = true;
            this.AdjectivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjectivesLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.AdjectivesLabel.Location = new System.Drawing.Point(10, 76);
            this.AdjectivesLabel.Name = "AdjectivesLabel";
            this.AdjectivesLabel.Size = new System.Drawing.Size(81, 20);
            this.AdjectivesLabel.TabIndex = 6;
            this.AdjectivesLabel.Text = "Adjectives";
            // 
            // AdjectivesCB
            // 
            this.AdjectivesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjectivesCB.FormattingEnabled = true;
            this.AdjectivesCB.Items.AddRange(new object[] {
            "Hyphenate all the words in a compound adjective.",
            "Compound adjectives that modify a noun are typically hyphenated (But not when the" +
                " first word of the adjective is an adverb ending with “-ly.”)",
            "This word is acting as an adjective here, so it does not use a plural form.",
            "Adjectives have a certain correct order. While many native English speakers do no" +
                "t consciously know this order, it will just sound wrong if the order is not foll" +
                "owed."});
            this.AdjectivesCB.Location = new System.Drawing.Point(7, 100);
            this.AdjectivesCB.MaxDropDownItems = 4;
            this.AdjectivesCB.Name = "AdjectivesCB";
            this.AdjectivesCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdjectivesCB.Size = new System.Drawing.Size(500, 24);
            this.AdjectivesCB.TabIndex = 5;
            this.AdjectivesCB.SelectedIndexChanged += new System.EventHandler(this.AdjectivesCB_Pick);
            // 
            // ArticlesLabel
            // 
            this.ArticlesLabel.AutoSize = true;
            this.ArticlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.ArticlesLabel.Location = new System.Drawing.Point(10, 136);
            this.ArticlesLabel.Name = "ArticlesLabel";
            this.ArticlesLabel.Size = new System.Drawing.Size(61, 20);
            this.ArticlesLabel.TabIndex = 8;
            this.ArticlesLabel.Text = "Articles";
            // 
            // ArticlesCB
            // 
            this.ArticlesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesCB.FormattingEnabled = true;
            this.ArticlesCB.Items.AddRange(new object[] {
            "Use the indefinite article “a” when referring to a single, nonspecific object tha" +
                "t begins with a consonant.",
            "Use the indefinite article “an” when referring to a single, nonspecific object if" +
                " the next word begins with a vowel sound.​",
            "The article “an” is used with nouns that begin with a vowel sound, irrespective o" +
                "f the letter they begin with.",
            "Use the definite article “the” when referring to a specific object that the reade" +
                "r can identify.",
            "The first time you reference something use an indefinite article, then use a defi" +
                "nite article when you repeat that object. (Because once it has been introduced, " +
                "it is then known to the reader.)",
            "Do not use an article with countries, states, counties or provinces, lakes or mou" +
                "ntains, except when the country is a collection of states such as “the” United K" +
                "ingdom.",
            "Use an article with bodies of water, oceans, and seas.",
            resources.GetString("ArticlesCB.Items"),
            "The definite article “the” is used before decades (e.g., the 1980s).",
            "Superlatives such as “highest” and “fastest” take the definite article “the” befo" +
                "re them.",
            "Ordinal adjectives such as “first,” “fifth,” and “last” are typically preceded by" +
                " the definite article “the.”",
            "In a series of nouns that take the same article, the article need not be repeated" +
                " before every noun.",
            "Do not use an article when you are speaking about meals, places, and transport.",
            "Use the plural form to refer to a category of thing, as opposed to an instance of" +
                " the thing.",
            "Do not use “the” or “a” when referring to a category of thing rather than to a sp" +
                "ecific instance of the thing.",
            "Articles such as “a,” “an,” and “the” are generally not required in titles, headi" +
                "ngs, or captions.",
            "Do not start a caption with an article (“a,” “an,” or “the”)."});
            this.ArticlesCB.Location = new System.Drawing.Point(7, 160);
            this.ArticlesCB.MaxDropDownItems = 17;
            this.ArticlesCB.Name = "ArticlesCB";
            this.ArticlesCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ArticlesCB.Size = new System.Drawing.Size(500, 24);
            this.ArticlesCB.TabIndex = 7;
            this.ArticlesCB.SelectedIndexChanged += new System.EventHandler(this.ArticlesCB_Pick);
            // 
            // BetterWordsLabel
            // 
            this.BetterWordsLabel.AutoSize = true;
            this.BetterWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetterWordsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.BetterWordsLabel.Location = new System.Drawing.Point(10, 196);
            this.BetterWordsLabel.Name = "BetterWordsLabel";
            this.BetterWordsLabel.Size = new System.Drawing.Size(103, 20);
            this.BetterWordsLabel.TabIndex = 10;
            this.BetterWordsLabel.Text = "Better Words";
            // 
            // BetterWordsCB
            // 
            this.BetterWordsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetterWordsCB.FormattingEnabled = true;
            this.BetterWordsCB.Items.AddRange(new object[] {
            "In an academic context, “paper” implies a formal written composition that is inte" +
                "nded to be published, presented, etc. The “study,” on the other hand, is the act" +
                "ual work carried out.",
            "In technical writing, the word “since” is reserved for time-related references. T" +
                "o indicate causality, replace “since” with synonyms such as “because.”",
            "The pronoun “which” is used to introduce nonessential or supplementary informatio" +
                "n, and the pronoun “that” is used to include essential information.",
            "“Use” is almost always a better word choice than “utilize.”",
            "“Using” is almost always a better word choice than “utilizing.”",
            "“indices” is the correct form and should be used in formal writing, although “ind" +
                "exes” is acceptable in other contexts.",
            "The plural form “researches” is an older form that is very rarely used. “Studies”" +
                " is better.",
            "“is able to” is an unnecessarily complicated way to say “can.”",
            "“was able to” is an unnecessarily complicated way to say “could.”",
            "\"by using\" means the same thing as \"using.\"",
            "Using \"employ\" to mean \"using\" can seem overly formal, or even pretentious."});
            this.BetterWordsCB.Location = new System.Drawing.Point(7, 220);
            this.BetterWordsCB.MaxDropDownItems = 11;
            this.BetterWordsCB.Name = "BetterWordsCB";
            this.BetterWordsCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BetterWordsCB.Size = new System.Drawing.Size(500, 24);
            this.BetterWordsCB.TabIndex = 9;
            this.BetterWordsCB.SelectedIndexChanged += new System.EventHandler(this.BetterWordsCB_Pick);
            // 
            // CaptionsLabel
            // 
            this.CaptionsLabel.AutoSize = true;
            this.CaptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.CaptionsLabel.Location = new System.Drawing.Point(10, 256);
            this.CaptionsLabel.Name = "CaptionsLabel";
            this.CaptionsLabel.Size = new System.Drawing.Size(72, 20);
            this.CaptionsLabel.TabIndex = 12;
            this.CaptionsLabel.Text = "Captions";
            // 
            // CaptionsCB
            // 
            this.CaptionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionsCB.FormattingEnabled = true;
            this.CaptionsCB.Items.AddRange(new object[] {
            "A period is typically not needed at the end of a title or heading.",
            "Avoid using numerals at the beginning of sentences, titles, or headings.",
            "Do not start a caption with a phrase like “Flowchart of…” or “Graph of…” Just sta" +
                "te what the image shows.",
            "Figures and tables should be referred to in the present tense."});
            this.CaptionsCB.Location = new System.Drawing.Point(7, 280);
            this.CaptionsCB.MaxDropDownItems = 4;
            this.CaptionsCB.Name = "CaptionsCB";
            this.CaptionsCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CaptionsCB.Size = new System.Drawing.Size(500, 24);
            this.CaptionsCB.TabIndex = 11;
            this.CaptionsCB.SelectedIndexChanged += new System.EventHandler(this.CaptionsCB_Pick);
            // 
            // ContractionsLabel
            // 
            this.ContractionsLabel.AutoSize = true;
            this.ContractionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractionsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.ContractionsLabel.Location = new System.Drawing.Point(10, 316);
            this.ContractionsLabel.Name = "ContractionsLabel";
            this.ContractionsLabel.Size = new System.Drawing.Size(99, 20);
            this.ContractionsLabel.TabIndex = 14;
            this.ContractionsLabel.Text = "Contractions";
            // 
            // ContractionsCB
            // 
            this.ContractionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractionsCB.FormattingEnabled = true;
            this.ContractionsCB.Items.AddRange(new object[] {
            "Avoid using contractions like “can’t” in academic writing.",
            "Avoid using contractions like “didn’t” in academic writing.",
            "Avoid using contractions like “doesn’t” in academic writing.",
            "Avoid using contractions like “don’t” in academic writing.",
            "Avoid using contractions like “I’d” in academic writing.",
            "Avoid using contractions like “won’t” in academic writing."});
            this.ContractionsCB.Location = new System.Drawing.Point(7, 340);
            this.ContractionsCB.MaxDropDownItems = 6;
            this.ContractionsCB.Name = "ContractionsCB";
            this.ContractionsCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContractionsCB.Size = new System.Drawing.Size(500, 24);
            this.ContractionsCB.TabIndex = 13;
            this.ContractionsCB.SelectedIndexChanged += new System.EventHandler(this.ContractionsCB_Pick);
            // 
            // FormalityLabel
            // 
            this.FormalityLabel.AutoSize = true;
            this.FormalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormalityLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.FormalityLabel.Location = new System.Drawing.Point(10, 376);
            this.FormalityLabel.Name = "FormalityLabel";
            this.FormalityLabel.Size = new System.Drawing.Size(73, 20);
            this.FormalityLabel.TabIndex = 16;
            this.FormalityLabel.Text = "Formality";
            // 
            // FormalityCB
            // 
            this.FormalityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormalityCB.FormattingEnabled = true;
            this.FormalityCB.Items.AddRange(new object[] {
            "“a lot of” is too informal.",
            "“What\'s more” is too informal for academic writing.",
            "“Nowadays” is too informal for academic writing.",
            "“more and more” is too informal for academic writing.",
            "“Huge” is too informal for academic writing.",
            "In formal American English, periods and commas go inside the quotes, even if they" +
                " were not part of the thing being quoted.",
            "“and/or” should be avoided in formal writing.",
            "This is more formal wording."});
            this.FormalityCB.Location = new System.Drawing.Point(7, 401);
            this.FormalityCB.Name = "FormalityCB";
            this.FormalityCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormalityCB.Size = new System.Drawing.Size(500, 24);
            this.FormalityCB.TabIndex = 15;
            this.FormalityCB.SelectedIndexChanged += new System.EventHandler(this.FormalityCB_Pick);
            // 
            // RepeatableCommentsLabel
            // 
            this.RepeatableCommentsLabel.AutoSize = true;
            this.RepeatableCommentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatableCommentsLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.RepeatableCommentsLabel.Location = new System.Drawing.Point(10, 436);
            this.RepeatableCommentsLabel.Name = "RepeatableCommentsLabel";
            this.RepeatableCommentsLabel.Size = new System.Drawing.Size(173, 20);
            this.RepeatableCommentsLabel.TabIndex = 18;
            this.RepeatableCommentsLabel.Text = "Repeatable Comments";
            // 
            // RepeatableCommentsCB
            // 
            this.RepeatableCommentsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatableCommentsCB.FormattingEnabled = true;
            this.RepeatableCommentsCB.Items.AddRange(new object[] {
            "This is not clear. If you contact me via your Client Manager with an explanation " +
                "of your meaning, I will be happy to review and correct your wording.",
            "Please make sure I did not change your intended meaning.",
            "This is a better word here.",
            "This is a more natural wording.",
            "This is a simpler, clearer sentence structure.",
            "This was changed for consistency with other occurrences in your paper."});
            this.RepeatableCommentsCB.Location = new System.Drawing.Point(7, 460);
            this.RepeatableCommentsCB.MaxDropDownItems = 6;
            this.RepeatableCommentsCB.Name = "RepeatableCommentsCB";
            this.RepeatableCommentsCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RepeatableCommentsCB.Size = new System.Drawing.Size(500, 24);
            this.RepeatableCommentsCB.TabIndex = 17;
            this.RepeatableCommentsCB.SelectedIndexChanged += new System.EventHandler(this.RepeatableCommentsCB_Pick);
            // 
            // SentencesLabel
            // 
            this.SentencesLabel.AutoSize = true;
            this.SentencesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentencesLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.SentencesLabel.Location = new System.Drawing.Point(10, 496);
            this.SentencesLabel.Name = "SentencesLabel";
            this.SentencesLabel.Size = new System.Drawing.Size(86, 20);
            this.SentencesLabel.TabIndex = 20;
            this.SentencesLabel.Text = "Sentences";
            // 
            // SentencesCB
            // 
            this.SentencesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentencesCB.FormattingEnabled = true;
            this.SentencesCB.Items.AddRange(new object[] {
            "A comma should preferably be inserted after introductory words and phrases.",
            "Avoid using short coordinating conjunctions like “and” and “but” at the beginning" +
                " of a sentence.",
            "Avoid using short coordinating conjunctions like “and” and “so” at the beginning " +
                "of a sentence.",
            "Comma splice: Two complete sentences should not be joined with only a comma. Use " +
                "either a semicolon or a comma followed by a conjunction.",
            "Compound sentences require a comma before the conjunction.",
            "Do not put a comma before the conjunction because this is not two sentences. It i" +
                "s one subject with a compound predicate.",
            "Use a semicolon rather than a comma to join sentences with a conjunctive adverb.",
            "Only use a colon at the end of a complete sentence."});
            this.SentencesCB.Location = new System.Drawing.Point(7, 520);
            this.SentencesCB.Name = "SentencesCB";
            this.SentencesCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SentencesCB.Size = new System.Drawing.Size(500, 24);
            this.SentencesCB.TabIndex = 19;
            this.SentencesCB.SelectedIndexChanged += new System.EventHandler(this.SentencesCB_Pick);
            // 
            // WordinessLabel
            // 
            this.WordinessLabel.AutoSize = true;
            this.WordinessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordinessLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.WordinessLabel.Location = new System.Drawing.Point(10, 556);
            this.WordinessLabel.Name = "WordinessLabel";
            this.WordinessLabel.Size = new System.Drawing.Size(84, 20);
            this.WordinessLabel.TabIndex = 22;
            this.WordinessLabel.Text = "Wordiness";
            // 
            // WordinessCB
            // 
            this.WordinessCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordinessCB.FormattingEnabled = true;
            this.WordinessCB.Items.AddRange(new object[] {
            "Redundancy, that is, the unnecessary repetition of words or ideas, should be avoi" +
                "ded in academic writing.",
            "The use of too many words to convey one idea can muddle the message and divert th" +
                "e reader’s attention. Therefore, especially academic writing, ideas need to be c" +
                "onveyed as concisely as possible.",
            "Wordiness (the use of many words to convey an idea) should be avoided in academic" +
                " writing.",
            "To achieve conciseness, use the word “respectively” to link two or more groups of" +
                " words.",
            "Edited for redundancy/wordiness.",
            "This was deleted because it is repetitive."});
            this.WordinessCB.Location = new System.Drawing.Point(7, 580);
            this.WordinessCB.MaxDropDownItems = 6;
            this.WordinessCB.Name = "WordinessCB";
            this.WordinessCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WordinessCB.Size = new System.Drawing.Size(500, 24);
            this.WordinessCB.TabIndex = 21;
            this.WordinessCB.SelectedIndexChanged += new System.EventHandler(this.WordinessCB_Pick);
            // 
            // ΩLabel
            // 
            this.ΩLabel.AutoSize = true;
            this.ΩLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ΩLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.ΩLabel.Location = new System.Drawing.Point(10, 616);
            this.ΩLabel.Name = "ΩLabel";
            this.ΩLabel.Size = new System.Drawing.Size(21, 20);
            this.ΩLabel.TabIndex = 24;
            this.ΩLabel.Text = "Ω";
            // 
            // ΩCB
            // 
            this.ΩCB.CausesValidation = false;
            this.ΩCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ΩCB.FormattingEnabled = true;
            this.ΩCB.Items.AddRange(new object[] {
            "Words with opposite meanings (e.g., higher and lower) should be used in pairs and" +
                " should not be mixed with other pairs.",
            "As a general rule, verb tenses within a sentence or a paragraph should be consist" +
                "ent.",
            "Split infinitive: in formal writing, do not put any word between “to” and the ver" +
                "b it goes with, even though it is common in everyday speech.",
            "",
            "A singular subject should be accompanied by a singular verb, and plural subject s" +
                "hould be accompanied by a plural verb.",
            "Here, the subject is “ ___ ,” so a plural verb form should be used.",
            "Here, the subject is “ ___ ,” so a singular verb form should be used.",
            "",
            "When possible, the simplest and clearest sentence structure is in the order of su" +
                "bject-verb-object.",
            "",
            "Use commas around the “such as” clause when the items listed are non-restrictive," +
                " i.e., the sentence works with or without the list.",
            "Elements in a series are usually separated by commas but are separated by semicol" +
                "ons if the elements themselves contain commas.",
            "In academic writing, insert a comma before the conjunction that precedes the last" +
                " element of a series of more than two items (e.g., bread, eggs, and milk).",
            "For clarity, the words or phrases in a list should be parallel in form.",
            "If you introduce a list with “such as,” it is redundant to use “and so on” or “et" +
                "c.” at the end. “Such as” already means that the list is only a partial sampling" +
                " of the items.",
            "",
            "“i.e.” requires a comma; it is the same as saying “for example,” and then listing" +
                " items.",
            "The phrase “et al.” is accompanied by a plural verb, because it refers to multipl" +
                "e people.",
            "",
            "A “-tion” ending indicates a verb form that has been converted to a noun form. Of" +
                "ten using the verb form is simpler.",
            "",
            "The convention in English is to capitalize only the first letters of proper nouns" +
                ", which are the official names of people, places, objects, or events, even if th" +
                "ey are part of a technical term.",
            "",
            "Research cited in the document should be referred to in the past tense.",
            "The past tense is commonly used in academic writing when describing the methods a" +
                "nd steps used in an experiment that has already been conducted.",
            "",
            "For ranges, use an “en dash” with spaces around it. (In Word, an en dash is Ctrl " +
                "+ -)",
            "",
            "Only use “respectively” if you have two lists of items that line up with each oth" +
                "er in the order they were listed.",
            "",
            "The preposition “in” is used when describing a change, such as an increase or dec" +
                "rease, whereas “of” is used for the magnitude of the change.",
            "In scientific and technical writing, the prevailing style is to write out the num" +
                "bers zero to ten. Although the main concern should be expressing numbers consist" +
                "ently.",
            "",
            "This is the British spelling.",
            "This is the American spelling."});
            this.ΩCB.Location = new System.Drawing.Point(7, 640);
            this.ΩCB.MaxDropDownItems = 35;
            this.ΩCB.Name = "ΩCB";
            this.ΩCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ΩCB.Size = new System.Drawing.Size(500, 24);
            this.ΩCB.TabIndex = 23;
            this.ΩCB.SelectedIndexChanged += new System.EventHandler(this.ΩCB_Pick);
            // 
            // CommonPhrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.ΩLabel);
            this.Controls.Add(this.ΩCB);
            this.Controls.Add(this.WordinessLabel);
            this.Controls.Add(this.WordinessCB);
            this.Controls.Add(this.SentencesLabel);
            this.Controls.Add(this.SentencesCB);
            this.Controls.Add(this.RepeatableCommentsLabel);
            this.Controls.Add(this.RepeatableCommentsCB);
            this.Controls.Add(this.FormalityLabel);
            this.Controls.Add(this.FormalityCB);
            this.Controls.Add(this.ContractionsLabel);
            this.Controls.Add(this.ContractionsCB);
            this.Controls.Add(this.CaptionsLabel);
            this.Controls.Add(this.CaptionsCB);
            this.Controls.Add(this.BetterWordsLabel);
            this.Controls.Add(this.BetterWordsCB);
            this.Controls.Add(this.ArticlesLabel);
            this.Controls.Add(this.ArticlesCB);
            this.Controls.Add(this.AdjectivesLabel);
            this.Controls.Add(this.AdjectivesCB);
            this.Controls.Add(this.AbbreviationsLabel);
            this.Controls.Add(this.AbbreviationsCB);
            this.Controls.Add(CommentsToggle);
            this.MinimumSize = new System.Drawing.Size(0, 520);
            this.Name = "CommonPhrases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(514, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox AbbreviationsCB;
        private System.Windows.Forms.Label AbbreviationsLabel;
        private System.Windows.Forms.Label AdjectivesLabel;
        private System.Windows.Forms.ComboBox AdjectivesCB;
        private System.Windows.Forms.Label ArticlesLabel;
        private System.Windows.Forms.ComboBox ArticlesCB;
        private System.Windows.Forms.Label BetterWordsLabel;
        private System.Windows.Forms.ComboBox BetterWordsCB;
        private System.Windows.Forms.Label CaptionsLabel;
        private System.Windows.Forms.ComboBox CaptionsCB;
        private System.Windows.Forms.Label ContractionsLabel;
        private System.Windows.Forms.ComboBox ContractionsCB;
        private System.Windows.Forms.Label FormalityLabel;
        private System.Windows.Forms.ComboBox FormalityCB;
        private System.Windows.Forms.Label RepeatableCommentsLabel;
        private System.Windows.Forms.ComboBox RepeatableCommentsCB;
        private System.Windows.Forms.Label SentencesLabel;
        private System.Windows.Forms.ComboBox SentencesCB;
        private System.Windows.Forms.Label WordinessLabel;
        private System.Windows.Forms.ComboBox WordinessCB;
        private System.Windows.Forms.Label ΩLabel;
        private System.Windows.Forms.ComboBox ΩCB;
    }
}
