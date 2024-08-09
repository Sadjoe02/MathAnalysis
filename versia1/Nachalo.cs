using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versia1
{
    public partial class Nachalo : Form
    {
        public Nachalo()
        {
            InitializeComponent();
            if (flag == 1)
            {
                dobavl_lec.Visible = true;
                dob_l_tests.Visible = true;
                dob_sred_t.Visible = true;
                dob_sloj_t.Visible = true;
                change.Visible = true;
                linkLabel7.Visible = true;
            }
            else
            {
                dobavl_lec.Visible = false;
                dob_l_tests.Visible = false;
                dob_sred_t.Visible = false;
                dob_sloj_t.Visible = false;
                change.Visible = false;
                linkLabel7.Visible = false;
            }
        }

        int flag = Vxod.Flag;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 200;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.linkLabel1, "Краткие сведения по таким темам, как пределы и производные");
            toolTip1.SetToolTip(this.linkLabel2, "Разобранное решение выражений на каждую тему");
            toolTip1.SetToolTip(this.linkLabel3, "Проверка знаний после изучения теории и примеров");
            toolTip1.SetToolTip(this.linkLabel4, "Вычисление некоторых типов пределов и производных");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Teoria MyTeoria = new Teoria();
            MyTeoria.ShowDialog();
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Primer MyPrimer = new Primer();
            MyPrimer.ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Prom_okno_tests MyProm_okno_tests = new Prom_okno_tests();
            MyProm_okno_tests.ShowDialog();
            Close();
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Solver MySolver = new Solver();
            MySolver.ShowDialog();
            Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Info MyInfo = new Info();
            MyInfo.ShowDialog();
            Close();
        }

        private void viiti_Click(object sender, EventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Vxod MyVxod = new Vxod();
            MyVxod.ShowDialog();
            Close();
        }

        private void dobavl_lec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            add_lecture Myadd_lecture = new add_lecture();
            Myadd_lecture.ShowDialog();
            Close();
        }

        private void dob_l_tests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            dobav_test_leg Mydobav_test_leg = new dobav_test_leg();
            Mydobav_test_leg.ShowDialog();
            Close();
        }

        private void dob_sred_t_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            dobav_sred_testov Mydobav_sred_testov = new dobav_sred_testov();
            Mydobav_sred_testov.ShowDialog();
            Close();
        }

        private void dob_sloj_t_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            adding_complex_tests Myadding_complex_tests = new adding_complex_tests();
            Myadding_complex_tests.ShowDialog();
            Close();
        }

        private void change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Changing_themes MyChanging_themes = new Changing_themes();
            MyChanging_themes.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nachalo.ActiveForm.Hide();
            Removal MyRemoval = new Removal();
            MyRemoval.ShowDialog();
            Close();
        }
    }
}
