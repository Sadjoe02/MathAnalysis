using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace versia1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            //string mysqlStartPath = Path.Combine(directoryPath, @"..\..\MySQL\MySQL_start.exe");
            //string processName = "mysqld";
            //if (!IsProcessRunning(processName))
            //{
            //    if (File.Exists(mysqlStartPath))
            //    {
            //        Process.Start(mysqlStartPath);
            //    }
            //    else
            //    {
            //        MessageBox.Show("MySQL_start.exe не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else { }
            Application.Run(new Vxod());
        }
        //static bool IsProcessRunning(string processName)
        //{
        //    Process[] processes = Process.GetProcessesByName(processName);
        //    return processes.Length > 0;
        //}
    }
}
