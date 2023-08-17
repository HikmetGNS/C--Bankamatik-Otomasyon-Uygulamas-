namespace WindowsFormsApp7
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new WindowsFormsApp7.BankDataSet();
            this.memberTableAdapter = new WindowsFormsApp7.BankDataSetTableAdapters.MemberTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn10Tl = new System.Windows.Forms.Button();
            this.btn500Tl = new System.Windows.Forms.Button();
            this.btn100Tl = new System.Windows.Forms.Button();
            this.btn200Tl = new System.Windows.Forms.Button();
            this.btn50Tl = new System.Windows.Forms.Button();
            this.btn20Tl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.txtParaCek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtHavaleTutar = new System.Windows.Forms.TextBox();
            this.txtHavaleId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.btnFaturaOde = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParaYatir = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btn10Yatir = new System.Windows.Forms.Button();
            this.btn20Yatir = new System.Windows.Forms.Button();
            this.btn50Yatir = new System.Windows.Forms.Button();
            this.btn100Yatir = new System.Windows.Forms.Button();
            this.btn200Yatir = new System.Windows.Forms.Button();
            this.btn500Yatir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(365, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 92);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "create_date";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.txtNewPhoneNumber);
            this.groupBox1.Controls.Add(this.txtNewSurname);
            this.groupBox1.Controls.Add(this.txtNewName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(796, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 461);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(194, 251);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(131, 206);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(138, 20);
            this.txtNewPassword.TabIndex = 7;
            // 
            // txtNewPhoneNumber
            // 
            this.txtNewPhoneNumber.Location = new System.Drawing.Point(131, 164);
            this.txtNewPhoneNumber.Name = "txtNewPhoneNumber";
            this.txtNewPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.txtNewPhoneNumber.TabIndex = 6;
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.Location = new System.Drawing.Point(131, 119);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(138, 20);
            this.txtNewSurname.TabIndex = 5;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(131, 73);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(138, 20);
            this.txtNewName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Yeni Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yeni Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yeni Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni İsim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn10Tl);
            this.groupBox2.Controls.Add(this.btn500Tl);
            this.groupBox2.Controls.Add(this.btn100Tl);
            this.groupBox2.Controls.Add(this.btn200Tl);
            this.groupBox2.Controls.Add(this.btn50Tl);
            this.groupBox2.Controls.Add(this.btn20Tl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnParaCek);
            this.groupBox2.Controls.Add(this.txtParaCek);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 461);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Çek";
            // 
            // btn10Tl
            // 
            this.btn10Tl.Location = new System.Drawing.Point(44, 237);
            this.btn10Tl.Name = "btn10Tl";
            this.btn10Tl.Size = new System.Drawing.Size(115, 50);
            this.btn10Tl.TabIndex = 19;
            this.btn10Tl.Text = "10 TL";
            this.btn10Tl.UseVisualStyleBackColor = true;
            this.btn10Tl.Click += new System.EventHandler(this.btn10Tl_Click);
            // 
            // btn500Tl
            // 
            this.btn500Tl.Location = new System.Drawing.Point(291, 378);
            this.btn500Tl.Name = "btn500Tl";
            this.btn500Tl.Size = new System.Drawing.Size(115, 50);
            this.btn500Tl.TabIndex = 18;
            this.btn500Tl.Text = "500 TL";
            this.btn500Tl.UseVisualStyleBackColor = true;
            this.btn500Tl.Click += new System.EventHandler(this.btn500Tl_Click);
            // 
            // btn100Tl
            // 
            this.btn100Tl.Location = new System.Drawing.Point(291, 237);
            this.btn100Tl.Name = "btn100Tl";
            this.btn100Tl.Size = new System.Drawing.Size(115, 50);
            this.btn100Tl.TabIndex = 17;
            this.btn100Tl.Text = "100 TL";
            this.btn100Tl.UseVisualStyleBackColor = true;
            this.btn100Tl.Click += new System.EventHandler(this.btn100Tl_Click);
            // 
            // btn200Tl
            // 
            this.btn200Tl.Location = new System.Drawing.Point(291, 306);
            this.btn200Tl.Name = "btn200Tl";
            this.btn200Tl.Size = new System.Drawing.Size(115, 49);
            this.btn200Tl.TabIndex = 16;
            this.btn200Tl.Text = "200 TL";
            this.btn200Tl.UseVisualStyleBackColor = true;
            this.btn200Tl.Click += new System.EventHandler(this.btn200Tl_Click);
            // 
            // btn50Tl
            // 
            this.btn50Tl.Location = new System.Drawing.Point(44, 378);
            this.btn50Tl.Name = "btn50Tl";
            this.btn50Tl.Size = new System.Drawing.Size(115, 50);
            this.btn50Tl.TabIndex = 15;
            this.btn50Tl.Text = "50 TL";
            this.btn50Tl.UseVisualStyleBackColor = true;
            this.btn50Tl.Click += new System.EventHandler(this.btn50Tl_Click);
            // 
            // btn20Tl
            // 
            this.btn20Tl.Location = new System.Drawing.Point(44, 306);
            this.btn20Tl.Name = "btn20Tl";
            this.btn20Tl.Size = new System.Drawing.Size(115, 49);
            this.btn20Tl.TabIndex = 14;
            this.btn20Tl.Text = "20 TL";
            this.btn20Tl.UseVisualStyleBackColor = true;
            this.btn20Tl.Click += new System.EventHandler(this.btn20Tl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hızlı Çek";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(216, 109);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(75, 23);
            this.btnParaCek.TabIndex = 12;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // txtParaCek
            // 
            this.txtParaCek.Location = new System.Drawing.Point(75, 73);
            this.txtParaCek.Name = "txtParaCek";
            this.txtParaCek.Size = new System.Drawing.Size(216, 20);
            this.txtParaCek.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Çekilecek Tutar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGonder);
            this.groupBox3.Controls.Add(this.txtHavaleTutar);
            this.groupBox3.Controls.Add(this.txtHavaleId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 461);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Havale";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(126, 206);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 15;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtHavaleTutar
            // 
            this.txtHavaleTutar.Location = new System.Drawing.Point(18, 164);
            this.txtHavaleTutar.Name = "txtHavaleTutar";
            this.txtHavaleTutar.Size = new System.Drawing.Size(183, 20);
            this.txtHavaleTutar.TabIndex = 14;
            // 
            // txtHavaleId
            // 
            this.txtHavaleId.Location = new System.Drawing.Point(18, 85);
            this.txtHavaleId.Name = "txtHavaleId";
            this.txtHavaleId.Size = new System.Drawing.Size(183, 20);
            this.txtHavaleId.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Havale Yapılacak Kişinin ID\'si:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gönderilecek Tutar:";
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Location = new System.Drawing.Point(1281, 505);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(136, 73);
            this.btnHakkinda.TabIndex = 16;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnFaturaOde
            // 
            this.btnFaturaOde.Location = new System.Drawing.Point(12, 505);
            this.btnFaturaOde.Name = "btnFaturaOde";
            this.btnFaturaOde.Size = new System.Drawing.Size(136, 73);
            this.btnFaturaOde.TabIndex = 17;
            this.btnFaturaOde.Text = "Fatura Öde";
            this.btnFaturaOde.UseVisualStyleBackColor = true;
            this.btnFaturaOde.Click += new System.EventHandler(this.btnFaturaOde_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn500Yatir);
            this.groupBox4.Controls.Add(this.btn200Yatir);
            this.groupBox4.Controls.Add(this.btn100Yatir);
            this.groupBox4.Controls.Add(this.btn50Yatir);
            this.groupBox4.Controls.Add(this.btn20Yatir);
            this.groupBox4.Controls.Add(this.btn10Yatir);
            this.groupBox4.Controls.Add(this.btnParaYatir);
            this.groupBox4.Controls.Add(this.txtParaYatir);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(1109, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 461);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Para Yatır";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Yatırılacak Tutar";
            // 
            // txtParaYatir
            // 
            this.txtParaYatir.Location = new System.Drawing.Point(68, 73);
            this.txtParaYatir.Name = "txtParaYatir";
            this.txtParaYatir.Size = new System.Drawing.Size(216, 20);
            this.txtParaYatir.TabIndex = 20;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(209, 109);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(75, 23);
            this.btnParaYatir.TabIndex = 21;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btn10Yatir
            // 
            this.btn10Yatir.Location = new System.Drawing.Point(16, 237);
            this.btn10Yatir.Name = "btn10Yatir";
            this.btn10Yatir.Size = new System.Drawing.Size(115, 50);
            this.btn10Yatir.TabIndex = 22;
            this.btn10Yatir.Text = "10 TL";
            this.btn10Yatir.UseVisualStyleBackColor = true;
            this.btn10Yatir.Click += new System.EventHandler(this.btn10Yatir_Click);
            // 
            // btn20Yatir
            // 
            this.btn20Yatir.Location = new System.Drawing.Point(16, 305);
            this.btn20Yatir.Name = "btn20Yatir";
            this.btn20Yatir.Size = new System.Drawing.Size(115, 50);
            this.btn20Yatir.TabIndex = 23;
            this.btn20Yatir.Text = "20 TL";
            this.btn20Yatir.UseVisualStyleBackColor = true;
            this.btn20Yatir.Click += new System.EventHandler(this.btn20Yatir_Click);
            // 
            // btn50Yatir
            // 
            this.btn50Yatir.Location = new System.Drawing.Point(16, 378);
            this.btn50Yatir.Name = "btn50Yatir";
            this.btn50Yatir.Size = new System.Drawing.Size(115, 50);
            this.btn50Yatir.TabIndex = 24;
            this.btn50Yatir.Text = "50 TL";
            this.btn50Yatir.UseVisualStyleBackColor = true;
            this.btn50Yatir.Click += new System.EventHandler(this.btn50Yatir_Click);
            // 
            // btn100Yatir
            // 
            this.btn100Yatir.Location = new System.Drawing.Point(187, 237);
            this.btn100Yatir.Name = "btn100Yatir";
            this.btn100Yatir.Size = new System.Drawing.Size(115, 50);
            this.btn100Yatir.TabIndex = 25;
            this.btn100Yatir.Text = "100 TL";
            this.btn100Yatir.UseVisualStyleBackColor = true;
            this.btn100Yatir.Click += new System.EventHandler(this.btn100Yatir_Click);
            // 
            // btn200Yatir
            // 
            this.btn200Yatir.Location = new System.Drawing.Point(187, 306);
            this.btn200Yatir.Name = "btn200Yatir";
            this.btn200Yatir.Size = new System.Drawing.Size(115, 49);
            this.btn200Yatir.TabIndex = 26;
            this.btn200Yatir.Text = "200 TL";
            this.btn200Yatir.UseVisualStyleBackColor = true;
            this.btn200Yatir.Click += new System.EventHandler(this.btn200Yatir_Click);
            // 
            // btn500Yatir
            // 
            this.btn500Yatir.Location = new System.Drawing.Point(187, 378);
            this.btn500Yatir.Name = "btn500Yatir";
            this.btn500Yatir.Size = new System.Drawing.Size(115, 50);
            this.btn500Yatir.TabIndex = 27;
            this.btn500Yatir.Text = "500 TL";
            this.btn500Yatir.UseVisualStyleBackColor = true;
            this.btn500Yatir.Click += new System.EventHandler(this.btn500Yatir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.btnFaturaOde);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private BankDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPhoneNumber;
        private System.Windows.Forms.TextBox txtNewSurname;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.TextBox txtParaCek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn500Tl;
        private System.Windows.Forms.Button btn100Tl;
        private System.Windows.Forms.Button btn200Tl;
        private System.Windows.Forms.Button btn50Tl;
        private System.Windows.Forms.Button btn20Tl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn10Tl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHavaleTutar;
        private System.Windows.Forms.TextBox txtHavaleId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Button btnFaturaOde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn500Yatir;
        private System.Windows.Forms.Button btn200Yatir;
        private System.Windows.Forms.Button btn100Yatir;
        private System.Windows.Forms.Button btn50Yatir;
        private System.Windows.Forms.Button btn20Yatir;
        private System.Windows.Forms.Button btn10Yatir;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.TextBox txtParaYatir;
        private System.Windows.Forms.Label label11;
    }
}