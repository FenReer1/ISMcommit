namespace WinFormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x1 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.Label();
            this.z1 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.BackColor = System.Drawing.Color.White;
            this.x1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.x1.Location = new System.Drawing.Point(22, 46);
            this.x1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(31, 23);
            this.x1.TabIndex = 0;
            this.x1.Text = "x =";
            this.x1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // y1
            // 
            this.y1.AutoSize = true;
            this.y1.BackColor = System.Drawing.Color.White;
            this.y1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.y1.Location = new System.Drawing.Point(22, 84);
            this.y1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(30, 23);
            this.y1.TabIndex = 1;
            this.y1.Text = "y =";
            // 
            // z1
            // 
            this.z1.AutoSize = true;
            this.z1.BackColor = System.Drawing.Color.White;
            this.z1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.z1.Location = new System.Drawing.Point(22, 118);
            this.z1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(31, 23);
            this.z1.TabIndex = 2;
            this.z1.Text = "z =";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.White;
            this.r1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.r1.Location = new System.Drawing.Point(22, 246);
            this.r1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(28, 23);
            this.r1.TabIndex = 3;
            this.r1.Text = "r =";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(56, 50);
            this.x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(108, 20);
            this.x.TabIndex = 4;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(56, 84);
            this.y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(108, 20);
            this.y.TabIndex = 5;
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(56, 118);
            this.z.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(108, 20);
            this.z.TabIndex = 6;
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(54, 246);
            this.r.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r.Name = "r";
            this.r.ReadOnly = true;
            this.r.Size = new System.Drawing.Size(108, 20);
            this.r.TabIndex = 7;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.result.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.result.Location = new System.Drawing.Point(56, 166);
            this.result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(107, 38);
            this.result.TabIndex = 8;
            this.result.Text = "Обчислити";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.Button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(208, 333);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Пекарєв М. Д. КБ-19-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(332, 354);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.r);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 427);
            this.MinimumSize = new System.Drawing.Size(192, 332);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практична робота №2. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label y1;
        private System.Windows.Forms.Label z1;
        private System.Windows.Forms.Label r1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox z;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

