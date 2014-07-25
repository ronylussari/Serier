namespace Serier
{
    partial class Form1
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
            this.serie1 = new System.Windows.Forms.Label();
            this.series1latest = new System.Windows.Forms.Label();
            this.series1Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serie1
            // 
            this.serie1.AutoSize = true;
            this.serie1.Location = new System.Drawing.Point(12, 45);
            this.serie1.Name = "serie1";
            this.serie1.Size = new System.Drawing.Size(55, 13);
            this.serie1.TabIndex = 0;
            this.serie1.Text = "Homeland";
            // 
            // series1latest
            // 
            this.series1latest.AutoSize = true;
            this.series1latest.Location = new System.Drawing.Point(146, 45);
            this.series1latest.Name = "series1latest";
            this.series1latest.Size = new System.Drawing.Size(71, 13);
            this.series1latest.TabIndex = 1;
            this.series1latest.Text = "Senast visat: ";
            // 
            // series1Search
            // 
            this.series1Search.Location = new System.Drawing.Point(448, 35);
            this.series1Search.Name = "series1Search";
            this.series1Search.Size = new System.Drawing.Size(75, 23);
            this.series1Search.TabIndex = 2;
            this.series1Search.Text = "Sök torrent";
            this.series1Search.UseVisualStyleBackColor = true;
            this.series1Search.Click += new System.EventHandler(this.series1Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 504);
            this.Controls.Add(this.series1Search);
            this.Controls.Add(this.series1latest);
            this.Controls.Add(this.serie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serie1;
        private System.Windows.Forms.Label series1latest;
        private System.Windows.Forms.Button series1Search;
    }
}

