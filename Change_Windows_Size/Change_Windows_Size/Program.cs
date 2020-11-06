using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Windows_Size
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();

            form.Width = 400;
            form.MouseDown += new MouseEventHandler(form_MouseDown);

            Application.Run(form);
        }

        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;

            if(e.Button == MouseButtons.Left)
            {
                // 최대, 최소화 버튼 
                form.MaximizeBox = true;
                form.MinimizeBox = true;
                //창 제목
                form.Text = "최대/최소화 버튼이 활성화 되었습니다.";
            }
            else if (e.Button == MouseButtons.Right)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Text = "최대/최소화 버튼이 비활성화 되었습니다.";
            }
        }
    }
}

/*
 * 윈도우 창 변경 후 클릭하여 창 크기 출력.
 *    static void Main(string[] args)
        {
            Program form = new Program();
            form.Width = 300;
            form.Height = 200;

            form.MouseDown += new MouseEventHandler(form_MouseDown);

            Application.Run(form);
        }

        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if(e.Button == MouseButtons.Left)
            {
                if(oldWidth<oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            Console.WriteLine("윈도우의 크기가 변경 되었습니다.");
            Console.WriteLine("Width: {0}, Height: {1}", form.Width, form.Height);
        }
*/