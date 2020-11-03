using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click += new EventHandler((sender, EventArgs) =>
            {
                Console.WriteLine("Closing Windows...");
                Application.Exit();
            });

            Console.WriteLine("Start Window Application ...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application");
        }
    }


}
/*
 *         /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MainApp());
        }
 */
/*
 *  class MyForm : System.Windows.Forms.Form
    {

    }
    class MainApp : System.Windows.Forms.Form
    {
        static void Main (string[] args)
        {
            MyForm form = new MyForm();
            // 폼(윈도우)를 마우스 클릭하면 발생하는 이벤트
            form.Click += new EventHandler((sender, EventArgs) =>
            {
                Application.Exit();
                // 응용 프로그램이 바로 종료 되지않는다. 
                // 응용 프로그램이 갖고 있는 모든 윈도우를 닫고
                // Run() 메서드가 반환되도록 한다. 
                // 후에 자원을 정리하는 코드를 넣으면 안전하게 종료됨.
            });
            Application.Run(form);
        }
    }
         // application.Run() -> 응용 프로그램을 시작하는 메서드 
         // application.exit() -> 응용 프로그램을 종료하는 메서드
  */ 