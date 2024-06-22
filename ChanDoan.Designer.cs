namespace DSS
{
    partial class ChanDoan
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_kqua = new Guna.UI2.WinForms.Guna2TextBox();
            btExit = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(214, 47);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(380, 47);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Kết quả chẩn đoán bệnh";
            // 
            // txt_kqua
            // 
            txt_kqua.CustomizableEdges = customizableEdges1;
            txt_kqua.DefaultText = "";
            txt_kqua.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_kqua.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_kqua.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_kqua.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_kqua.FillColor = Color.LightSteelBlue;
            txt_kqua.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_kqua.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txt_kqua.ForeColor = Color.Black;
            txt_kqua.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_kqua.Location = new Point(39, 153);
            txt_kqua.Margin = new Padding(6, 10, 6, 10);
            txt_kqua.Name = "txt_kqua";
            txt_kqua.PasswordChar = '\0';
            txt_kqua.PlaceholderText = "";
            txt_kqua.SelectedText = "";
            txt_kqua.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_kqua.Size = new Size(711, 210);
            txt_kqua.TabIndex = 1;
            txt_kqua.TextAlign = HorizontalAlignment.Center;
            // 
            // btExit
            // 
            btExit.BorderRadius = 5;
            btExit.CustomizableEdges = customizableEdges3;
            btExit.DisabledState.BorderColor = Color.DarkGray;
            btExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btExit.FillColor = SystemColors.GradientActiveCaption;
            btExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.ForeColor = Color.Black;
            btExit.Location = new Point(744, 2);
            btExit.Name = "btExit";
            btExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btExit.Size = new Size(44, 44);
            btExit.TabIndex = 12;
            btExit.Text = "X";
            btExit.Click += btExit_Click;
            // 
            // ChanDoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 18, 40);
            ClientSize = new Size(789, 415);
            Controls.Add(btExit);
            Controls.Add(txt_kqua);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChanDoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChanDoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_kqua;
        private Guna.UI2.WinForms.Guna2Button btExit;
    }
}