namespace CinemaAppLOLGG.Pages
{
    partial class UserControlSeans
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.comboBoxHall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSeansDel = new System.Windows.Forms.Button();
            this.buttonSeansEdit = new System.Windows.Forms.Button();
            this.buttonSeansAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = "Добавление и изменение сеанса";
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(86, 168);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(235, 29);
            this.comboBoxFilm.TabIndex = 28;
            // 
            // comboBoxHall
            // 
            this.comboBoxHall.FormattingEnabled = true;
            this.comboBoxHall.Location = new System.Drawing.Point(86, 273);
            this.comboBoxHall.Name = "comboBoxHall";
            this.comboBoxHall.Size = new System.Drawing.Size(235, 29);
            this.comboBoxHall.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "Фильм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 40);
            this.label2.TabIndex = 33;
            this.label2.Text = "Зал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 40);
            this.label3.TabIndex = 34;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(621, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 40);
            this.label4.TabIndex = 35;
            this.label4.Text = "Цена";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(628, 168);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(199, 28);
            this.textBoxIn.TabIndex = 36;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(628, 274);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(199, 28);
            this.textBoxPrice.TabIndex = 37;
            // 
            // buttonSeansDel
            // 
            this.buttonSeansDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeansDel.BackColor = System.Drawing.Color.Red;
            this.buttonSeansDel.FlatAppearance.BorderSize = 0;
            this.buttonSeansDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeansDel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeansDel.ForeColor = System.Drawing.Color.White;
            this.buttonSeansDel.Location = new System.Drawing.Point(914, 465);
            this.buttonSeansDel.Name = "buttonSeansDel";
            this.buttonSeansDel.Size = new System.Drawing.Size(180, 111);
            this.buttonSeansDel.TabIndex = 39;
            this.buttonSeansDel.Text = "Снести";
            this.buttonSeansDel.UseVisualStyleBackColor = false;
            this.buttonSeansDel.Click += new System.EventHandler(this.buttonSeansDel_Click);
            // 
            // buttonSeansEdit
            // 
            this.buttonSeansEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeansEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.buttonSeansEdit.FlatAppearance.BorderSize = 0;
            this.buttonSeansEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeansEdit.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeansEdit.ForeColor = System.Drawing.Color.White;
            this.buttonSeansEdit.Location = new System.Drawing.Point(568, 465);
            this.buttonSeansEdit.Name = "buttonSeansEdit";
            this.buttonSeansEdit.Size = new System.Drawing.Size(293, 111);
            this.buttonSeansEdit.TabIndex = 38;
            this.buttonSeansEdit.Text = "Изменить";
            this.buttonSeansEdit.UseVisualStyleBackColor = false;
            this.buttonSeansEdit.Click += new System.EventHandler(this.buttonSeansEdit_Click);
            // 
            // buttonSeansAdd
            // 
            this.buttonSeansAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeansAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.buttonSeansAdd.FlatAppearance.BorderSize = 0;
            this.buttonSeansAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeansAdd.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeansAdd.ForeColor = System.Drawing.Color.White;
            this.buttonSeansAdd.Location = new System.Drawing.Point(233, 465);
            this.buttonSeansAdd.Name = "buttonSeansAdd";
            this.buttonSeansAdd.Size = new System.Drawing.Size(293, 111);
            this.buttonSeansAdd.TabIndex = 40;
            this.buttonSeansAdd.Text = "Добавить";
            this.buttonSeansAdd.UseVisualStyleBackColor = false;
            this.buttonSeansAdd.Click += new System.EventHandler(this.buttonSeansAdd_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(54, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 111);
            this.button2.TabIndex = 41;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControlSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSeansAdd);
            this.Controls.Add(this.buttonSeansDel);
            this.Controls.Add(this.buttonSeansEdit);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxHall);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlSeans";
            this.Size = new System.Drawing.Size(1143, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.ComboBox comboBoxHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSeansDel;
        private System.Windows.Forms.Button buttonSeansEdit;
        private System.Windows.Forms.Button buttonSeansAdd;
        private System.Windows.Forms.Button button2;
    }
}
