using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace versia1
{
    public partial class Primer : Form
    {

        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";
        public Primer()
        {
            InitializeComponent();
            combobox_raz();
        }

        string[] konspect;
        string razdel;

        private void dla_case(string tema)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT konspekt_primera FROM prim WHERE name_temi = @tema";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        output_examples.NavigateToString("<html><head></head><body></body></html>");

                        if (reader.Read() && reader["konspekt_primera"] != DBNull.Value)
                        {
                            string html_code = reader["konspekt_primera"].ToString();
                            output_examples.NavigateToString(html_code);
                        }
                        else
                        {
                            string message = "<html><head></head><body>Преподаватель ещё не внёс примеры.</body></html>";
                            output_examples.NavigateToString(message);
                        }
                    }
                }
            }
        }
        private void combobox_raz()
        {
            razd_spisok.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_razdel FROM razdel";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool has_sections = false;
                        int name_sections_index = reader.GetOrdinal("name_razdel");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_sections_index))
                            {
                                string value = reader.GetString(name_sections_index);

                                if (!razd_spisok.Items.Contains(value))
                                {
                                    razd_spisok.Items.Add(value);
                                    has_sections = true;
                                }
                            }
                        }

                        if (!has_sections)
                        {
                            razd_spisok.Text = "Разделов ещё нет";
                        }
                    }
                }
            }
        }

        private void combobox_lec(string sections_name)
        {
            list_examples.Text = "";
            list_examples.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_temi FROM prim WHERE name_razdel = @sections_name";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sections_name", sections_name);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        bool has_themes = false;

                        int name_temiIndex = reader.GetOrdinal("name_temi");

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(name_temiIndex))
                            {
                                string value = reader.GetString(name_temiIndex);

                                if (!list_examples.Items.Contains(value))
                                {
                                    list_examples.Items.Add(value);
                                    has_themes = true;
                                }
                            }
                        }

                        if (!has_themes)
                        {
                            list_examples.Text = "В данном разделе ещё нет тем.";
                        }

                    }
                }
            }
        }



        private void razd_spisok_SelectedIndexChanged(object sender, EventArgs e)
        {
            razdel = razd_spisok.Text;
            if (razdel == "")
            {
                MessageBox.Show("Вы не выбрали раздел!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            combobox_lec(razdel);
            output_examples.NavigateToString("<html><head></head><body></body></html>");
        }

        private void list_examples_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tema = list_examples.Text;
            switch (tema)
            {
                case string value when value == tema:
                    dla_case(tema);
                    break;

                default:
                    MessageBox.Show("Вы не выбрали тему!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

        private async void Primer_Load(object sender, EventArgs e)
        {
            try
            {
                await upload_webview2(output_examples);
            }
            catch (COMException ex) when (ex.HResult == unchecked((int)0x80004004))
            {
            }
            catch (Exception ex)
            {
            }
        }

        private async Task upload_webview2(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            if (webView != null)  
            {
                try
                {
                    await webView.EnsureCoreWebView2Async();
                    webView.NavigateToString("<html><head></head><body></body></html>");
                }
                catch (COMException ex) when (ex.HResult == unchecked((int)0x80004004))
                {
                    
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primer.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void назадНаНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primer.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

    }
}
