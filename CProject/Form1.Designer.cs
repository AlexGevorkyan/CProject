namespace CProject
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvCatalog = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btAdd = new Button();
            btBrand = new Button();
            cbBrand = new ComboBox();
            tbPrice = new TextBox();
            tbDescription = new TextBox();
            tbBrand = new TextBox();
            tbModel = new TextBox();
            dgPhone = new DataGridView();
            label6 = new Label();
            tbImage = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhone).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1415, 727);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1399, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCatalog);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1399, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Catalog";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCatalog
            // 
            dgvCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalog.Dock = DockStyle.Bottom;
            dgvCatalog.Location = new Point(3, 96);
            dgvCatalog.Margin = new Padding(5, 6, 5, 6);
            dgvCatalog.Name = "dgvCatalog";
            dgvCatalog.RowHeadersWidth = 51;
            dgvCatalog.RowTemplate.Height = 25;
            dgvCatalog.Size = new Size(1393, 538);
            dgvCatalog.TabIndex = 0;
            dgvCatalog.CellContentClick += dgvCatalog_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 46);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1399, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(tbImage);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(btAdd);
            tabPage4.Controls.Add(btBrand);
            tabPage4.Controls.Add(cbBrand);
            tabPage4.Controls.Add(tbPrice);
            tabPage4.Controls.Add(tbDescription);
            tabPage4.Controls.Add(tbBrand);
            tabPage4.Controls.Add(tbModel);
            tabPage4.Controls.Add(dgPhone);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1399, 673);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Admin";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 384);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 26;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 304);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 25;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 223);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 24;
            label3.Text = "Add Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 126);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 23;
            label2.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 22;
            label1.Text = "Model:";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(358, 562);
            btAdd.Margin = new Padding(5);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(153, 46);
            btAdd.TabIndex = 21;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btBrand
            // 
            btBrand.Location = new Point(433, 260);
            btBrand.Margin = new Padding(5);
            btBrand.Name = "btBrand";
            btBrand.Size = new Size(78, 46);
            btBrand.TabIndex = 20;
            btBrand.Text = "Add";
            btBrand.UseVisualStyleBackColor = true;
            btBrand.Click += btBrand_Click;
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(57, 163);
            cbBrand.Margin = new Padding(5);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(454, 40);
            cbBrand.TabIndex = 19;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(57, 340);
            tbPrice.Margin = new Padding(5);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(454, 39);
            tbPrice.TabIndex = 18;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(57, 421);
            tbDescription.Margin = new Padding(5);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(454, 39);
            tbDescription.TabIndex = 17;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(57, 260);
            tbBrand.Margin = new Padding(5);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(366, 39);
            tbBrand.TabIndex = 16;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(57, 77);
            tbModel.Margin = new Padding(5);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(454, 39);
            tbModel.TabIndex = 15;
            // 
            // dgPhone
            // 
            dgPhone.BackgroundColor = SystemColors.ButtonHighlight;
            dgPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhone.Location = new Point(554, 54);
            dgPhone.Margin = new Padding(5);
            dgPhone.Name = "dgPhone";
            dgPhone.RowHeadersWidth = 51;
            dgPhone.RowTemplate.Height = 29;
            dgPhone.Size = new Size(792, 554);
            dgPhone.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 461);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 28;
            label6.Text = "Image:";
            // 
            // tbImage
            // 
            tbImage.Location = new Point(57, 498);
            tbImage.Margin = new Padding(5);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(454, 39);
            tbImage.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 727);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvCatalog;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAdd;
        private Button btBrand;
        private ComboBox cbBrand;
        private TextBox tbPrice;
        private TextBox tbDescription;
        private TextBox tbBrand;
        private TextBox tbModel;
        private DataGridView dgPhone;
        private Label label6;
        private TextBox tbImage;
    }
}
