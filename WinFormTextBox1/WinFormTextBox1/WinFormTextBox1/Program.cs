using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Form1.Designer.cs --> 껍데기 (보여지는것)
 * Form1.cs --> 껍데기의 내용물에 대한 내용들
 */
namespace WinFormTextBox1
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
             * Form1 클래스를 객체로 생성한다. 
             * Application.Run()의 파라미터로 넣고 실행한다. 
             * 이 함수는 Form1이라는 window창의 객체를 화면에 보여주고 메시지를 만들어 마우스 등의 
             * 입력 수단을 통해  STAThread --> UI Thread에 전달하는 기능
             * 이말인즉슨, 기본적인 창을 출력하고 창에서 동작하는 마우스나 키보드의 동작을 모두 읽어와서 출력하도록 만들어주는 역할을 한다. 
             * 
             */
        }
    }
}
