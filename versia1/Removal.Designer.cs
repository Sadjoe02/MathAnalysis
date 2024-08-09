
namespace versia1
{
    partial class Removal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Removal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.delete_sections = new System.Windows.Forms.TabPage();
            this.delete_section = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_sections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_themes = new System.Windows.Forms.TabPage();
            this.list_themes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_theme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.list_sections_in_th = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lecture_notes = new System.Windows.Forms.TabPage();
            this.list_themes_lecture_notes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delete_lecture_notes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.list_sections_lecture_notes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.summaries_examples = new System.Windows.Forms.TabPage();
            this.list_themes_summary_examples = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.delete_summaries_examples = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.list_sections_summary_examples = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deleting_tests = new System.Windows.Forms.TabPage();
            this.list_test_levels = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.list_tests = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.delete_test = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.list_sections_tests = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадНаНачальнокОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.delete_sections.SuspendLayout();
            this.delete_themes.SuspendLayout();
            this.lecture_notes.SuspendLayout();
            this.summaries_examples.SuspendLayout();
            this.deleting_tests.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.delete_sections);
            this.tabControl1.Controls.Add(this.delete_themes);
            this.tabControl1.Controls.Add(this.lecture_notes);
            this.tabControl1.Controls.Add(this.summaries_examples);
            this.tabControl1.Controls.Add(this.deleting_tests);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 244);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // delete_sections
            // 
            this.delete_sections.BackColor = System.Drawing.Color.Tan;
            this.delete_sections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_sections.Controls.Add(this.delete_section);
            this.delete_sections.Controls.Add(this.label2);
            this.delete_sections.Controls.Add(this.list_sections);
            this.delete_sections.Controls.Add(this.label1);
            this.delete_sections.Location = new System.Drawing.Point(4, 30);
            this.delete_sections.Name = "delete_sections";
            this.delete_sections.Padding = new System.Windows.Forms.Padding(3);
            this.delete_sections.Size = new System.Drawing.Size(959, 210);
            this.delete_sections.TabIndex = 1;
            this.delete_sections.Text = "Удаление раздела";
            // 
            // delete_section
            // 
            this.delete_section.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_section.BackColor = System.Drawing.Color.Bisque;
            this.delete_section.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_section.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_section.Location = new System.Drawing.Point(423, 105);
            this.delete_section.Name = "delete_section";
            this.delete_section.Size = new System.Drawing.Size(122, 34);
            this.delete_section.TabIndex = 3;
            this.delete_section.Text = "Удалить";
            this.delete_section.UseVisualStyleBackColor = false;
            this.delete_section.Click += new System.EventHandler(this.delete_section_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(928, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Предупреждение! Удлаение раздела приведёт к потере всех тем, коснпектов лекций и " +
    "примеров, а также тестов и \r\nих результатов, относящихся к данныму разделу!\r\n";
            // 
            // list_sections
            // 
            this.list_sections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_sections.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_sections.FormattingEnabled = true;
            this.list_sections.Location = new System.Drawing.Point(273, 11);
            this.list_sections.Name = "list_sections";
            this.list_sections.Size = new System.Drawing.Size(678, 29);
            this.list_sections.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите раздел для удаления:";
            // 
            // delete_themes
            // 
            this.delete_themes.BackColor = System.Drawing.Color.Tan;
            this.delete_themes.Controls.Add(this.list_themes);
            this.delete_themes.Controls.Add(this.label5);
            this.delete_themes.Controls.Add(this.delete_theme);
            this.delete_themes.Controls.Add(this.label3);
            this.delete_themes.Controls.Add(this.list_sections_in_th);
            this.delete_themes.Controls.Add(this.label4);
            this.delete_themes.Location = new System.Drawing.Point(4, 30);
            this.delete_themes.Name = "delete_themes";
            this.delete_themes.Padding = new System.Windows.Forms.Padding(3);
            this.delete_themes.Size = new System.Drawing.Size(959, 210);
            this.delete_themes.TabIndex = 0;
            this.delete_themes.Text = "Удаление темы";
            // 
            // list_themes
            // 
            this.list_themes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_themes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_themes.FormattingEnabled = true;
            this.list_themes.Location = new System.Drawing.Point(348, 54);
            this.list_themes.Name = "list_themes";
            this.list_themes.Size = new System.Drawing.Size(603, 29);
            this.list_themes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите тему, которую нужно удалить:";
            // 
            // delete_theme
            // 
            this.delete_theme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_theme.BackColor = System.Drawing.Color.Bisque;
            this.delete_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_theme.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_theme.Location = new System.Drawing.Point(424, 146);
            this.delete_theme.Name = "delete_theme";
            this.delete_theme.Size = new System.Drawing.Size(122, 34);
            this.delete_theme.TabIndex = 7;
            this.delete_theme.Text = "Удалить";
            this.delete_theme.UseVisualStyleBackColor = false;
            this.delete_theme.Click += new System.EventHandler(this.delete_theme_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(887, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Предупреждение! При удалении темы будут автоматически удалены все связанные с ней" +
    " конспекты лекций, \r\nпримеры, а также тесты и их результаты!\r\n";
            // 
            // list_sections_in_th
            // 
            this.list_sections_in_th.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_sections_in_th.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_sections_in_th.FormattingEnabled = true;
            this.list_sections_in_th.Location = new System.Drawing.Point(481, 13);
            this.list_sections_in_th.Name = "list_sections_in_th";
            this.list_sections_in_th.Size = new System.Drawing.Size(471, 29);
            this.list_sections_in_th.TabIndex = 5;
            this.list_sections_in_th.SelectedIndexChanged += new System.EventHandler(this.list_sections_in_th_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите раздел, из которого необходимо удалить тему:";
            // 
            // lecture_notes
            // 
            this.lecture_notes.BackColor = System.Drawing.Color.Tan;
            this.lecture_notes.Controls.Add(this.list_themes_lecture_notes);
            this.lecture_notes.Controls.Add(this.label6);
            this.lecture_notes.Controls.Add(this.delete_lecture_notes);
            this.lecture_notes.Controls.Add(this.label7);
            this.lecture_notes.Controls.Add(this.list_sections_lecture_notes);
            this.lecture_notes.Controls.Add(this.label8);
            this.lecture_notes.Location = new System.Drawing.Point(4, 30);
            this.lecture_notes.Name = "lecture_notes";
            this.lecture_notes.Size = new System.Drawing.Size(959, 210);
            this.lecture_notes.TabIndex = 2;
            this.lecture_notes.Text = "Удаление конспекта лекции";
            // 
            // list_themes_lecture_notes
            // 
            this.list_themes_lecture_notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_themes_lecture_notes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_themes_lecture_notes.FormattingEnabled = true;
            this.list_themes_lecture_notes.Location = new System.Drawing.Point(356, 52);
            this.list_themes_lecture_notes.Name = "list_themes_lecture_notes";
            this.list_themes_lecture_notes.Size = new System.Drawing.Size(595, 29);
            this.list_themes_lecture_notes.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите тему, конспект лекции которой\r\nнеобходимо удалить:";
            // 
            // delete_lecture_notes
            // 
            this.delete_lecture_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_lecture_notes.BackColor = System.Drawing.Color.Bisque;
            this.delete_lecture_notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_lecture_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_lecture_notes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_lecture_notes.Location = new System.Drawing.Point(424, 144);
            this.delete_lecture_notes.Name = "delete_lecture_notes";
            this.delete_lecture_notes.Size = new System.Drawing.Size(122, 34);
            this.delete_lecture_notes.TabIndex = 13;
            this.delete_lecture_notes.Text = "Удалить";
            this.delete_lecture_notes.UseVisualStyleBackColor = false;
            this.delete_lecture_notes.Click += new System.EventHandler(this.delete_lecture_notes_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(166, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(626, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Предупреждение! При удалении конспекта лекции вернуть его будет нельзя!\r\n";
            // 
            // list_sections_lecture_notes
            // 
            this.list_sections_lecture_notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_sections_lecture_notes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_sections_lecture_notes.FormattingEnabled = true;
            this.list_sections_lecture_notes.Location = new System.Drawing.Point(510, 11);
            this.list_sections_lecture_notes.Name = "list_sections_lecture_notes";
            this.list_sections_lecture_notes.Size = new System.Drawing.Size(442, 29);
            this.list_sections_lecture_notes.TabIndex = 11;
            this.list_sections_lecture_notes.SelectedIndexChanged += new System.EventHandler(this.list_sections_lecture_notes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.NavajoWhite;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(497, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Выберите раздел, из которого необходимо конспект лекции:";
            // 
            // summaries_examples
            // 
            this.summaries_examples.BackColor = System.Drawing.Color.Tan;
            this.summaries_examples.Controls.Add(this.list_themes_summary_examples);
            this.summaries_examples.Controls.Add(this.label9);
            this.summaries_examples.Controls.Add(this.delete_summaries_examples);
            this.summaries_examples.Controls.Add(this.label10);
            this.summaries_examples.Controls.Add(this.list_sections_summary_examples);
            this.summaries_examples.Controls.Add(this.label11);
            this.summaries_examples.Location = new System.Drawing.Point(4, 30);
            this.summaries_examples.Name = "summaries_examples";
            this.summaries_examples.Size = new System.Drawing.Size(959, 210);
            this.summaries_examples.TabIndex = 3;
            this.summaries_examples.Text = "Удаление конспекта примеров";
            // 
            // list_themes_summary_examples
            // 
            this.list_themes_summary_examples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_themes_summary_examples.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_themes_summary_examples.FormattingEnabled = true;
            this.list_themes_summary_examples.Location = new System.Drawing.Point(313, 52);
            this.list_themes_summary_examples.Name = "list_themes_summary_examples";
            this.list_themes_summary_examples.Size = new System.Drawing.Size(638, 29);
            this.list_themes_summary_examples.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.NavajoWhite;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 42);
            this.label9.TabIndex = 20;
            this.label9.Text = "Выберите тему, конспект примеров \r\nкоторой необходимо удалить:";
            // 
            // delete_summaries_examples
            // 
            this.delete_summaries_examples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_summaries_examples.BackColor = System.Drawing.Color.Bisque;
            this.delete_summaries_examples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_summaries_examples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_summaries_examples.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_summaries_examples.Location = new System.Drawing.Point(424, 144);
            this.delete_summaries_examples.Name = "delete_summaries_examples";
            this.delete_summaries_examples.Size = new System.Drawing.Size(122, 34);
            this.delete_summaries_examples.TabIndex = 19;
            this.delete_summaries_examples.Text = "Удалить";
            this.delete_summaries_examples.UseVisualStyleBackColor = false;
            this.delete_summaries_examples.Click += new System.EventHandler(this.delete_summaries_examples_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Salmon;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(161, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(649, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Предупреждение! При удалении конспекта примеров вернуть его будет нельзя!\r\n";
            // 
            // list_sections_summary_examples
            // 
            this.list_sections_summary_examples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_sections_summary_examples.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_sections_summary_examples.FormattingEnabled = true;
            this.list_sections_summary_examples.Location = new System.Drawing.Point(533, 11);
            this.list_sections_summary_examples.Name = "list_sections_summary_examples";
            this.list_sections_summary_examples.Size = new System.Drawing.Size(419, 29);
            this.list_sections_summary_examples.TabIndex = 17;
            this.list_sections_summary_examples.SelectedIndexChanged += new System.EventHandler(this.list_sections_summary_examples_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.NavajoWhite;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(520, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Выберите раздел, из которого необходимо конспект примеров:";
            // 
            // deleting_tests
            // 
            this.deleting_tests.BackColor = System.Drawing.Color.Tan;
            this.deleting_tests.Controls.Add(this.list_test_levels);
            this.deleting_tests.Controls.Add(this.label15);
            this.deleting_tests.Controls.Add(this.list_tests);
            this.deleting_tests.Controls.Add(this.label12);
            this.deleting_tests.Controls.Add(this.delete_test);
            this.deleting_tests.Controls.Add(this.label13);
            this.deleting_tests.Controls.Add(this.list_sections_tests);
            this.deleting_tests.Controls.Add(this.label14);
            this.deleting_tests.Location = new System.Drawing.Point(4, 30);
            this.deleting_tests.Name = "deleting_tests";
            this.deleting_tests.Size = new System.Drawing.Size(959, 210);
            this.deleting_tests.TabIndex = 4;
            this.deleting_tests.Text = "Удаление тестов";
            // 
            // list_test_levels
            // 
            this.list_test_levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_test_levels.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_test_levels.FormattingEnabled = true;
            this.list_test_levels.Location = new System.Drawing.Point(319, 46);
            this.list_test_levels.Name = "list_test_levels";
            this.list_test_levels.Size = new System.Drawing.Size(632, 29);
            this.list_test_levels.TabIndex = 17;
            this.list_test_levels.SelectedIndexChanged += new System.EventHandler(this.list_test_levels_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.NavajoWhite;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(7, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(306, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Выберите уровень удаляемого теста:";
            // 
            // list_tests
            // 
            this.list_tests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_tests.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_tests.FormattingEnabled = true;
            this.list_tests.Location = new System.Drawing.Point(145, 81);
            this.list_tests.Name = "list_tests";
            this.list_tests.Size = new System.Drawing.Size(806, 29);
            this.list_tests.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Выберите тест:";
            // 
            // delete_test
            // 
            this.delete_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_test.BackColor = System.Drawing.Color.Bisque;
            this.delete_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_test.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_test.Location = new System.Drawing.Point(416, 171);
            this.delete_test.Name = "delete_test";
            this.delete_test.Size = new System.Drawing.Size(122, 34);
            this.delete_test.TabIndex = 13;
            this.delete_test.Text = "Удалить";
            this.delete_test.UseVisualStyleBackColor = false;
            this.delete_test.Click += new System.EventHandler(this.delete_test_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Salmon;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(68, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(816, 42);
            this.label13.TabIndex = 12;
            this.label13.Text = "Предупреждение! При удалении теста будут автоматически удалены все связанные с ни" +
    "м вопросы, \r\nответы, а также их результаты!\r\n";
            // 
            // list_sections_tests
            // 
            this.list_sections_tests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_sections_tests.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_sections_tests.FormattingEnabled = true;
            this.list_sections_tests.Location = new System.Drawing.Point(481, 11);
            this.list_sections_tests.Name = "list_sections_tests";
            this.list_sections_tests.Size = new System.Drawing.Size(471, 29);
            this.list_sections_tests.TabIndex = 11;
            this.list_sections_tests.SelectedIndexChanged += new System.EventHandler(this.list_sections_tests_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.NavajoWhite;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(7, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(464, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "Выберите раздел, из которого необходимо удалить тест:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.назадНаНачальнокОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(967, 27);
            this.menuStrip1.TabIndex = 116;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // назадНаНачальнокОкноToolStripMenuItem
            // 
            this.назадНаНачальнокОкноToolStripMenuItem.Name = "назадНаНачальнокОкноToolStripMenuItem";
            this.назадНаНачальнокОкноToolStripMenuItem.Size = new System.Drawing.Size(189, 23);
            this.назадНаНачальнокОкноToolStripMenuItem.Text = "Назад на начальное окно";
            this.назадНаНачальнокОкноToolStripMenuItem.Click += new System.EventHandler(this.назадНаНачальнокОкноToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Removal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(967, 272);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Removal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление";
            this.tabControl1.ResumeLayout(false);
            this.delete_sections.ResumeLayout(false);
            this.delete_sections.PerformLayout();
            this.delete_themes.ResumeLayout(false);
            this.delete_themes.PerformLayout();
            this.lecture_notes.ResumeLayout(false);
            this.lecture_notes.PerformLayout();
            this.summaries_examples.ResumeLayout(false);
            this.summaries_examples.PerformLayout();
            this.deleting_tests.ResumeLayout(false);
            this.deleting_tests.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage delete_sections;
        private System.Windows.Forms.TabPage delete_themes;
        private System.Windows.Forms.TabPage lecture_notes;
        private System.Windows.Forms.TabPage summaries_examples;
        private System.Windows.Forms.TabPage deleting_tests;
        private System.Windows.Forms.Button delete_section;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_sections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_theme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox list_sections_in_th;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox list_themes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox list_themes_lecture_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete_lecture_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox list_sections_lecture_notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox list_themes_summary_examples;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delete_summaries_examples;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox list_sections_summary_examples;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox list_test_levels;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox list_tests;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete_test;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox list_sections_tests;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадНаНачальнокОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}