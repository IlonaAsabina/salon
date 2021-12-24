namespace Salon
{
    partial class avtorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avtorization));
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.vhod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vhod_client = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(152)))), ((int)(((byte)(36)))));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(-11, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(507, 469);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(117, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginField.Location = new System.Drawing.Point(116, 240);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(263, 43);
            this.loginField.TabIndex = 3;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passField.Location = new System.Drawing.Point(116, 311);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(263, 43);
            this.passField.TabIndex = 4;
            // 
            // vhod
            // 
            this.vhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.vhod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vhod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.vhod.Location = new System.Drawing.Point(194, 381);
            this.vhod.Name = "vhod";
            this.vhod.Size = new System.Drawing.Size(110, 43);
            this.vhod.TabIndex = 5;
            this.vhod.Text = "вход";
            this.vhod.UseVisualStyleBackColor = false;
            this.vhod.Click += new System.EventHandler(this.vhod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(460, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // vhod_client
            // 
            this.vhod_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.vhod_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vhod_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vhod_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.vhod_client.Location = new System.Drawing.Point(156, 41);
            this.vhod_client.Name = "vhod_client";
            this.vhod_client.Size = new System.Drawing.Size(188, 61);
            this.vhod_client.TabIndex = 8;
            this.vhod_client.Text = "зайти на сайт\r\n";
            this.vhod_client.UseVisualStyleBackColor = false;
            this.vhod_client.Click += new System.EventHandler(this.vhod_client_Click);
            // 
            // avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 461);
            this.Controls.Add(this.vhod_client);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vhod);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Name = "avtorization";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button vhod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vhod_client;
    }
}

