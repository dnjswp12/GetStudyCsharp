using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201104_WindowsFormsOnCTRL
{
    class Program : Form
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}

/*
 * 
        /*
         * 컨트롤은 버튼, 메뉴, 콤보 박스, 리스트 뷰 등을 말한다. 
         *
static void Main(string[] args)
{
    // 컨트롤의 인스턴스 생성, 모든 컨트롤은 system.windows.forms.control을 상속한다. 
    Button button = new Button();

    // 컨트롤 속성에 값 지정
    button.Text = "Click Me";
    button.Left = 100;
    button.Top = 50;

    // 컨트롤의 이벤트에 이벤트 처리기 등록
    button.Click += (object sender, EventArgs e) =>
    {
        MessageBox.Show("하위!");
    };

    Program form = new Program();
    form.Text = "Form & Control";
    form.Height = 150;

    form.Controls.Add(button);

    Application.Run(form);
}
*/
