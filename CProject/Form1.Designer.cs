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
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(871, 431);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(863, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCatalog);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(863, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Catalog";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCatalog
            // 
            dgvCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalog.Dock = DockStyle.Bottom;
            dgvCatalog.Location = new Point(2, 61);
            dgvCatalog.Margin = new Padding(3, 4, 3, 4);
            dgvCatalog.Name = "dgvCatalog";
            dgvCatalog.RowHeadersWidth = 51;
            dgvCatalog.RowTemplate.Height = 25;
            dgvCatalog.Size = new Size(859, 336);
            dgvCatalog.TabIndex = 0;
            dgvCatalog.CellContentClick += dgvCatalog_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(863, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
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
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 1, 2, 1);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(863, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Admin";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 230);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 26;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 166);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 25;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 99);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 24;
            label3.Text = "Add Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 23;
            label2.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 22;
            label1.Text = "Model:";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(222, 314);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 21;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            // 
            // btBrand
            // 
            btBrand.Location = new Point(268, 123);
            btBrand.Name = "btBrand";
            btBrand.Size = new Size(48, 29);
            btBrand.TabIndex = 20;
            btBrand.Text = "Add";
            btBrand.UseVisualStyleBackColor = true;
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(35, 122);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(73, 28);
            cbBrand.TabIndex = 19;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(35, 189);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(281, 27);
            tbPrice.TabIndex = 18;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(35, 253);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(281, 27);
            tbDescription.TabIndex = 17;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(127, 123);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(125, 27);
            tbBrand.TabIndex = 16;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(35, 60);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(281, 27);
            tbModel.TabIndex = 15;
            // 
            // dgPhone
            // 
            dgPhone.BackgroundColor = SystemColors.ButtonHighlight;
            dgPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhone.Location = new Point(368, 34);
            dgPhone.Name = "dgPhone";
            dgPhone.RowHeadersWidth = 51;
            dgPhone.RowTemplate.Height = 29;
            dgPhone.Size = new Size(460, 331);
            dgPhone.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 431);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
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
    }
}
