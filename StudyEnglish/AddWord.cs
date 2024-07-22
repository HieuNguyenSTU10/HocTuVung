using StudyEnglish.Src.Class;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudyEnglish
{
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        private string GetClipboardText()
        {
            // Kiểm tra xem clipboard có chứa dữ liệu văn bản không
            if (Clipboard.ContainsText())
            {
                // Trả về nội dung văn bản từ clipboard
                return Clipboard.GetText();
            }
            else
            {
                // Trả về chuỗi rỗng nếu clipboard không chứa dữ liệu văn bản
                return string.Empty;
            }
        }

        // Bắt sự kiện KeyDown của DataGridView
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem phím Ctrl và phím V (mã phím 86) có được nhấn cùng nhau không
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Lấy văn bản từ clipboard
                string clipboardText = Clipboard.GetText();

                // Phân tách văn bản từ clipboard thành các dòng
                string[] lines = clipboardText.Split('\n');

                // Lặp qua từng dòng
                foreach (string line in lines)
                {
                    // Phân tách dữ liệu từng dòng thành các cột
                    string[] cells = line.Split('\t');

                    // Thêm các giá trị vào DataGridView
                    dgvWord.Rows.Add(cells);
                }
            }
        }

        private void btnAddWord_Click(object sender, System.EventArgs e)
        {

        }

        private void GetDataFromDataGridView()
        {
            List<Word> addWords = new List<Word>();

            foreach (DataGridViewRow row in dgvWord.Rows)
            {
                Word word = new Word();
                word.English = (row.Cells[0].Value.ToString() != null) ? row.Cells[0].Value.ToString() : "";
                word.Type = (row.Cells[1].Value.ToString() != null) ? row.Cells[1].Value.ToString() : "";
                word.Pronun = (row.Cells[2].Value.ToString() != null) ? row.Cells[2].Value.ToString() : "";
                word.Vietnamese = (row.Cells[3].Value.ToString() != null) ? row.Cells[3].Value.ToString() : "";
            }


        }
    }
}
