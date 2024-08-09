
namespace versia1
{
    partial class Teoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teoria));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Spisok_pred = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.razd_spisok = new System.Windows.Forms.ComboBox();
            this.conclusion_lecture = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадНаНачальнокОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.conclusion_lecture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_pred
            // 
            this.Spisok_pred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spisok_pred.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_pred.FormattingEnabled = true;
            this.Spisok_pred.Location = new System.Drawing.Point(427, 64);
            this.Spisok_pred.Margin = new System.Windows.Forms.Padding(2);
            this.Spisok_pred.Name = "Spisok_pred";
            this.Spisok_pred.Size = new System.Drawing.Size(592, 27);
            this.Spisok_pred.TabIndex = 14;
            this.Spisok_pred.SelectedIndexChanged += new System.EventHandler(this.Spisok_pred_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "2. Выбор лекции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "1. Выбор раздела:";
            // 
            // razd_spisok
            // 
            this.razd_spisok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.razd_spisok.Font = new System.Drawing.Font("PT Astra Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razd_spisok.FormattingEnabled = true;
            this.razd_spisok.Location = new System.Drawing.Point(9, 65);
            this.razd_spisok.Margin = new System.Windows.Forms.Padding(2);
            this.razd_spisok.Name = "razd_spisok";
            this.razd_spisok.Size = new System.Drawing.Size(407, 27);
            this.razd_spisok.TabIndex = 18;
            this.razd_spisok.SelectedIndexChanged += new System.EventHandler(this.razd_spisok_SelectedIndexChanged);
            // 
            // conclusion_lecture
            // 
            this.conclusion_lecture.AllowExternalDrop = true;
            this.conclusion_lecture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conclusion_lecture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.conclusion_lecture.CreationProperties = null;
            this.conclusion_lecture.DefaultBackgroundColor = System.Drawing.Color.White;
            this.conclusion_lecture.Location = new System.Drawing.Point(36, 124);
            this.conclusion_lecture.Name = "conclusion_lecture";
            this.conclusion_lecture.Size = new System.Drawing.Size(957, 499);
            this.conclusion_lecture.TabIndex = 21;
            this.conclusion_lecture.ZoomFactor = 1D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.назадНаНачальнокОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 58;
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
            // Teoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::versia1.Properties.Resources.fon6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 635);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.conclusion_lecture);
            this.Controls.Add(this.razd_spisok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spisok_pred);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Teoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теория";
            this.Load += new System.EventHandler(this.Teoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conclusion_lecture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox Spisok_pred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox razd_spisok;
        private Microsoft.Web.WebView2.WinForms.WebView2 conclusion_lecture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадНаНачальнокОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}