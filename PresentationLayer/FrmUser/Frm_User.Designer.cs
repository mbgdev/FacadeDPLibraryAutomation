namespace PresentationLayer.FrmUser
{
    partial class Frm_User
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnList = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbPasive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(478, 75);
            this.button3.TabIndex = 49;
            this.button3.Text = "Listeleme";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(478, 75);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnList
            // 
            this.btnUnList.Location = new System.Drawing.Point(544, 133);
            this.btnUnList.Name = "btnUnList";
            this.btnUnList.Size = new System.Drawing.Size(478, 75);
            this.btnUnList.TabIndex = 47;
            this.btnUnList.Text = "Pasif Listeleme";
            this.btnUnList.UseVisualStyleBackColor = true;
            this.btnUnList.Click += new System.EventHandler(this.btnUnList_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(544, 41);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(478, 75);
            this.btnList.TabIndex = 46;
            this.btnList.Text = "Listeleme";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(273, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 34);
            this.txtPassword.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 577);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 199);
            this.dataGridView1.TabIndex = 44;
            // 
            // rbPasive
            // 
            this.rbPasive.AutoSize = true;
            this.rbPasive.Location = new System.Drawing.Point(403, 467);
            this.rbPasive.Name = "rbPasive";
            this.rbPasive.Size = new System.Drawing.Size(98, 31);
            this.rbPasive.TabIndex = 43;
            this.rbPasive.TabStop = true;
            this.rbPasive.Text = "Pasif";
            this.rbPasive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(273, 467);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(98, 31);
            this.rbActive.TabIndex = 42;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(272, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 34);
            this.txtEmail.TabIndex = 41;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(270, 232);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(228, 34);
            this.txtSurname.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 34);
            this.txtName.TabIndex = 38;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(274, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(228, 34);
            this.txtId.TabIndex = 37;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(162, 467);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Durum:";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(136, 348);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(116, 27);
            this.lblPageCount.TabIndex = 34;
            this.lblPageCount.Text = "E-Posta:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(162, 287);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 27);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "Şifre:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(16, 235);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(233, 27);
            this.lblAuthor.TabIndex = 32;
            this.lblAuthor.Text = "Kullanıcı Soyadı:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 27);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Kullanıcı Adı:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(72, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(181, 27);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "Kullanıcı Id:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(273, 82);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(228, 34);
            this.txtNo.TabIndex = 51;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(71, 85);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(181, 27);
            this.lblNo.TabIndex = 50;
            this.lblNo.Text = "Kullanıcı No:";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(270, 126);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(228, 34);
            this.txtRole.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kullanıcı Role:";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(272, 401);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(228, 34);
            this.txtAdress.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 54;
            this.label2.Text = "Adres:";
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 826);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbPasive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_User";
            this.Text = "Frm_User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbPasive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label2;
    }
}