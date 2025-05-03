
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
            TextBoxユーザーID = new TextBox();
            TextBoxパスワード = new TextBox();
            label2 = new Label();
            Buttonログイン = new Button();
            Button終了 = new Button();
            label3 = new Label();
            label4 = new Label();
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
            // TextBoxユーザーID
            // 
            TextBoxユーザーID.Location = new Point(94, 20);
            TextBoxユーザーID.Name = "TextBoxユーザーID";
            TextBoxユーザーID.Size = new Size(138, 23);
            TextBoxユーザーID.TabIndex = 1;
            // 
            // TextBoxパスワード
            // 
            TextBoxパスワード.Location = new Point(94, 61);
            TextBoxパスワード.Name = "TextBoxパスワード";
            TextBoxパスワード.PasswordChar = '*';
            TextBoxパスワード.Size = new Size(138, 23);
            TextBoxパスワード.TabIndex = 3;
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
            Buttonログイン.Location = new Point(85, 188);
            Buttonログイン.Name = "Buttonログイン";
            Buttonログイン.Size = new Size(75, 23);
            Buttonログイン.TabIndex = 4;
            Buttonログイン.Text = "ログイン";
            Buttonログイン.UseVisualStyleBackColor = true;
            Buttonログイン.Click += Buttonログイン_Click;
            // 
            // Button終了
            // 
            Button終了.Location = new Point(221, 188);
            Button終了.Name = "Button終了";
            Button終了.Size = new Size(75, 23);
            Button終了.TabIndex = 5;
            Button終了.Text = "終了";
            Button終了.UseVisualStyleBackColor = true;
            Button終了.Click += Button終了_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 114);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "admin/password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 145);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "user/test";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 227);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Button終了);
            Controls.Add(Buttonログイン);
            Controls.Add(TextBoxパスワード);
            Controls.Add(label2);
            Controls.Add(TextBoxユーザーID);
            Controls.Add(label1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ログイン";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private TextBox TextBoxユーザーID;
        private TextBox TextBoxパスワード;
        private Label label2;
        private Button Buttonログイン;
        private Button Button終了;
        private Label label3;
        private Label label4;
    }
}
