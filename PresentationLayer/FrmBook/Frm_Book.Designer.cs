namespace PresentationLayer.FrmBook
{
    partial class Frm_Book
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtPAgeCount = new System.Windows.Forms.TextBox();
            this.rbPasive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUnList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(62, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 27);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Kitap Id:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 27);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Kitap Adı:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(49, 200);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(142, 27);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Yazar Adı:";
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(127, 262);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 27);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Tür:";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(10, 320);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(181, 27);
            this.lblPageCount.TabIndex = 4;
            this.lblPageCount.Text = "Sayfa Sayısı:";
            this.lblPageCount.Click += new System.EventHandler(this.lblPageCount_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 375);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(129, 27);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Kategori:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(101, 434);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Durum:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(228, 34);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 34);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(197, 200);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(228, 34);
            this.txtAuthor.TabIndex = 9;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(196, 375);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(227, 35);
            this.comboBoxCategory.TabIndex = 10;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // txtPAgeCount
            // 
            this.txtPAgeCount.Location = new System.Drawing.Point(196, 320);
            this.txtPAgeCount.Name = "txtPAgeCount";
            this.txtPAgeCount.Size = new System.Drawing.Size(228, 34);
            this.txtPAgeCount.TabIndex = 12;
            this.txtPAgeCount.TextChanged += new System.EventHandler(this.txtPAgeCount_TextChanged);
            // 
            // rbPasive
            // 
            this.rbPasive.AutoSize = true;
            this.rbPasive.Location = new System.Drawing.Point(326, 434);
            this.rbPasive.Name = "rbPasive";
            this.rbPasive.Size = new System.Drawing.Size(98, 31);
            this.rbPasive.TabIndex = 23;
            this.rbPasive.TabStop = true;
            this.rbPasive.Text = "Pasif";
            this.rbPasive.UseVisualStyleBackColor = true;
            this.rbPasive.CheckedChanged += new System.EventHandler(this.rbPasive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(197, 432);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(98, 31);
            this.rbActive.TabIndex = 22;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 501);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 199);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(197, 259);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(228, 34);
            this.txtType.TabIndex = 25;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(497, 77);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(478, 75);
            this.btnList.TabIndex = 26;
            this.btnList.Text = "Listeleme";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUnList
            // 
            this.btnUnList.Location = new System.Drawing.Point(498, 179);
            this.btnUnList.Name = "btnUnList";
            this.btnUnList.Size = new System.Drawing.Size(478, 75);
            this.btnUnList.TabIndex = 27;
            this.btnUnList.Text = "Pasif Listeleme";
            this.btnUnList.UseVisualStyleBackColor = true;
            this.btnUnList.Click += new System.EventHandler(this.btnUnList_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(478, 75);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(478, 75);
            this.button3.TabIndex = 29;
            this.button3.Text = "Listeleme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 738);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbPasive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.txtPAgeCount);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Book";
            this.Text = "Frm_Book";
            this.Load += new System.EventHandler(this.Frm_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtPAgeCount;
        private System.Windows.Forms.RadioButton rbPasive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUnList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
    }
}