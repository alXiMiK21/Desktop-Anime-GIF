namespace DesktopKonata.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip2 = new MenuStrip();
            btn_GIF1 = new ToolStripMenuItem();
            btn_GIF2 = new ToolStripMenuItem();
            btn_GIF3 = new ToolStripMenuItem();
            btn_GIF4 = new ToolStripMenuItem();
            btn_GIF5 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { btn_GIF1, btn_GIF2, btn_GIF3, btn_GIF4, btn_GIF5 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(249, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // btn_GIF1
            // 
            btn_GIF1.Name = "btn_GIF1";
            btn_GIF1.Size = new Size(42, 20);
            btn_GIF1.Text = "1.gif";
            btn_GIF1.Click += btn_gif1_Click;
            // 
            // btn_GIF2
            // 
            btn_GIF2.Name = "btn_GIF2";
            btn_GIF2.Size = new Size(42, 20);
            btn_GIF2.Text = "2.gif";
            btn_GIF2.Click += btn_gif2_Click;
            // 
            // btn_GIF3
            // 
            btn_GIF3.Name = "btn_GIF3";
            btn_GIF3.Size = new Size(42, 20);
            btn_GIF3.Text = "3.gif";
            btn_GIF3.Click += btn_gif3_Click;
            // 
            // btn_GIF4
            // 
            btn_GIF4.Name = "btn_GIF4";
            btn_GIF4.Size = new Size(42, 20);
            btn_GIF4.Text = "4.gif";
            btn_GIF4.Click += btn_gif4_Click;
            // 
            // btn_GIF5
            // 
            btn_GIF5.Name = "btn_GIF5";
            btn_GIF5.Size = new Size(42, 20);
            btn_GIF5.Text = "5.gif";
            btn_GIF5.Click += btn_gif5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(168, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(87, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Hide";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(6, 27);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Clear\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(249, 58);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Desktop Anime GIF";
            TopMost = true;
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem btn_GIF2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem btn_GIF3;
        private ToolStripMenuItem btn_GIF1;
        private ToolStripMenuItem btn_GIF4;
        private ToolStripMenuItem btn_GIF5;
    }
}