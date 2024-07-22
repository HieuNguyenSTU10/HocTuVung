using StudyEnglish.Src.Class;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace StudyEnglish
{
    public partial class TestWord : Form
    {
        Home home;


        In_Output io = new In_Output();

        string testType = "Vi";
        Random rd = new Random();
        List<int> no_randoms = new List<int>();
        List<Word> words = new List<Word>();
        List<Lessons> lessons = new List<Lessons>();

        //valiable for test
        int sum = 0;
        int remain = 0;
        int correct = 0;
        int incorrect = 0;
        int valuerd = -1;

        public Home Home { get => home; set => home = value; }

        public TestWord()
        {
            InitializeComponent();
            loadLesson();

        }

        // check the Vi test type 
        private void rbVi_CheckedChanged(object sender, System.EventArgs e)
        {
            lbProQues.Visible = false;
            testType = "Vi";
        }

        // check the En test type
        private void rbEn_CheckedChanged(object sender, System.EventArgs e)
        {
            lbProQues.Visible = false;
            testType = "En";
        }

        // Show lesson 
        private void loadLesson()
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
                cblLesson.Items.Add(lesson.LessonName);
            }

        }

        //Load words
        private void LoadWords()
        {
            words.Clear();
            List<string> lsLesson = new List<string>();
            for (int i = 0; i < cblLesson.Items.Count; i++)
            {
                if (cblLesson.GetItemChecked(i))
                {
                    lsLesson.Add("ls" + (i));
                }
            }
            words = io.loadListWord(lsLesson);

        }

        //Check the test
        private void CheckTest()
        {
            bool check = false;
            int len = words.Count;

            // check the answer
            if (testType == "Vi")
            {
                if (words[valuerd].Vietnamese.ToLower().Contains(tbAnswer.Text.ToString().ToLower()) && tbAnswer.Text.Trim() != "")
                {
                    check = true;
                }
            }
            else
            {
                if (words[valuerd].English.ToLower().Contains(tbAnswer.Text.ToString().ToLower()) && tbAnswer.Text.Trim() != "")
                {
                    check = true;
                }
            }

            // Process the result
            if (tbQuestion.Text != "" && valuerd <= len)
            {
                if (check)
                {
                    correct++;
                    remain--;
                    lbCorrect.Text = correct.ToString();
                    lbRemain.Text = remain.ToString();
                    lbNotify.Visible = true;
                    lbNotify.Text = "Correct";
                    lbNotify.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    incorrect++;
                    remain--;
                    LbIncorrect.Text = incorrect.ToString();
                    lbCorrect.Visible = true;
                    lbRemain.Text = remain.ToString();
                    lbNotify.Visible = true;
                    lbNotify.Text = "Incorrect";
                    lbNotify.ForeColor = System.Drawing.Color.Red;
                }

            }
            tbAnswer.Text = "";
            if (valuerd != -1) SetWord();
            showWord();


        }

        private void tbAnswer_Enter(object sender, KeyEventArgs e)
        {


            if (cblLesson.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose the lesson");
            }
            else
            {
                LoadWords();
                if (lbSum.Text == "0" || sum < words.Count || sum > words.Count)
                { Reset(); }

                if (words.Count > 0 && (tbQuestion.Text == "" || valuerd >= words.Count) || no_randoms.Count == 0)
                {
                    showWord();
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        CheckTest();
                    }
                }
            }


        }

        private void playSound()
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.SpeakAsync(tbQuestion.Text);
        }

        private void SetWord()
        {
            lbWord.Text = words[valuerd].English;
            lbType.Text = words[valuerd].Type;
            lbProView.Text = words[valuerd].Pronun;
            lbVi.Text = words[valuerd].Vietnamese;
        }

        private void showWord()
        {

            int len = words.Count;

            if (len == 0)
            {
                // Xử lý khi không có từ nào trong danh sách
                MessageBox.Show("Không có từ nào trong danh sách.");
                return;
            }

            // Kiểm tra nếu tất cả các từ đã được hiển thị
            if (no_randoms.Count == len)
            {
                MessageBox.Show("Bạn đã hoàn thành\n" +
                    "Số câu đúng là: " + correct + "\n" +
                    "Số câu sai là: " + incorrect);
                Reset();
                return;
            }

            // Chọn một chỉ mục ngẫu nhiên nếu danh sách chưa hiển thị tất cả các từ
            do
            {
                valuerd = rd.Next(len);
            } while (no_randoms.Contains(valuerd));

            // Hiển thị từ tại chỉ mục được chọn ngẫu nhiên
            if (testType == "Vi")
            {
                tbQuestion.Text = words[valuerd].English;
                lbProQues.Visible = true;
                lbProQues.Text = words[valuerd].Pronun;
                playSound();
            }
            else
            {
                tbQuestion.Text = words[valuerd].Vietnamese;
            }

            no_randoms.Add(valuerd);
        }

        private void Reset()
        {
            sum = words.Count;
            lbSum.Text = sum.ToString();
            no_randoms.Clear();
            correct = 0;
            lbCorrect.Text = correct.ToString();
            incorrect = 0;
            LbIncorrect.Text = incorrect.ToString();
            remain = sum;
            lbRemain.Text = remain.ToString();
            tbQuestion.Text = "";
            lbProQues.Text = "";
            lbWord.Text = "";
            lbProView.Text = "";
            lbVi.Text = "";
            lbType.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ViewWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
            {
                for (int i = 0; i < cblLesson.Items.Count; i++)
                {
                    cblLesson.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < cblLesson.Items.Count; i++)
                {
                    cblLesson.SetItemChecked(i, false);
                }
            }
        }

        private void checkState()
        {
            bool kt = true;
            for (int i = 0; i < cblLesson.Items.Count; i++)
            {
                if (!cblLesson.GetItemChecked(i))
                {
                    kt = false;
                }
            }

            if (kt)
            {
                cbAll.Checked = true;
            }
            else
            {
                cbAll.Checked = false;
            }
        }

        private void cblLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkState();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            playSound();
        }

        private void cblLesson_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Reset();
        }
    }
}
