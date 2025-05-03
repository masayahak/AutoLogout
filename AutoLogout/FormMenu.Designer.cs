namespace AutoLogout
{
    partial class FormMenu
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
            Button業務１ = new Button();
            Button業務２ = new Button();
            Button終了 = new Button();
            Labelログイン者 = new Label();
            SuspendLayout();
            // 
            // Button業務１
            // 
            Button業務１.Location = new Point(28, 29);
            Button業務１.Name = "Button業務１";
            Button業務１.Size = new Size(219, 54);
            Button業務１.TabIndex = 0;
            Button業務１.Text = "業務①";
            Button業務１.UseVisualStyleBackColor = true;
            Button業務１.Click += Button業務１_Click;
            // 
            // Button業務２
            // 
            Button業務２.Location = new Point(28, 102);
            Button業務２.Name = "Button業務２";
            Button業務２.Size = new Size(219, 54);
            Button業務２.TabIndex = 1;
            Button業務２.Text = "業務②";
            Button業務２.UseVisualStyleBackColor = true;
            // 
            // Button終了
            // 
            Button終了.Location = new Point(704, 415);
            Button終了.Name = "Button終了";
            Button終了.Size = new Size(75, 23);
            Button終了.TabIndex = 6;
            Button終了.Text = "終了";
            Button終了.UseVisualStyleBackColor = true;
            Button終了.Click += Button終了_Click;
            // 
            // Labelログイン者
            // 
            Labelログイン者.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Labelログイン者.Location = new Point(437, 9);
            Labelログイン者.Name = "Labelログイン者";
            Labelログイン者.Size = new Size(359, 19);
            Labelログイン者.TabIndex = 7;
            Labelログイン者.Text = "ログイン者";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(Labelログイン者);
            Controls.Add(Button終了);
            Controls.Add(Button業務２);
            Controls.Add(Button業務１);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Button業務１;
        private Button Button業務２;
        private Button Button終了;
        private Label Labelログイン者;
    }
}