namespace Csharpecoursework
{
    partial class List_SellsForm
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
            this.ricBoxShowDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ricBoxShowDetails
            // 
            this.ricBoxShowDetails.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricBoxShowDetails.Location = new System.Drawing.Point(79, 39);
            this.ricBoxShowDetails.Name = "ricBoxShowDetails";
            this.ricBoxShowDetails.Size = new System.Drawing.Size(597, 485);
            this.ricBoxShowDetails.TabIndex = 0;
            this.ricBoxShowDetails.Text = "";
            this.ricBoxShowDetails.TextChanged += new System.EventHandler(this.ricBoxShowDetails_TextChanged);
            // 
            // List_SellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharpecoursework.Properties.Resources.background_g3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 536);
            this.Controls.Add(this.ricBoxShowDetails);
            this.Name = "List_SellsForm";
            this.Text = "List_SellsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ricBoxShowDetails;
    }
}