using StudyEnglish.Src.Class;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace StudyEnglish
{
    public partial class ViewWord : Form
    {
        private Home home;
        private In_Output io = new In_Output();

        List<Lessons> lessons = new List<Lessons>();

        public Home Home { get => home; set => home = value; }

        public ViewWord()
        {
            InitializeComponent();
            LoadOption();
            //LoadData(lessons[1].LessonId);
        }



        private void LoadOption()
        {
            lessons = io.LoadLesson();
            lessons.Sort((x, y) =>
            {
                int xLs = int.Parse(x.LessonId.Substring(2));
                int yLs = int.Parse(y.LessonId.Substring(2));

                return xLs.CompareTo(yLs);
            });
            foreach (Lessons lesson in lessons)
            {
                lstLesson.Items.Add(lesson.LessonName);
            }
        }


        public void LoadData(string lesson)
        {
            using (SqlConnection sqlCnn = new SqlConnection(Value.sqlConn))
            {
                // Tạo và gán Sql Command ngay khi khởi tạo.
                string querry = "Use Word SELECT WordID, WordEn, WordType,WordPro, WordVi " +
                    "from Words as w join RelationWLs as r " +
                    "on w.WordId = r.Word " +
                    "where r.Lesson = '" + lesson + "'";

                // Mở kết nối
                sqlCnn.Open();

                using (SqlDataAdapter sqlAD = new SqlDataAdapter(querry, sqlCnn))
                {
                    DataTable dt = new DataTable();
                    sqlAD.Fill(dt);
                    dgvWord.DataSource = dt;
                }
            }
        }

        private void LstLesson_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string choose = lstLesson.SelectedItem.ToString();
            LoadData(lessons.Find(x => x.LessonName == choose).LessonId);
        }

        private void ViewWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            //home.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string text = txtSearch.Text.ToString().Trim();
            if (text == "")
            {
                MessageBox.Show("Empty");
                DataTable dt = new DataTable();
                dgvWord.DataSource = dt;
                return;
            }

            using (SqlConnection sqlCnn = new SqlConnection(Value.sqlConn))
            {
                sqlCnn.Open();
                string querry = "Select LessonName, WordEn, WordType, WordPro, WordVi " +
                    "from Words as w join RelationWLs as r " +
                    "on w.WordId = r.Word " +
                    "join Lessons as l " +
                    "on r.Lesson = l.LessonID " +
                    "where WordEn like N'" + text + "%'";

                using (SqlDataAdapter sqlAD = new SqlDataAdapter(querry, sqlCnn))
                {
                    DataTable dt = new DataTable();
                    sqlAD.Fill(dt);
                    dgvWord.DataSource = dt;
                }
            }

        }
    }
}
