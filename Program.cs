using SeaStory.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //�������� ���ÿ� �� ������ �ƴ�
            //�� ���� �� �����������ϸ� �������� �����ϰ� ��
            //ex)������ �� �̵����� �θ� ���� ����� �ڽ����� ������� ���(�α���->�ڸ�����)
            //(new login()).Show();
            Application.Run(new login());
        }
    }
}
