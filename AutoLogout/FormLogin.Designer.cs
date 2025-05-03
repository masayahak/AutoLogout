
namespace AutoLogout
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            Buttonログイン = new Button();
            Button終了 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "ユーザー";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "パスワード";
            // 
            // Buttonログイン
            // 
            Buttonログイン.Location = new Point(21, 120);
            Buttonログイン.Name = "Buttonログイン";
            Buttonログイン.Size = new Size(75, 23);
            Buttonログイン.TabIndex = 4;
            Buttonログイン.Text = "ログイン";
            Buttonログイン.UseVisualStyleBackColor = true;
            Buttonログイン.Click += this.Buttonログイン_Click;
            // 
            // Button終了
            // 
            Button終了.Location = new Point(157, 120);
            Button終了.Name = "Button終了";
            Button終了.Size = new Size(75, 23);
            Button終了.TabIndex = 5;
            Button終了.Text = "終了";
            Button終了.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 160);
            Controls.Add(Button終了);
            Controls.Add(Buttonログイン);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ログイン";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button Buttonログイン;
        private Button Button終了;
    }
}
