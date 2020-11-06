using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201106_ComboBox_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(Object sender, EventArgs e)
        {
            string[] data = { "500k", "300k", "250k", "100k", "1M" };
            // 콤보 박스에 데이터를 초기화
            //comboBox1.Items.Add("500k");
            //comboBox1.Items.Add("300k");
            //comboBox1.Items.Add("250k");
            //comboBox1.Items.Add("100k");
            //comboBox1.Items.Add("1M");
            // 처음 선택값 지정. 
            //comboBox1.SelectedIndex = 0;
            comboBox1.Items.AddRange(data);
            comboBox1.SelectedIndex = 1;
        }
    }
}
