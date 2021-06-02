using System.Net.Sockets;

namespace регистрация
{
    partial class ReportDataForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.workFormEXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(100, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "КОПИРОВАТЬ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // workFormEXIT
            // 
            this.workFormEXIT.BackColor = System.Drawing.SystemColors.Control;
            this.workFormEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workFormEXIT.FlatAppearance.BorderSize = 0;
            this.workFormEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workFormEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workFormEXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.workFormEXIT.Location = new System.Drawing.Point(244, 0);
            this.workFormEXIT.Name = "workFormEXIT";
            this.workFormEXIT.Size = new System.Drawing.Size(56, 37);
            this.workFormEXIT.TabIndex = 83;
            this.workFormEXIT.Text = "х";
            this.workFormEXIT.UseVisualStyleBackColor = false;
            this.workFormEXIT.Click += new System.EventHandler(this.workFormEXIT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ОТЧЕТ СОХРАНЕН ПО ПУТИ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(25, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 50);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "C:\\Users\\User\\source\\repos\\курсач3клиент\\курсач3клиент\\bin\\Debug\\Отчет№22548567.t" +
    "xt";
            // 
            // areUsure
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.workFormEXIT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportDataForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportDataForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button workFormEXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}