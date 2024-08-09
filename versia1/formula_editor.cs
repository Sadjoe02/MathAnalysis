using System;
using System.IO; 
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices; 
using System.Diagnostics;


namespace versia1
{
    public partial class formula_editor : Form
    {
        public formula_editor()
        {
            InitializeComponent();
        }
        public string Action_Type { get; set; }
        private async void formula_editor_Load(object sender, EventArgs e)
        {
            try
            {
                await editor.EnsureCoreWebView2Async(null);
                string path_of_folder = Path.Combine(Application.StartupPath, "formula_editor");
                string full_path = Path.Combine(path_of_folder, "index.html");
                string file_Uri = new Uri(full_path).AbsoluteUri;
                editor.CoreWebView2.Navigate(file_Uri);
                editor.CoreWebView2.WebMessageReceived += OnWebMessageReceived;
            }
            catch (COMException ex) when (ex.HResult == unchecked((int)0x80004004))
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void OnWebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (Action_Type == "difficult_test")
            {
                string message = e.TryGetWebMessageAsString();

                byte[] image_bytes = Convert.FromBase64String(message);
                string folder_path = Path.Combine(Application.StartupPath, "tasks_for_difficult_test");
                string file_path;

                if (!Directory.Exists(folder_path))
                {
                    Directory.CreateDirectory(folder_path);
                }

                int counter = 1;
                do
                {
                    file_path = Path.Combine(folder_path, $"task({counter}).png");
                    counter++;
                } while (File.Exists(file_path));
                bool checking_save = false;
                try
                {
                    File.WriteAllBytes(file_path, image_bytes);
                    checking_save = true;
                    MessageBox.Show($"Файл был успешно сохранен.", "Файл сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string message = e.TryGetWebMessageAsString();

                byte[] image_bytes = Convert.FromBase64String(message);
                string folder_path = Path.Combine(Application.StartupPath, "formulas");
                string file_path;

                if (!Directory.Exists(folder_path))
                {
                    Directory.CreateDirectory(folder_path);
                }

                int counter = 1;
                do
                {
                    file_path = Path.Combine(folder_path, $"equation({counter}).png");
                    counter++;
                } while (File.Exists(file_path));
                bool checking_save = false;
                try
                {
                    File.WriteAllBytes(file_path, image_bytes);
                    checking_save = true;
                    MessageBox.Show($"Файл был успешно сохранен.", "Файл сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
