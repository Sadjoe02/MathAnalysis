using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices; 
using System.Diagnostics;

namespace versia1
{
    public partial class Solver : Form
    {
        public Solver()
        {
            InitializeComponent();
        }

        private async void Solver_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                string path_of_folder = Path.Combine(Application.StartupPath, "formula_editor");
                string full_path = Path.Combine(path_of_folder, "index_solver.html");
                string file_Uri = new Uri(full_path).AbsoluteUri;
                webView21.CoreWebView2.Navigate(file_Uri);
            }
            catch (COMException ex) when (ex.HResult == unchecked((int)0x80004004))
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void назадНаНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solver.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solver.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }
    }
}
