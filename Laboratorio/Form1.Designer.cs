namespace Laboratorio
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ventana2ToolStripMenuItem = new ToolStripMenuItem();
            ventana3ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 9F);
            label1.Location = new Point(209, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 9F);
            label2.Location = new Point(59, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 9F);
            label3.Location = new Point(59, 169);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Snap ITC", 9F);
            textBox1.Location = new Point(168, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Snap ITC", 9F);
            textBox2.Location = new Point(168, 166);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(500, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventana2ToolStripMenuItem, ventana3ToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // ventana2ToolStripMenuItem
            // 
            ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
            ventana2ToolStripMenuItem.Size = new Size(118, 22);
            ventana2ToolStripMenuItem.Text = "Crud";
            ventana2ToolStripMenuItem.Click += ventana2ToolStripMenuItem_Click;
            // 
            // ventana3ToolStripMenuItem
            // 
            ventana3ToolStripMenuItem.Name = "ventana3ToolStripMenuItem";
            ventana3ToolStripMenuItem.Size = new Size(118, 22);
            ventana3ToolStripMenuItem.Text = "Creditos";
            ventana3ToolStripMenuItem.Click += ventana3ToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 9F);
            button1.Location = new Point(209, 228);
            button1.Name = "button1";
            button1.Size = new Size(89, 30);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(500, 308);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "V";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ventana2ToolStripMenuItem;
        private ToolStripMenuItem ventana3ToolStripMenuItem;
        private Button button1;
    }
}
