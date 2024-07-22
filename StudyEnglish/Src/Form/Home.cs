using System.Windows.Forms;

namespace StudyEnglish
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Word_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            ViewWord viewWord = new ViewWord();
            viewWord.Home = this;
            viewWord.Show();
        }

        private void btn_Test_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            TestWord testWord = new TestWord();
            testWord.Home = this;
            testWord.Show();
        }
    }
}
