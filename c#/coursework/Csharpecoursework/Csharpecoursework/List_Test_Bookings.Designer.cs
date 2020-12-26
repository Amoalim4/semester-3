namespace Csharpecoursework
{
    partial class List_Test_Bookings
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
            this.richshowdetais = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richshowdetais
            // 
            this.richshowdetais.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richshowdetais.Location = new System.Drawing.Point(196, 34);
            this.richshowdetais.Name = "richshowdetais";
            this.richshowdetais.Size = new System.Drawing.Size(570, 588);
            this.richshowdetais.TabIndex = 0;
            this.richshowdetais.Text = "";
            // 
            // List_Test_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharpecoursework.Properties.Resources.background_g1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 625);
            this.Controls.Add(this.richshowdetais);
            this.Name = "List_Test_Bookings";
            this.Text = "List_Test_Bookings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richshowdetais;
    }
}