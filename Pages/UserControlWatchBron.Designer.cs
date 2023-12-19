namespace CinemaAppLOLGG.Pages
{
    partial class UserControlWatchBron
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HALL_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROW_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewFilms);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(85, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 465);
            this.panel1.TabIndex = 15;
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
            this.ID_POSITION,
            this.ID_HALL_P,
            this.ROW_NAME,
            this.PLACE_NUMBER,
            this.STATUS_P});
            this.dataGridViewFilms.Location = new System.Drawing.Point(118, 128);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            this.dataGridViewFilms.RowHeadersWidth = 51;
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.Size = new System.Drawing.Size(857, 224);
            this.dataGridViewFilms.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(827, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Айди брони:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Просмотр и поиск брони";
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
            this.ID_HALL_P.HeaderText = "Зал";
            this.ID_HALL_P.MinimumWidth = 6;
            this.ID_HALL_P.Name = "ID_HALL_P";
            this.ID_HALL_P.ReadOnly = true;
            // 
            // ROW_NAME
            // 
            this.ROW_NAME.DataPropertyName = "ROW_NAME";
            this.ROW_NAME.HeaderText = "Ряд";
            this.ROW_NAME.MinimumWidth = 6;
            this.ROW_NAME.Name = "ROW_NAME";
            this.ROW_NAME.ReadOnly = true;
            // 
            // PLACE_NUMBER
            // 
            this.PLACE_NUMBER.DataPropertyName = "PLACE_NUMBER";
            this.PLACE_NUMBER.HeaderText = "Место";
            this.PLACE_NUMBER.MinimumWidth = 6;
            this.PLACE_NUMBER.Name = "PLACE_NUMBER";
            this.PLACE_NUMBER.ReadOnly = true;
            // 
            // STATUS_P
            // 
            this.STATUS_P.DataPropertyName = "STATUS_P";
            this.STATUS_P.HeaderText = "Статус";
            this.STATUS_P.MinimumWidth = 6;
            this.STATUS_P.Name = "STATUS_P";
            this.STATUS_P.ReadOnly = true;
            // 
            // UserControlWatchBron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlWatchBron";
            this.Size = new System.Drawing.Size(1143, 620);
            this.Load += new System.EventHandler(this.UserControlWatchBron_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HALL_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_P;
    }
}
