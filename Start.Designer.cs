namespace DSS
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lb_1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            bt_Start = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_1
            // 
            lb_1.BackColor = Color.Transparent;
            lb_1.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_1.ForeColor = SystemColors.Control;
            lb_1.Location = new Point(86, 43);
            lb_1.Name = "lb_1";
            lb_1.Size = new Size(701, 48);
            lb_1.TabIndex = 0;
            lb_1.Text = "Depression diagnostic program";
            // 
            // bt_Start
            // 
            bt_Start.BorderRadius = 20;
            bt_Start.CustomizableEdges = customizableEdges1;
            bt_Start.DisabledState.BorderColor = Color.DarkGray;
            bt_Start.DisabledState.CustomBorderColor = Color.DarkGray;
            bt_Start.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bt_Start.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            bt_Start.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bt_Start.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Start.ForeColor = Color.White;
            bt_Start.HoverState.FillColor = Color.LightSalmon;
            bt_Start.HoverState.FillColor2 = Color.FromArgb(255, 192, 192);
            bt_Start.Location = new Point(310, 155);
            bt_Start.Name = "bt_Start";
            bt_Start.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bt_Start.Size = new Size(225, 56);
            bt_Start.TabIndex = 1;
            bt_Start.Text = "START";
            bt_Start.Click += bt_Start_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BorderRadius = 10;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.ErrorImage = (Image)resources.GetObject("guna2PictureBox1.ErrorImage");
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(310, 249);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(216, 237);
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 18, 40);
            ClientSize = new Size(883, 504);
            Controls.Add(guna2PictureBox1);
            Controls.Add(bt_Start);
            Controls.Add(lb_1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            Opacity = 0.98D;
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_1;
        private Guna.UI2.WinForms.Guna2GradientButton bt_Start;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}