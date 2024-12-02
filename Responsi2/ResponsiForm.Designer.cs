namespace Responsi2
{
    partial class ResponsiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponsiForm));
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            label1 = new Label();
            label2 = new Label();
            tbNamaKaryawan = new TextBox();
            listBox1 = new ListBox();
            cbDepKaryawan = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            listBox2 = new ListBox();
            label3 = new Label();
            cbJabKaryawan = new ComboBox();
            label4 = new Label();
            tbGaji = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Arial", 11F);
            lblLogo.Location = new Point(77, 33);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(35, 17);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "logo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F);
            label1.Location = new Point(8, 86);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 2;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F);
            label2.Location = new Point(8, 114);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 3;
            label2.Text = "Dep. Karyawan   : ";
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.BorderStyle = BorderStyle.FixedSingle;
            tbNamaKaryawan.Font = new Font("Arial", 11F);
            tbNamaKaryawan.Location = new Point(142, 82);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(171, 24);
            tbNamaKaryawan.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "ID Departemen:", "HR : HR", "ENG : Engineer", "DEV : Developer", "PM : Product Manager", "FIN : Finance" });
            listBox1.Location = new Point(349, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(142, 109);
            listBox1.TabIndex = 5;
            // 
            // cbDepKaryawan
            // 
            cbDepKaryawan.FormattingEnabled = true;
            cbDepKaryawan.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepKaryawan.Location = new Point(142, 112);
            cbDepKaryawan.Name = "cbDepKaryawan";
            cbDepKaryawan.Size = new Size(171, 23);
            cbDepKaryawan.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveBorder;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Arial", 11F);
            btnInsert.Location = new Point(8, 216);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(111, 31);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveBorder;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Arial", 11F);
            btnEdit.Location = new Point(202, 216);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 31);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 11F);
            btnDelete.Location = new Point(367, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(7, 255);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(485, 253);
            dgvData.TabIndex = 10;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "", "ID Jabatan:", "KT : Ketua Tim", "S : Senior", "J : Junior" });
            listBox2.Location = new Point(349, 122);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(143, 79);
            listBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F);
            label3.Location = new Point(8, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 12;
            label3.Text = "Jab. Karyawan    : ";
            // 
            // cbJabKaryawan
            // 
            cbJabKaryawan.FormattingEnabled = true;
            cbJabKaryawan.Items.AddRange(new object[] { "KT", "S", "J" });
            cbJabKaryawan.Location = new Point(142, 146);
            cbJabKaryawan.Name = "cbJabKaryawan";
            cbJabKaryawan.Size = new Size(171, 23);
            cbJabKaryawan.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F);
            label4.Location = new Point(7, 175);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 14;
            label4.Text = "Gaji                      :";
            // 
            // tbGaji
            // 
            tbGaji.BorderStyle = BorderStyle.FixedSingle;
            tbGaji.Font = new Font("Arial", 11F);
            tbGaji.Location = new Point(142, 175);
            tbGaji.Name = "tbGaji";
            tbGaji.Size = new Size(171, 24);
            tbGaji.TabIndex = 15;
            // 
            // ResponsiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 516);
            Controls.Add(tbGaji);
            Controls.Add(label4);
            Controls.Add(cbJabKaryawan);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDepKaryawan);
            Controls.Add(listBox1);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLogo);
            Controls.Add(pictureBox1);
            Name = "ResponsiForm";
            Text = "Responsi";
            Load += ResponsiForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogo;
        private Label label1;
        private Label label2;
        private TextBox tbNamaKaryawan;
        private ListBox listBox1;
        private ComboBox cbDepKaryawan;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private ListBox listBox2;
        private Label label3;
        private ComboBox cbJabKaryawan;
        private Label label4;
        private TextBox tbGaji;
    }
}
