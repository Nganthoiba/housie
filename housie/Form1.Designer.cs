namespace housie
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOUSIE TICKET COLLECTION RECORD";
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(657, 49);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(163, 20);
            this.search_text.TabIndex = 1;
            this.search_text.Text = "Enter something to search for";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Housie Ticket Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button button1;
    }
}

