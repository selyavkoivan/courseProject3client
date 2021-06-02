
namespace регистрация
{
    partial class NoServerForm
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
            this.authorizationEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizationEXIT
            // 
            this.authorizationEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.authorizationEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationEXIT.FlatAppearance.BorderSize = 0;
            this.authorizationEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationEXIT.ForeColor = System.Drawing.Color.Red;
            this.authorizationEXIT.Location = new System.Drawing.Point(326, -4);
            this.authorizationEXIT.Name = "authorizationEXIT";
            this.authorizationEXIT.Size = new System.Drawing.Size(26, 32);
            this.authorizationEXIT.TabIndex = 11;
            this.authorizationEXIT.TabStop = false;
            this.authorizationEXIT.Text = "х";
            this.authorizationEXIT.UseVisualStyleBackColor = false;
            this.authorizationEXIT.Click += new System.EventHandler(this.authorizationEXIT_Click);
            // 
            // NoServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::регистрация.Properties.Resources.NoServer;
            this.ClientSize = new System.Drawing.Size(350, 275);
            this.Controls.Add(this.authorizationEXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoServerForm";
            this.Text = "NoServer";
            this.Load += new System.EventHandler(this.NoServerForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button authorizationEXIT;
    }
}