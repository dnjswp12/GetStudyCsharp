using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTextBox1
{
    /*
     * Form1.cs랑 Form1.Designer.cs는 같은 클래스 인데 2개의 cs파일로 나눠버린것임.
     * '나누어 떨어진 것' --> public partial class라고 사용. 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox의 초기값 할당
            textBox1.Text = "서울시 도봉구 창3동";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 홍길동");
            sb.AppendLine("나이 : 28");
            sb.AppendLine("국적 : 한국");

            textBox2.Text = sb.ToString();

            textBox3.MaxLength = 10;
            textBox4.ReadOnly = true;
            textBox5.PasswordChar = '*';

            textBox3.Text = "서울시 도봉구 창3동";
            textBox4.Text = "서울시 도봉구 창3동";
            textBox5.Text = "서울시 도봉구 창3동";

        }
    }
}
