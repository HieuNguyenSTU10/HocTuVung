namespace StudyEnglish.Src.Class
{
    internal class Word
    {
        string english, vietnamese, type, pronun;


        public string Vietnamese { get; set; }
        public string English { get; set; }
        public string Type { get; set; }

        public string Pronun { get; set; }

        public Word(string english, string vietnamese, string type, string pronun)
        {
            this.english = english;
            this.vietnamese = vietnamese;
            this.type = type;
            this.pronun = pronun;
        }

        public Word()
        {
        }
    }
}
