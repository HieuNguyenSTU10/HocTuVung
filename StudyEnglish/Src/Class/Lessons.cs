namespace StudyEnglish.Src.Class
{
    internal class Lessons
    {
        string lessonId;
        string lessonName;

        public Lessons()
        {
        }
        public Lessons(string lessonId, string lessonName)
        {
            this.LessonId = lessonId;
            this.LessonName = lessonName;
        }

        public string LessonId { get => lessonId; set => lessonId = value; }
        public string LessonName { get => lessonName; set => lessonName = value; }
    }
}
