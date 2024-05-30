namespace Zooshop_App1
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_supp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.textBoxProdDesc = new System.Windows.Forms.TextBox();
            this.textBoxProdPrice = new System.Windows.Forms.TextBox();
            this.textBoxProdQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProdSup = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Товары";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.pr_name,
            this.pr_desc,
            this.pr_price,
            this.pr_quantity,
            this.pr_category,
            this.pr_supp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 42;
            // 
            // pr_name
            // 
            this.pr_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_name.HeaderText = "Название";
            this.pr_name.Name = "pr_name";
            // 
            // pr_desc
            // 
            this.pr_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_desc.HeaderText = "Описание";
            this.pr_desc.Name = "pr_desc";
            // 
            // pr_price
            // 
            this.pr_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_price.HeaderText = "Цена";
            this.pr_price.Name = "pr_price";
            // 
            // pr_quantity
            // 
            this.pr_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_quantity.HeaderText = "Количество";
            this.pr_quantity.Name = "pr_quantity";
            // 
            // pr_category
            // 
            this.pr_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_category.HeaderText = "Категория";
            this.pr_category.Name = "pr_category";
            this.pr_category.ReadOnly = true;
            // 
            // pr_supp
            // 
            this.pr_supp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pr_supp.HeaderText = "Поставщик";
            this.pr_supp.Name = "pr_supp";
            this.pr_supp.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(377, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(387, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Категория:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DisplayMember = "id";
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(479, 83);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(149, 23);
            this.comboBoxCategories.TabIndex = 18;
            this.comboBoxCategories.ValueMember = "id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(Zooshop_App1.Categories);
            this.categoriesBindingSource.CurrentChanged += new System.EventHandler(this.categoriesBindingSource_CurrentChanged);
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(109, 41);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(156, 23);
            this.textBoxProdName.TabIndex = 19;
            // 
            // textBoxProdDesc
            // 
            this.textBoxProdDesc.Location = new System.Drawing.Point(109, 83);
            this.textBoxProdDesc.Name = "textBoxProdDesc";
            this.textBoxProdDesc.Size = new System.Drawing.Size(156, 23);
            this.textBoxProdDesc.TabIndex = 20;
            // 
            // textBoxProdPrice
            // 
            this.textBoxProdPrice.Location = new System.Drawing.Point(109, 125);
            this.textBoxProdPrice.Name = "textBoxProdPrice";
            this.textBoxProdPrice.Size = new System.Drawing.Size(156, 23);
            this.textBoxProdPrice.TabIndex = 21;
            // 
            // textBoxProdQuantity
            // 
            this.textBoxProdQuantity.Location = new System.Drawing.Point(479, 45);
            this.textBoxProdQuantity.Name = "textBoxProdQuantity";
            this.textBoxProdQuantity.Size = new System.Drawing.Size(149, 23);
            this.textBoxProdQuantity.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(380, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Поставщик:";
            // 
            // comboBoxProdSup
            // 
            this.comboBoxProdSup.DisplayMember = "id";
            this.comboBoxProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProdSup.FormattingEnabled = true;
            this.comboBoxProdSup.Location = new System.Drawing.Point(479, 127);
            this.comboBoxProdSup.Name = "comboBoxProdSup";
            this.comboBoxProdSup.Size = new System.Drawing.Size(149, 23);
            this.comboBoxProdSup.TabIndex = 24;
            this.comboBoxProdSup.ValueMember = "id";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // product_name
            // 
            this.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_name.HeaderText = "Название";
            this.product_name.Name = "product_name";
            // 
            // products_description
            // 
            this.products_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products_description.HeaderText = "Описание";
            this.products_description.Name = "products_description";
            // 
            // products_price
            // 
            this.products_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products_price.HeaderText = "Цена товара";
            this.products_price.Name = "products_price";
            // 
            // products_quantity
            // 
            this.products_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products_quantity.HeaderText = "Количество товара";
            this.products_quantity.Name = "products_quantity";
            // 
            // products_category
            // 
            this.products_category.HeaderText = "Категория";
            this.products_category.Name = "products_category";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxProdSup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxProdQuantity);
            this.Controls.Add(this.textBoxProdPrice);
            this.Controls.Add(this.textBoxProdDesc);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsForm";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxCategories;
        private BindingSource categoriesBindingSource;
        private TextBox textBoxProdName;
        private TextBox textBoxProdDesc;
        private TextBox textBoxProdPrice;
        private TextBox textBoxProdQuantity;
        private Label label7;
        private ComboBox comboBoxProdSup;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn products_description;
        private DataGridViewTextBoxColumn products_price;
        private DataGridViewTextBoxColumn products_quantity;
        private DataGridViewTextBoxColumn products_category;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn pr_name;
        private DataGridViewTextBoxColumn pr_desc;
        private DataGridViewTextBoxColumn pr_price;
        private DataGridViewTextBoxColumn pr_quantity;
        private DataGridViewTextBoxColumn pr_category;
        private DataGridViewTextBoxColumn pr_supp;
    }
}