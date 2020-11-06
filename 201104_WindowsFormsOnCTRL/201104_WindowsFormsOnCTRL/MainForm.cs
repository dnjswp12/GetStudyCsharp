using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201104_WindowsFormsOnCTRL
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 운영체제에 있는 폰트 목록 검색
            foreach (FontFamily font in Fonts)
                comboBox1.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (comboBox1.SelectedIndex < 0)
            {
                return;
            }

            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                style |= FontStyle.Italic;
            }

            txtsimpleText.Font = new Font((string)comboBox1.SelectedItem, 10, style);
        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void progress_Increase(object sender, EventArgs e)
        {
            try
            {
                pgDummy.Value++;
            }
            catch
            {
                pgDummy.Value = 0;
            }

        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Gray;
            // showdialog --> 새로운 창 생기면 다른 UI 접근 안됨
            frm.ShowDialog();
        }

        private void Modaless_Click(object sender, EventArgs e)
        {
            // 버튼을 누를 때 마다 창이 계속 생김
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            // show --> 새로운 창이 생겨도 다른 UI에 접근 가능
            frm.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            // 위에 텍스트 박스에 있는 글자를 가져옴
            MessageBox.Show(txtsimpleText.Text, "Msg Box Test",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}


