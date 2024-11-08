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
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(871, 431);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(863, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(863, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Catalog";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2);
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
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(863, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Admin";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 234);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 13;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 170);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 12;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 103);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 11;
            label3.Text = "Add Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 103);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 10;
            label2.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 9;
            label1.Text = "Model:";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(220, 318);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 8;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btBrand
            // 
            btBrand.Location = new Point(266, 127);
            btBrand.Name = "btBrand";
            btBrand.Size = new Size(48, 29);
            btBrand.TabIndex = 7;
            btBrand.Text = "Add";
            btBrand.UseVisualStyleBackColor = true;
            btBrand.Click += btBrand_Click;
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(33, 126);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(73, 28);
            cbBrand.TabIndex = 6;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(33, 193);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(281, 27);
            tbPrice.TabIndex = 5;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(33, 257);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(281, 27);
            tbDescription.TabIndex = 4;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(125, 127);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(125, 27);
            tbBrand.TabIndex = 3;
            tbBrand.TextChanged += tbBrand_TextChanged;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(33, 64);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(281, 27);
            tbModel.TabIndex = 1;
            // 
            // dgPhone
            // 
            dgPhone.BackgroundColor = SystemColors.ButtonHighlight;
            dgPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhone.Location = new Point(366, 38);
            dgPhone.Name = "dgPhone";
            dgPhone.RowHeadersWidth = 51;
            dgPhone.RowTemplate.Height = 29;
            dgPhone.Size = new Size(460, 331);
            dgPhone.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 431);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
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
        private TextBox tbPrice;
        private TextBox tbDescription;
        private TextBox tbBrand;
        private TextBox tbModel;
        private DataGridView dgPhone;
        private Button btAdd;
        private Button btBrand;
        private ComboBox cbBrand;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
