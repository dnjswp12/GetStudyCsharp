using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * 사용자가 Form의 인스턴스 (윈도우)에서 마우스 버튼을 누르면 좌표와 
 * 버튼을 눌렀을 때 이벤트를 발생하게끔 함. 
 * 
 */

namespace _201103_Form_Class
{
    class Program : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Sender : {0}", ((Form)sender).Text);
            Console.WriteLine("X: {0}, Y: {1}", e.X, e.Y);
            Console.WriteLine("Button : {0}, Clicks : {1}", e.Button, e.Clicks);

            Console.WriteLine();
        }

        public Program(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new Program("Mouse Event Test"));
        }
    }
}
