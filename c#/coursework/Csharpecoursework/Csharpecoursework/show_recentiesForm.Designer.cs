namespace Csharpecoursework
{
    partial class show_recentiesForm
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
            this.ricshowrecenties = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ricshowrecenties
            // 
            this.ricshowrecenties.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricshowrecenties.Location = new System.Drawing.Point(132, 84);
            this.ricshowrecenties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ricshowrecenties.Name = "ricshowrecenties";
            this.ricshowrecenties.Size = new System.Drawing.Size(472, 356);
            this.ricshowrecenties.TabIndex = 1;
            this.ricshowrecenties.Text = "";
            // 
            // show_recentiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharpecoursework.Properties.Resources.cover5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 647);
            this.Controls.Add(this.ricshowrecenties);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "show_recentiesForm";
            this.Text = "show_recentiesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ricshowrecenties;

    }
}