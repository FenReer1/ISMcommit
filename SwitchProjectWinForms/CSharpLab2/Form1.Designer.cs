namespace CSharpLab2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dayt = new System.Windows.Forms.TextBox();
            this.dat = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.yt = new System.Windows.Forms.TextBox();
            this.montht = new System.Windows.Forms.Label();
            this.ytex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расшифровка дня недели";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Расшифровка месяца";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выполнение операций над числами";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dayt
            // 
            this.dayt.Location = new System.Drawing.Point(252, 47);
            this.dayt.Name = "dayt";
            this.dayt.Size = new System.Drawing.Size(166, 20);
            this.dayt.TabIndex = 4;
            this.dayt.TextChanged += new System.EventHandler(this.Day_TextChanged);
            // 
            // dat
            // 
            this.dat.AutoSize = true;
            this.dat.Location = new System.Drawing.Point(490, 44);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(0, 13);
            this.dat.TabIndex = 5;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(252, 108);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(166, 20);
            this.month.TabIndex = 6;
            // 
            // yt
            // 
            this.yt.Location = new System.Drawing.Point(252, 172);
            this.yt.Name = "yt";
            this.yt.Size = new System.Drawing.Size(166, 20);
            this.yt.TabIndex = 7;
            // 
            // montht
            // 
            this.montht.AutoSize = true;
            this.montht.Location = new System.Drawing.Point(490, 108);
            this.montht.Name = "montht";
            this.montht.Size = new System.Drawing.Size(0, 13);
            this.montht.TabIndex = 8;
            // 
            // ytex
            // 
            this.ytex.AutoSize = true;
            this.ytex.Location = new System.Drawing.Point(490, 172);
            this.ytex.Name = "ytex";
            this.ytex.Size = new System.Drawing.Size(0, 13);
            this.ytex.TabIndex = 9;
            this.ytex.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "день";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "месяц";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "x=";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "y=";
            this.label7.Visible = false;
            // 
            // dia
            // 
            this.dia.Location = new System.Drawing.Point(252, 210);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(166, 20);
            this.dia.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "действие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ytex);
            this.Controls.Add(this.montht);
            this.Controls.Add(this.yt);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.dayt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Практична 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox dayt;
        private System.Windows.Forms.Label dat;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox yt;
        private System.Windows.Forms.Label montht;
        private System.Windows.Forms.Label ytex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.Label label1;
    }
}

