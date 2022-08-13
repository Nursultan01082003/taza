namespace taza
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baslawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Qar = new System.Windows.Forms.ToolStripMenuItem();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaziw = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.joqari = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baslawToolStripMenuItem,
            this.sdfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baslawToolStripMenuItem
            // 
            this.baslawToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.baslawToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baslawToolStripMenuItem.Name = "baslawToolStripMenuItem";
            this.baslawToolStripMenuItem.Size = new System.Drawing.Size(75, 27);
            this.baslawToolStripMenuItem.Text = "Baslaw";
            this.baslawToolStripMenuItem.Click += new System.EventHandler(this.baslawToolStripMenuItem_Click);
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Qar,
            this.dfToolStripMenuItem});
            this.sdfToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(129, 27);
            this.sdfToolStripMenuItem.Text = "Tildi o\'zgertiw";
            // 
            // Qar
            // 
            this.Qar.Name = "Qar";
            this.Qar.Size = new System.Drawing.Size(296, 28);
            this.Qar.Text = "Qaraqalpaqsha-Englishshe";
            this.Qar.Click += new System.EventHandler(this.sdfToolStripMenuItem1_Click);
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.dfToolStripMenuItem.Text = "Englishshe-Qaraqalpaqsha";
            this.dfToolStripMenuItem.Click += new System.EventHandler(this.dfToolStripMenuItem_Click);
            // 
            // jaziw
            // 
            this.jaziw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jaziw.Location = new System.Drawing.Point(140, 238);
            this.jaziw.Multiline = true;
            this.jaziw.Name = "jaziw";
            this.jaziw.Size = new System.Drawing.Size(272, 48);
            this.jaziw.TabIndex = 4;
            this.jaziw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jaziw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "01:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joqari
            // 
            this.joqari.BackColor = System.Drawing.Color.LawnGreen;
            this.joqari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joqari.Location = new System.Drawing.Point(140, 156);
            this.joqari.Name = "joqari";
            this.joqari.Size = new System.Drawing.Size(272, 48);
            this.joqari.TabIndex = 6;
            this.joqari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 215);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 126);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oyin juwmaqlandi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tag = "";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "jardem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(344, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = ">>>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.joqari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jaziw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baslawToolStripMenuItem;
        private System.Windows.Forms.TextBox jaziw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label joqari;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Qar;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

