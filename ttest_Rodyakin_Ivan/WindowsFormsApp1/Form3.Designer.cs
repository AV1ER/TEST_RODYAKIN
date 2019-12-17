namespace WindowsFormsApp1
{
    partial class Registration
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
            this.RegLoginTextBox = new System.Windows.Forms.TextBox();
            this.RegLoginLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RegPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegLoginTextBox
            // 
            this.RegLoginTextBox.Location = new System.Drawing.Point(152, 71);
            this.RegLoginTextBox.Name = "RegLoginTextBox";
            this.RegLoginTextBox.Size = new System.Drawing.Size(152, 20);
            this.RegLoginTextBox.TabIndex = 0;
            // 
            // RegLoginLabel
            // 
            this.RegLoginLabel.AutoSize = true;
            this.RegLoginLabel.Location = new System.Drawing.Point(149, 55);
            this.RegLoginLabel.Name = "RegLoginLabel";
            this.RegLoginLabel.Size = new System.Drawing.Size(33, 13);
            this.RegLoginLabel.TabIndex = 1;
            this.RegLoginLabel.Text = "Login";
            this.RegLoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(184, 153);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(75, 23);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Registration";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 0;
            // 
            // RegPasswordLabel
            // 
            this.RegPasswordLabel.AutoSize = true;
            this.RegPasswordLabel.Location = new System.Drawing.Point(149, 101);
            this.RegPasswordLabel.Name = "RegPasswordLabel";
            this.RegPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.RegPasswordLabel.TabIndex = 1;
            this.RegPasswordLabel.Text = "Password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 274);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.RegPasswordLabel);
            this.Controls.Add(this.RegLoginLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RegLoginTextBox);
            this.Name = "Registration";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegLoginTextBox;
        private System.Windows.Forms.Label RegLoginLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RegPasswordLabel;
    }
}