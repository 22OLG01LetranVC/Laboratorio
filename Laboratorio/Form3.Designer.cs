namespace Laboratorio
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            crudToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, crudToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // crudToolStripMenuItem
            // 
            crudToolStripMenuItem.Name = "crudToolStripMenuItem";
            crudToolStripMenuItem.Size = new Size(180, 22);
            crudToolStripMenuItem.Text = "Crud";
            crudToolStripMenuItem.Click += crudToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold);
            label1.Location = new Point(104, 75);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 1;
            label1.Text = "Oscar Humberto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold);
            label2.Location = new Point(104, 114);
            label2.Name = "label2";
            label2.Size = new Size(201, 24);
            label2.TabIndex = 2;
            label2.Text = "Letrán González";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold);
            label3.Location = new Point(104, 154);
            label3.Name = "label3";
            label3.Size = new Size(192, 24);
            label3.TabIndex = 3;
            label3.Text = "V Bachillerato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold);
            label4.Location = new Point(104, 195);
            label4.Name = "label4";
            label4.Size = new Size(125, 24);
            label4.TabIndex = 4;
            label4.Text = "Sección C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold);
            label5.Location = new Point(104, 239);
            label5.Name = "label5";
            label5.Size = new Size(114, 24);
            label5.TabIndex = 5;
            label5.Text = "Clave 17";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_04_25_a_las_20_52_27_015a13ae;
            pictureBox1.Location = new Point(403, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem crudToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}