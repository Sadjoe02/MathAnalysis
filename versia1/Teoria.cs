using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace versia1
{
    public partial class Teoria : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Teoria()
        {
            InitializeComponent();
            combobox_raz();
        }
        private async void Teoria_Load(object sender, EventArgs e)
        {
            try
            {
                await upload_webview2(conclusion_lecture);
                conclusion_lecture.NavigateToString("<html><head></head><body></body></html>");
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
        
        string razdel;

        bool prov;
        int id_user = Vxod.Id_user1;
        int id_temi;
        string[] konspect;
        DateTime start_temi;
        public bool proverka__zap(int id_user, int id_temi)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                bool proverka;
                string sql = "SELECT COUNT(*) FROM jyrnal_izychenia WHERE id_users = @id_user AND id_temi = @id_temi";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    cmd.Parameters.AddWithValue("@id_temi", id_temi);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        proverka = true;
                    else
                        proverka = false;
                    return proverka;
                }
            }
        }

        #region Запись в журнал изучения
        private int poisk_id_konsp(string name)
        {
            int idKonsp = 0;

            string zapros = $"SELECT id_temi FROM temi WHERE name_temi = '{name}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(zapros, connection);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    idKonsp = Convert.ToInt32(result);
                }
            }
            return idKonsp;
        }

        private string[] poisk_konsp(string tem)
        {

            string[] konspect_m = null;

            string zapros = "SELECT konspect FROM konsp WHERE name_temi = @tem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(zapros, connection))
                {
                    command.Parameters.AddWithValue("@tem", tem);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> konspect_l = new List<string>();

                        while (reader.Read())
                        {
                            string konspect = reader.IsDBNull(reader.GetOrdinal("konspect")) ? "Преподаватель ещё не ввёл содержимое." : reader.GetString("konspect");
                            konspect_l.Add(konspect);
                        }
                        konspect_m = konspect_l.ToArray();
                    }
                }
            }
            return konspect_m;
        }



        private void dobav_v_jyr(int id_temi, int id_users, DateTime start_temi, bool proverka)
        {

            if (proverka == true)
            {
                return;
            }

            string query = "INSERT INTO jyrnal_izychenia (id_temi, data_nachala_temi, id_users) VALUES (@id_temi, @start_temi, @id_users)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_temi", id_temi);
                    command.Parameters.AddWithValue("@start_temi", start_temi);
                    command.Parameters.AddWithValue("@id_users", id_users);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        private void dla_case(string tema)
        {
            start_temi = DateTime.Now;
            id_temi = poisk_id_konsp(tema);
            konspect = poisk_konsp(tema);
            prov = proverka__zap(id_user, id_temi);
            dobav_v_jyr(id_temi, id_user, start_temi, prov);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT konspect FROM konsp WHERE name_temi = @tema";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tema", tema);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        conclusion_lecture.NavigateToString("<html><head></head><body></body></html>");

                        if (reader.Read() && reader["konspect"] != DBNull.Value)
                        {
                            string html_code = reader["konspect"].ToString();

                            conclusion_lecture.NavigateToString(html_code);
                        }
                        else
                        {
                            string message = "<html><head></head><body>Преподаватель ещё не внёс лекцию.</body></html>";
                            conclusion_lecture.NavigateToString(message);
                        }
                    }
                }
            }
        }

        private void combobox_lec(string sections_name)
        {
            Spisok_pred.Text = "";
            Spisok_pred.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name_temi FROM konsp WHERE name_razdel = @sections_name";

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

                                if (!Spisok_pred.Items.Contains(value))
                                {
                                    Spisok_pred.Items.Add(value);
                                    has_themes = true;
                                }
                            }
                        }

                        if (!has_themes)
                        {
                            Spisok_pred.Text = "В данном разделе ещё нет тем.";
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

        private void razd_spisok_SelectedIndexChanged(object sender, EventArgs e)
        {
            razdel = razd_spisok.Text;
            if (razdel == "")
            {
                MessageBox.Show("Вы не выбрали раздел!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            combobox_lec(razdel);
        }

        private void Spisok_pred_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tema = Spisok_pred.Text;
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

        private void назадНаНачальнокОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teoria.ActiveForm.Hide();
            Nachalo MyNachalo = new Nachalo();
            MyNachalo.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teoria.ActiveForm.Hide();
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
