using StudyEnglish.Src.Class;
using System.Windows.Forms;

namespace StudyEnglish
{
    public partial class AddLesson : Form
    {
        public AddLesson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            In_Output io = new In_Output();
            string lessonName = txtNameLs.Text.ToString().Trim();
            if (lessonName == "")
            {
                lbNotify.Text = "Please enter lesson name";
                return;
            }
            bool kt = io.saveLesson(lessonName);
            if (kt)
            {
                lbNotify.Text = "Save success";
            }
            else
            {
                lbNotify.Text = "Save fail";
            }
        }
    }
}
