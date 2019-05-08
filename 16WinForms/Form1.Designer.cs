namespace _16WinForms
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClickMeButton.Location = new System.Drawing.Point(114, 98);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(142, 35);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MessageTextBox.Location = new System.Drawing.Point(114, 35);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(142, 26);
            this.MessageTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
    }
}

