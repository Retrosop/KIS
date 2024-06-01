namespace LibraryApp
{
    partial class BooksData
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
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPublish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genres_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_genres_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(274, 88);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(98, 23);
            this.textBoxAuthor.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(274, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(98, 23);
            this.textBoxName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Автор книги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Название книги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(347, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Добавление новой записи";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Книги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genres_id,
            this.books_name,
            this.books_author,
            this.books_year,
            this.books_copies,
            this.books_genres_id});
            this.dataGridView1.Location = new System.Drawing.Point(168, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(628, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 403);
            this.panel1.TabIndex = 19;
            // 
            // textBoxPublish
            // 
            this.textBoxPublish.Location = new System.Drawing.Point(470, 45);
            this.textBoxPublish.Name = "textBoxPublish";
            this.textBoxPublish.Size = new System.Drawing.Size(98, 23);
            this.textBoxPublish.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Год издания:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(470, 88);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(98, 23);
            this.textBoxQuantity.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Кол-во копий:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(673, 45);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(98, 23);
            this.textBoxGenre.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Номер жанра:";
            // 
            // genres_id
            // 
            this.genres_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.genres_id.HeaderText = "Номер";
            this.genres_id.Name = "genres_id";
            this.genres_id.Width = 70;
            // 
            // books_name
            // 
            this.books_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.books_name.HeaderText = "Название книги";
            this.books_name.Name = "books_name";
            // 
            // books_author
            // 
            this.books_author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.books_author.HeaderText = "Автор книги";
            this.books_author.Name = "books_author";
            // 
            // books_year
            // 
            this.books_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.books_year.HeaderText = "Год публикации";
            this.books_year.Name = "books_year";
            // 
            // books_copies
            // 
            this.books_copies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.books_copies.HeaderText = "Копии книг";
            this.books_copies.Name = "books_copies";
            // 
            // books_genres_id
            // 
            this.books_genres_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.books_genres_id.HeaderText = "Жанр книги";
            this.books_genres_id.Name = "books_genres_id";
            this.books_genres_id.ReadOnly = true;
            this.books_genres_id.Width = 98;
            // 
            // BooksData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPublish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "BooksData";
            this.Text = "Информация о книгах";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private TextBox textBoxAuthor;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBoxPublish;
        private Label label5;
        private TextBox textBoxQuantity;
        private Label label6;
        private TextBox textBoxGenre;
        private Label label7;
        private DataGridViewTextBoxColumn genres_id;
        private DataGridViewTextBoxColumn books_name;
        private DataGridViewTextBoxColumn books_author;
        private DataGridViewTextBoxColumn books_year;
        private DataGridViewTextBoxColumn books_copies;
        private DataGridViewTextBoxColumn books_genres_id;
    }
}