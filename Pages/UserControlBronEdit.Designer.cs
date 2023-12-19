namespace CinemaAppLOLGG.Pages
{
    partial class UserControlBronEdit
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HALL_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROW_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.ID_SESSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazvanie_filma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HALL_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(214, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 111);
            this.button4.TabIndex = 54;
            this.button4.Text = "Обновить Зал";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(197, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 29);
            this.button3.TabIndex = 53;
            this.button3.Text = "О";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(29, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 111);
            this.button2.TabIndex = 52;
            this.button2.Text = "Обновить Сеанс";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_POSITION,
            this.ID_HALL_P,
            this.ROW_NAME,
            this.PLACE_NUMBER,
            this.STATUS_P});
            this.dataGridView1.Location = new System.Drawing.Point(644, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 253);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_POSITION
            // 
            this.ID_POSITION.DataPropertyName = "ID_POSITION";
            this.ID_POSITION.HeaderText = "ID";
            this.ID_POSITION.MinimumWidth = 6;
            this.ID_POSITION.Name = "ID_POSITION";
            this.ID_POSITION.ReadOnly = true;
            // 
            // ID_HALL_P
            // 
            this.ID_HALL_P.DataPropertyName = "ID_HALL_P";
            this.ID_HALL_P.HeaderText = "Id зала";
            this.ID_HALL_P.MinimumWidth = 6;
            this.ID_HALL_P.Name = "ID_HALL_P";
            this.ID_HALL_P.ReadOnly = true;
            // 
            // ROW_NAME
            // 
            this.ROW_NAME.DataPropertyName = "ROW_NAME";
            this.ROW_NAME.HeaderText = "СТРОКА";
            this.ROW_NAME.MinimumWidth = 6;
            this.ROW_NAME.Name = "ROW_NAME";
            this.ROW_NAME.ReadOnly = true;
            // 
            // PLACE_NUMBER
            // 
            this.PLACE_NUMBER.DataPropertyName = "PLACE_NUMBER";
            this.PLACE_NUMBER.HeaderText = "Номер";
            this.PLACE_NUMBER.MinimumWidth = 6;
            this.PLACE_NUMBER.Name = "PLACE_NUMBER";
            this.PLACE_NUMBER.ReadOnly = true;
            // 
            // STATUS_P
            // 
            this.STATUS_P.DataPropertyName = "STATUS_P";
            this.STATUS_P.HeaderText = "Статус П";
            this.STATUS_P.MinimumWidth = 6;
            this.STATUS_P.Name = "STATUS_P";
            this.STATUS_P.ReadOnly = true;
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SESSION,
            this.Nazvanie_filma,
            this.ID_HALL_S,
            this.DATA_S,
            this.Price});
            this.dataGridViewFilms.Location = new System.Drawing.Point(20, 199);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            this.dataGridViewFilms.RowHeadersWidth = 51;
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.Size = new System.Drawing.Size(549, 253);
            this.dataGridViewFilms.TabIndex = 48;
            this.dataGridViewFilms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilms_CellClick);
            // 
            // ID_SESSION
            // 
            this.ID_SESSION.DataPropertyName = "ID_SESSION";
            this.ID_SESSION.HeaderText = "Id";
            this.ID_SESSION.MinimumWidth = 6;
            this.ID_SESSION.Name = "ID_SESSION";
            this.ID_SESSION.ReadOnly = true;
            // 
            // Nazvanie_filma
            // 
            this.Nazvanie_filma.DataPropertyName = "Nazvanie_filma";
            this.Nazvanie_filma.HeaderText = "Фильм";
            this.Nazvanie_filma.MinimumWidth = 6;
            this.Nazvanie_filma.Name = "Nazvanie_filma";
            this.Nazvanie_filma.ReadOnly = true;
            // 
            // ID_HALL_S
            // 
            this.ID_HALL_S.DataPropertyName = "ID_HALL_S";
            this.ID_HALL_S.HeaderText = "Id зала";
            this.ID_HALL_S.MinimumWidth = 6;
            this.ID_HALL_S.Name = "ID_HALL_S";
            this.ID_HALL_S.ReadOnly = true;
            // 
            // DATA_S
            // 
            this.DATA_S.DataPropertyName = "DATA_S";
            this.DATA_S.HeaderText = "Дата";
            this.DATA_S.MinimumWidth = 6;
            this.DATA_S.Name = "DATA_S";
            this.DATA_S.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 40);
            this.label1.TabIndex = 47;
            this.label1.Text = "Фильм";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 29);
            this.comboBox1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 40);
            this.label5.TabIndex = 45;
            this.label5.Text = "Изменение и удаление брони";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(838, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 107);
            this.button5.TabIndex = 55;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(529, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 107);
            this.button1.TabIndex = 56;
            this.button1.Text = "Снести сеанс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlBronEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewFilms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlBronEdit";
            this.Size = new System.Drawing.Size(1143, 620);
            this.Load += new System.EventHandler(this.UserControlBronEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HALL_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_P;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SESSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazvanie_filma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HALL_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}
