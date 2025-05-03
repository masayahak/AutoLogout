namespace AutoLogout
{
    partial class Form業務１
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
            Button終了 = new Button();
            Button登録 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Button終了
            // 
            Button終了.Location = new Point(234, 120);
            Button終了.Name = "Button終了";
            Button終了.Size = new Size(75, 23);
            Button終了.TabIndex = 11;
            Button終了.Text = "終了";
            Button終了.UseVisualStyleBackColor = true;
            Button終了.Click += Button終了_Click;
            // 
            // Button登録
            // 
            Button登録.Location = new Point(98, 120);
            Button登録.Name = "Button登録";
            Button登録.Size = new Size(75, 23);
            Button登録.TabIndex = 10;
            Button登録.Text = "登録";
            Button登録.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "業務①";
            // 
            // Form業務１
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 160);
            Controls.Add(Button終了);
            Controls.Add(Button登録);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form業務１";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form業務１";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button終了;
        private Button Button登録;
        private TextBox textBox1;
        private Label label1;
    }
}