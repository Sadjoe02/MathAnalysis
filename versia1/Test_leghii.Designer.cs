
namespace versia1
{
    partial class Test_leghii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_leghii));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spisok_razdel = new System.Windows.Forms.ComboBox();
            this.Spisok_tem = new System.Windows.Forms.ComboBox();
            this.Vopros = new System.Windows.Forms.RichTextBox();
            this.Sled = new System.Windows.Forms.Button();
            this.K_r = new System.Windows.Forms.RadioButton();
            this.I_r = new System.Windows.Forms.RadioButton();
            this.Z_r = new System.Windows.Forms.RadioButton();
            this.J_r = new System.Windows.Forms.RadioButton();
            this.E_r = new System.Windows.Forms.RadioButton();
            this.D_r = new System.Windows.Forms.RadioButton();
            this.G_r = new System.Windows.Forms.RadioButton();
            this.V_r = new System.Windows.Forms.RadioButton();
            this.B_r = new System.Windows.Forms.RadioButton();
            this.A_r = new System.Windows.Forms.RadioButton();
            this.label_vopros = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадКВыборуУровняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадНаНачальнокОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Выберите раздел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(371, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Выберите тест:";
            // 
            // spisok_razdel
            // 
            this.spisok_razdel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spisok_razdel.FormattingEnabled = true;
            this.spisok_razdel.Location = new System.Drawing.Point(7, 73);
            this.spisok_razdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spisok_razdel.Name = "spisok_razdel";
            this.spisok_razdel.Size = new System.Drawing.Size(340, 30);
            this.spisok_razdel.TabIndex = 2;
            this.spisok_razdel.SelectedIndexChanged += new System.EventHandler(this.spisok_razdel_SelectedIndexChanged);
            // 
            // Spisok_tem
            // 
            this.Spisok_tem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spisok_tem.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_tem.FormattingEnabled = true;
            this.Spisok_tem.Location = new System.Drawing.Point(369, 73);
            this.Spisok_tem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Spisok_tem.Name = "Spisok_tem";
            this.Spisok_tem.Size = new System.Drawing.Size(1088, 30);
            this.Spisok_tem.TabIndex = 4;
            this.Spisok_tem.SelectedIndexChanged += new System.EventHandler(this.Spisok_tem_SelectedIndexChanged);
            // 
            // Vopros
            // 
            this.Vopros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vopros.BackColor = System.Drawing.SystemColors.Menu;
            this.Vopros.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vopros.Location = new System.Drawing.Point(5, 139);
            this.Vopros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vopros.Name = "Vopros";
            this.Vopros.ReadOnly = true;
            this.Vopros.Size = new System.Drawing.Size(1452, 143);
            this.Vopros.TabIndex = 25;
            this.Vopros.Text = "";
            this.Vopros.Visible = false;
            // 
            // Sled
            // 
            this.Sled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sled.BackColor = System.Drawing.Color.Wheat;
            this.Sled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sled.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sled.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sled.Location = new System.Drawing.Point(1284, 358);
            this.Sled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sled.Name = "Sled";
            this.Sled.Size = new System.Drawing.Size(173, 62);
            this.Sled.TabIndex = 31;
            this.Sled.Text = "Следующее задание";
            this.Sled.UseVisualStyleBackColor = false;
            this.Sled.Visible = false;
            this.Sled.Click += new System.EventHandler(this.Sled_Click);
            // 
            // K_r
            // 
            this.K_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.K_r.AutoSize = true;
            this.K_r.BackColor = System.Drawing.Color.Wheat;
            this.K_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.K_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.K_r.Location = new System.Drawing.Point(909, 455);
            this.K_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.K_r.Name = "K_r";
            this.K_r.Size = new System.Drawing.Size(17, 16);
            this.K_r.TabIndex = 59;
            this.K_r.UseVisualStyleBackColor = false;
            this.K_r.Visible = false;
            // 
            // I_r
            // 
            this.I_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.I_r.AutoSize = true;
            this.I_r.BackColor = System.Drawing.Color.Wheat;
            this.I_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.I_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.I_r.Location = new System.Drawing.Point(909, 416);
            this.I_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.I_r.Name = "I_r";
            this.I_r.Size = new System.Drawing.Size(17, 16);
            this.I_r.TabIndex = 58;
            this.I_r.UseVisualStyleBackColor = false;
            this.I_r.Visible = false;
            // 
            // Z_r
            // 
            this.Z_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Z_r.AutoSize = true;
            this.Z_r.BackColor = System.Drawing.Color.Wheat;
            this.Z_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Z_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Z_r.Location = new System.Drawing.Point(909, 380);
            this.Z_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Z_r.Name = "Z_r";
            this.Z_r.Size = new System.Drawing.Size(17, 16);
            this.Z_r.TabIndex = 57;
            this.Z_r.UseVisualStyleBackColor = false;
            this.Z_r.Visible = false;
            // 
            // J_r
            // 
            this.J_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.J_r.AutoSize = true;
            this.J_r.BackColor = System.Drawing.Color.Wheat;
            this.J_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.J_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.J_r.Location = new System.Drawing.Point(909, 342);
            this.J_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.J_r.Name = "J_r";
            this.J_r.Size = new System.Drawing.Size(17, 16);
            this.J_r.TabIndex = 56;
            this.J_r.UseVisualStyleBackColor = false;
            this.J_r.Visible = false;
            // 
            // E_r
            // 
            this.E_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.E_r.AutoSize = true;
            this.E_r.BackColor = System.Drawing.Color.Wheat;
            this.E_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.E_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E_r.Location = new System.Drawing.Point(909, 308);
            this.E_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.E_r.Name = "E_r";
            this.E_r.Size = new System.Drawing.Size(17, 16);
            this.E_r.TabIndex = 55;
            this.E_r.UseVisualStyleBackColor = false;
            this.E_r.Visible = false;
            // 
            // D_r
            // 
            this.D_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.D_r.AutoSize = true;
            this.D_r.BackColor = System.Drawing.Color.Wheat;
            this.D_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D_r.Location = new System.Drawing.Point(8, 455);
            this.D_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D_r.Name = "D_r";
            this.D_r.Size = new System.Drawing.Size(17, 16);
            this.D_r.TabIndex = 54;
            this.D_r.UseVisualStyleBackColor = false;
            this.D_r.Visible = false;
            // 
            // G_r
            // 
            this.G_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.G_r.AutoSize = true;
            this.G_r.BackColor = System.Drawing.Color.Wheat;
            this.G_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.G_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.G_r.Location = new System.Drawing.Point(8, 416);
            this.G_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.G_r.Name = "G_r";
            this.G_r.Size = new System.Drawing.Size(17, 16);
            this.G_r.TabIndex = 53;
            this.G_r.UseVisualStyleBackColor = false;
            this.G_r.Visible = false;
            // 
            // V_r
            // 
            this.V_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.V_r.AutoSize = true;
            this.V_r.BackColor = System.Drawing.Color.Wheat;
            this.V_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.V_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.V_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.V_r.Location = new System.Drawing.Point(8, 380);
            this.V_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.V_r.Name = "V_r";
            this.V_r.Size = new System.Drawing.Size(17, 16);
            this.V_r.TabIndex = 52;
            this.V_r.UseVisualStyleBackColor = false;
            this.V_r.Visible = false;
            // 
            // B_r
            // 
            this.B_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_r.AutoSize = true;
            this.B_r.BackColor = System.Drawing.Color.Wheat;
            this.B_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_r.Location = new System.Drawing.Point(8, 342);
            this.B_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_r.Name = "B_r";
            this.B_r.Size = new System.Drawing.Size(17, 16);
            this.B_r.TabIndex = 51;
            this.B_r.UseVisualStyleBackColor = false;
            this.B_r.Visible = false;
            // 
            // A_r
            // 
            this.A_r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.A_r.AutoSize = true;
            this.A_r.BackColor = System.Drawing.Color.Wheat;
            this.A_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A_r.Font = new System.Drawing.Font("PT Astra Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_r.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A_r.Location = new System.Drawing.Point(8, 308);
            this.A_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A_r.Name = "A_r";
            this.A_r.Size = new System.Drawing.Size(17, 16);
            this.A_r.TabIndex = 50;
            this.A_r.UseVisualStyleBackColor = false;
            this.A_r.Visible = false;
            // 
            // label_vopros
            // 
            this.label_vopros.AutoSize = true;
            this.label_vopros.BackColor = System.Drawing.Color.Wheat;
            this.label_vopros.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vopros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_vopros.Location = new System.Drawing.Point(8, 114);
            this.label_vopros.Name = "label_vopros";
            this.label_vopros.Size = new System.Drawing.Size(47, 22);
            this.label_vopros.TabIndex = 60;
            this.label_vopros.Text = "NaN";
            this.label_vopros.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.назадКВыборуУровняToolStripMenuItem,
            this.назадНаНачальнокОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1481, 30);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // назадКВыборуУровняToolStripMenuItem
            // 
            this.назадКВыборуУровняToolStripMenuItem.Name = "назадКВыборуУровняToolStripMenuItem";
            this.назадКВыборуУровняToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.назадКВыборуУровняToolStripMenuItem.Text = "Назад к выбору уровня";
            this.назадКВыборуУровняToolStripMenuItem.Click += new System.EventHandler(this.назадКВыборуУровняToolStripMenuItem_Click);
            // 
            // назадНаНачальнокОкноToolStripMenuItem
            // 
            this.назадНаНачальнокОкноToolStripMenuItem.Name = "назадНаНачальнокОкноToolStripMenuItem";
            this.назадНаНачальнокОкноToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.назадНаНачальнокОкноToolStripMenuItem.Text = "Назад на начальное окно";
            this.назадНаНачальнокОкноToolStripMenuItem.Click += new System.EventHandler(this.назадНаНачальнокОкноToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Test_leghii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::versia1.Properties.Resources._1618989108_19_phonoteka_org_p_matematicheskii_fon_belii_32;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1481, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_vopros);
            this.Controls.Add(this.K_r);
            this.Controls.Add(this.I_r);
            this.Controls.Add(this.Z_r);
            this.Controls.Add(this.J_r);
            this.Controls.Add(this.E_r);
            this.Controls.Add(this.D_r);
            this.Controls.Add(this.G_r);
            this.Controls.Add(this.V_r);
            this.Controls.Add(this.B_r);
            this.Controls.Add(this.A_r);
            this.Controls.Add(this.Sled);
            this.Controls.Add(this.Vopros);
            this.Controls.Add(this.Spisok_tem);
            this.Controls.Add(this.spisok_razdel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Test_leghii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лёгкий уровень";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox spisok_razdel;
        private System.Windows.Forms.ComboBox Spisok_tem;
        private System.Windows.Forms.RichTextBox Vopros;
        private System.Windows.Forms.Button Sled;
        private System.Windows.Forms.RadioButton K_r;
        private System.Windows.Forms.RadioButton I_r;
        private System.Windows.Forms.RadioButton Z_r;
        private System.Windows.Forms.RadioButton J_r;
        private System.Windows.Forms.RadioButton E_r;
        private System.Windows.Forms.RadioButton D_r;
        private System.Windows.Forms.RadioButton G_r;
        private System.Windows.Forms.RadioButton V_r;
        private System.Windows.Forms.RadioButton B_r;
        private System.Windows.Forms.RadioButton A_r;
        private System.Windows.Forms.Label label_vopros;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадНаНачальнокОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадКВыборуУровняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}