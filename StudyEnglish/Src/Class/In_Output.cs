using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudyEnglish.Src.Class
{
    internal class In_Output
    {
        // take lesson from Sql
        public List<Lessons> LoadLesson()
        {
            List<Lessons> l = new List<Lessons>();

            // Giả sử "yourConnectionString" là chuỗi kết nối của bạn.
            using (SqlConnection sqlCnn = new SqlConnection(Value.sqlConn))
            {
                // Tạo và gán Sql Command ngay khi khởi tạo.
                SqlCommand sqlCMD = sqlCnn.CreateCommand();
                sqlCMD.CommandText = "SELECT LessonID,LessonName FROM Lessons";

                // Mở kết nối
                sqlCnn.Open();

                // Thực thi lệnh sqlCommand và đọc kết quả.
                using (SqlDataReader dr = sqlCMD.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Lessons lesson = new Lessons
                        {
                            LessonId = dr["LessonID"].ToString(),
                            LessonName = dr["LessonName"].ToString()
                        };
                        l.Add(lesson);
                    }
                }
            }

            // Return the list of lessons after closing the connection.
            return l;
        }

        public List<Word> loadListWord(List<string> Lesson)
        {
            List<Word> words = new List<Word>();

            string lsLesson = "'";

            foreach (string lesson in Lesson)
            {
                lsLesson += lesson + "','";
            }
            if (lsLesson != "'")
            {
                lsLesson = lsLesson.Remove(lsLesson.Length - 2);
            }
            else
            {
                return words;
            }


            using (SqlConnection sqlcnn = new SqlConnection(Value.sqlConn))
            {
                SqlCommand sqlCMD = sqlcnn.CreateCommand();
                sqlCMD.CommandText = "Use Word SELECT WordEn, WordType,WordPro, WordVi " +
                    "from Words as w join RelationWLs as r " +
                    "on w.WordId = r.Word " +
                    "where r.Lesson IN (" + lsLesson + ")";

                sqlcnn.Open();
                //MessageBox.Show(sqlCMD.CommandText);

                using (SqlDataReader dr = sqlCMD.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Word word = new Word();

                        word.English = dr["WordEn"].ToString();
                        word.Type = dr["WordType"].ToString();
                        word.Pronun = dr["WordPro"].ToString();
                        word.Vietnamese = dr["WordVi"].ToString();

                        words.Add(word);
                    }
                }
            }

            return words;
        }

        public bool saveLesson(string nameLesson)
        {
            string idLesson = "";

            using (SqlConnection sqlcnn = new SqlConnection(Value.sqlConn))
            {
                sqlcnn.Open();
                string querry = "select * from Lessons where LessonName = '" + nameLesson + "'";

                using (SqlCommand sqlCMD = new SqlCommand(querry, sqlcnn))
                {
                    if (sqlCMD.ExecuteScalar() != null)
                    {
                        return false;
                    }
                }


                querry = "select top 1 * from Lessons order by LessonId desc";

                using (SqlCommand sqlCMD = new SqlCommand(querry, sqlcnn))
                {
                    using (SqlDataReader dr = sqlCMD.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string lessonmax = dr["lessonid"].ToString();
                            int id = int.Parse(lessonmax.Substring(2));
                            idLesson = string.Concat("ls", id + 1);
                        }
                        else
                        {
                        }


                    }
                }
                querry = "insert into Lessons (LessonID ,LessonName) values ('" + idLesson + "' ,'" + nameLesson + "')";

                using (SqlCommand sqlCMD = new SqlCommand(querry, sqlcnn))
                {
                    if (sqlCMD.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
