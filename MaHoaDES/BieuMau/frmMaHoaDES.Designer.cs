namespace MaHoaDES.BieuMau
{
    partial class frmMaHoaDES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaHoaDES));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.txtVanBanDich = new System.Windows.Forms.RichTextBox();
            this.txtVanBanNguon = new System.Windows.Forms.RichTextBox();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaHoaVanBan = new System.Windows.Forms.Button();
            this.btnGiaiMaVanBan = new System.Windows.Forms.Button();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.txtFileDich = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileNguon = new System.Windows.Forms.TextBox();
            this.txtKhoaFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaHoaFile = new System.Windows.Forms.Button();
            this.btnGiaiMaFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BoxSecertSharing = new System.Windows.Forms.GroupBox();
            this.btnChiaKhoa = new System.Windows.Forms.Button();
            this.richTextBoxChia = new System.Windows.Forms.RichTextBox();
            this.txtPChia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKChia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGTV2 = new System.Windows.Forms.TextBox();
            this.txtGTA1 = new System.Windows.Forms.TextBox();
            this.txtGTV1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFv2 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtPGhep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFv1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGhepKhoa = new System.Windows.Forms.Button();
            this.txtKhoaKPHexa = new System.Windows.Forms.TextBox();
            this.txtKhoaKP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.BoxTextCrypt.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.BoxSecertSharing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(6, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 61);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến trình";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 22);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxTextCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.btnMaHoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.btnGiaiMaVanBan);
            this.BoxTextCrypt.Location = new System.Drawing.Point(450, 12);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Size = new System.Drawing.Size(432, 268);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "Mã hoá và Giải mã văn bản(Text)";
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.Location = new System.Drawing.Point(43, 127);
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.Size = new System.Drawing.Size(383, 93);
            this.txtVanBanDich.TabIndex = 26;
            this.txtVanBanDich.Text = "";
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.Location = new System.Drawing.Point(43, 18);
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.Size = new System.Drawing.Size(383, 64);
            this.txtVanBanNguon.TabIndex = 26;
            this.txtVanBanNguon.Text = "";
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(43, 88);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(383, 20);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "0123456789ABCDE1";
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kết quả mã hoá và giải mã";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // btnMaHoaVanBan
            // 
            this.btnMaHoaVanBan.Location = new System.Drawing.Point(97, 229);
            this.btnMaHoaVanBan.Name = "btnMaHoaVanBan";
            this.btnMaHoaVanBan.Size = new System.Drawing.Size(101, 25);
            this.btnMaHoaVanBan.TabIndex = 10;
            this.btnMaHoaVanBan.Text = "Mã hoá văn bản";
            this.btnMaHoaVanBan.UseVisualStyleBackColor = true;
            this.btnMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // btnGiaiMaVanBan
            // 
            this.btnGiaiMaVanBan.Location = new System.Drawing.Point(226, 229);
            this.btnGiaiMaVanBan.Name = "btnGiaiMaVanBan";
            this.btnGiaiMaVanBan.Size = new System.Drawing.Size(102, 25);
            this.btnGiaiMaVanBan.TabIndex = 13;
            this.btnGiaiMaVanBan.Text = "Giải mã văn bản";
            this.btnGiaiMaVanBan.UseVisualStyleBackColor = true;
            this.btnGiaiMaVanBan.Click += new System.EventHandler(this.txtGiaiMaVanBan_Click);
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxFileCrypt.Controls.Add(this.groupBox1);
            this.BoxFileCrypt.Controls.Add(this.txtFileDich);
            this.BoxFileCrypt.Controls.Add(this.label9);
            this.BoxFileCrypt.Controls.Add(this.txtFileNguon);
            this.BoxFileCrypt.Controls.Add(this.txtKhoaFile);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.label8);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaFile);
            this.BoxFileCrypt.Controls.Add(this.btnGiaiMaFile);
            this.BoxFileCrypt.Location = new System.Drawing.Point(13, 12);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Size = new System.Drawing.Size(434, 268);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "Mã hoá và giải mã 1 file";
            // 
            // txtFileDich
            // 
            this.txtFileDich.Location = new System.Drawing.Point(71, 44);
            this.txtFileDich.Name = "txtFileDich";
            this.txtFileDich.ReadOnly = true;
            this.txtFileDich.Size = new System.Drawing.Size(313, 20);
            this.txtFileDich.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Đổi tên file";
            // 
            // txtFileNguon
            // 
            this.txtFileNguon.Location = new System.Drawing.Point(71, 15);
            this.txtFileNguon.Name = "txtFileNguon";
            this.txtFileNguon.ReadOnly = true;
            this.txtFileNguon.Size = new System.Drawing.Size(243, 20);
            this.txtFileNguon.TabIndex = 5;
            // 
            // txtKhoaFile
            // 
            this.txtKhoaFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaFile.Location = new System.Drawing.Point(71, 88);
            this.txtKhoaFile.MaxLength = 16;
            this.txtKhoaFile.Name = "txtKhoaFile";
            this.txtKhoaFile.Size = new System.Drawing.Size(314, 20);
            this.txtKhoaFile.TabIndex = 23;
            this.txtKhoaFile.Text = "0123456789ABCDE1";
            this.txtKhoaFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khoá";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(320, 13);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(64, 23);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "Files..";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Location = new System.Drawing.Point(8, 48);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 13);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // btnMaHoaFile
            // 
            this.btnMaHoaFile.Location = new System.Drawing.Point(102, 229);
            this.btnMaHoaFile.Name = "btnMaHoaFile";
            this.btnMaHoaFile.Size = new System.Drawing.Size(89, 25);
            this.btnMaHoaFile.TabIndex = 12;
            this.btnMaHoaFile.Text = "Mã hoá file";
            this.btnMaHoaFile.UseVisualStyleBackColor = true;
            this.btnMaHoaFile.Click += new System.EventHandler(this.btnMaHoaFile_Click);
            // 
            // btnGiaiMaFile
            // 
            this.btnGiaiMaFile.Location = new System.Drawing.Point(225, 229);
            this.btnGiaiMaFile.Name = "btnGiaiMaFile";
            this.btnGiaiMaFile.Size = new System.Drawing.Size(89, 25);
            this.btnGiaiMaFile.TabIndex = 11;
            this.btnGiaiMaFile.Text = "Giải mã file";
            this.btnGiaiMaFile.UseVisualStyleBackColor = true;
            this.btnGiaiMaFile.Click += new System.EventHandler(this.btnGiaiMaFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BoxSecertSharing
            // 
            this.BoxSecertSharing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxSecertSharing.Controls.Add(this.btnChiaKhoa);
            this.BoxSecertSharing.Controls.Add(this.richTextBoxChia);
            this.BoxSecertSharing.Controls.Add(this.txtPChia);
            this.BoxSecertSharing.Controls.Add(this.label16);
            this.BoxSecertSharing.Controls.Add(this.label18);
            this.BoxSecertSharing.Controls.Add(this.label15);
            this.BoxSecertSharing.Controls.Add(this.label7);
            this.BoxSecertSharing.Controls.Add(this.txtKChia);
            this.BoxSecertSharing.Controls.Add(this.label6);
            this.BoxSecertSharing.Controls.Add(this.txtGTV2);
            this.BoxSecertSharing.Controls.Add(this.txtGTA1);
            this.BoxSecertSharing.Controls.Add(this.txtGTV1);
            this.BoxSecertSharing.Location = new System.Drawing.Point(13, 298);
            this.BoxSecertSharing.Name = "BoxSecertSharing";
            this.BoxSecertSharing.Size = new System.Drawing.Size(434, 259);
            this.BoxSecertSharing.TabIndex = 27;
            this.BoxSecertSharing.TabStop = false;
            this.BoxSecertSharing.Text = "Chia Sẻ Khóa";
            // 
            // btnChiaKhoa
            // 
            this.btnChiaKhoa.Location = new System.Drawing.Point(162, 152);
            this.btnChiaKhoa.Name = "btnChiaKhoa";
            this.btnChiaKhoa.Size = new System.Drawing.Size(89, 25);
            this.btnChiaKhoa.TabIndex = 28;
            this.btnChiaKhoa.Text = "Chia khóa";
            this.btnChiaKhoa.UseVisualStyleBackColor = true;
            this.btnChiaKhoa.Click += new System.EventHandler(this.btnChiaKhoa_Click);
            // 
            // richTextBoxChia
            // 
            this.richTextBoxChia.Location = new System.Drawing.Point(15, 183);
            this.richTextBoxChia.Name = "richTextBoxChia";
            this.richTextBoxChia.Size = new System.Drawing.Size(395, 58);
            this.richTextBoxChia.TabIndex = 26;
            this.richTextBoxChia.Text = "";
            // 
            // txtPChia
            // 
            this.txtPChia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPChia.Location = new System.Drawing.Point(71, 45);
            this.txtPChia.MaxLength = 20;
            this.txtPChia.Name = "txtPChia";
            this.txtPChia.Size = new System.Drawing.Size(314, 20);
            this.txtPChia.TabIndex = 31;
            this.txtPChia.Text = "12764787846358441471";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "V2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(205, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "a1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "V1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Số p";
            // 
            // txtKChia
            // 
            this.txtKChia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKChia.Location = new System.Drawing.Point(71, 19);
            this.txtKChia.MaxLength = 20;
            this.txtKChia.Name = "txtKChia";
            this.txtKChia.Size = new System.Drawing.Size(314, 20);
            this.txtKChia.TabIndex = 29;
            this.txtKChia.Text = "12379813738877118345";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Khoá";
            // 
            // txtGTV2
            // 
            this.txtGTV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGTV2.Location = new System.Drawing.Point(34, 100);
            this.txtGTV2.MaxLength = 20;
            this.txtGTV2.Name = "txtGTV2";
            this.txtGTV2.Size = new System.Drawing.Size(166, 20);
            this.txtGTV2.TabIndex = 29;
            this.txtGTV2.Text = "111350135012507";
            // 
            // txtGTA1
            // 
            this.txtGTA1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGTA1.Location = new System.Drawing.Point(231, 78);
            this.txtGTA1.MaxLength = 20;
            this.txtGTA1.Name = "txtGTA1";
            this.txtGTA1.Size = new System.Drawing.Size(154, 20);
            this.txtGTA1.TabIndex = 29;
            this.txtGTA1.Text = "207244959855905";
            // 
            // txtGTV1
            // 
            this.txtGTV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGTV1.Location = new System.Drawing.Point(34, 75);
            this.txtGTV1.MaxLength = 20;
            this.txtGTV1.Name = "txtGTV1";
            this.txtGTV1.Size = new System.Drawing.Size(166, 20);
            this.txtGTV1.TabIndex = 29;
            this.txtGTV1.Text = "151595058245452";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtFv2);
            this.groupBox2.Controls.Add(this.txtV2);
            this.groupBox2.Controls.Add(this.txtPGhep);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFv1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnGhepKhoa);
            this.groupBox2.Controls.Add(this.txtKhoaKPHexa);
            this.groupBox2.Controls.Add(this.txtKhoaKP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtV1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(450, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 259);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghép khóa";
            // 
            // txtFv2
            // 
            this.txtFv2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFv2.Location = new System.Drawing.Point(244, 81);
            this.txtFv2.MaxLength = 20;
            this.txtFv2.Name = "txtFv2";
            this.txtFv2.Size = new System.Drawing.Size(166, 20);
            this.txtFv2.TabIndex = 35;
            this.txtFv2.Text = "1331512647268863473";
            // 
            // txtV2
            // 
            this.txtV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtV2.Location = new System.Drawing.Point(71, 81);
            this.txtV2.MaxLength = 20;
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(166, 20);
            this.txtV2.TabIndex = 34;
            this.txtV2.Text = "111350135012507";
            // 
            // txtPGhep
            // 
            this.txtPGhep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPGhep.Location = new System.Drawing.Point(71, 23);
            this.txtPGhep.MaxLength = 20;
            this.txtPGhep.Name = "txtPGhep";
            this.txtPGhep.Size = new System.Drawing.Size(339, 20);
            this.txtPGhep.TabIndex = 33;
            this.txtPGhep.Text = "12764787846358441471";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Số p";
            // 
            // txtFv1
            // 
            this.txtFv1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFv1.Location = new System.Drawing.Point(244, 62);
            this.txtFv1.MaxLength = 20;
            this.txtFv1.Name = "txtFv1";
            this.txtFv1.Size = new System.Drawing.Size(166, 20);
            this.txtFv1.TabIndex = 32;
            this.txtFv1.Text = "11576322953334095184";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "HEX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Khoá";
            // 
            // btnGhepKhoa
            // 
            this.btnGhepKhoa.Location = new System.Drawing.Point(182, 126);
            this.btnGhepKhoa.Name = "btnGhepKhoa";
            this.btnGhepKhoa.Size = new System.Drawing.Size(105, 25);
            this.btnGhepKhoa.TabIndex = 28;
            this.btnGhepKhoa.Text = "Khôi phục khóa";
            this.btnGhepKhoa.UseVisualStyleBackColor = true;
            this.btnGhepKhoa.Click += new System.EventHandler(this.btnGhepKhoa_Click);
            // 
            // txtKhoaKPHexa
            // 
            this.txtKhoaKPHexa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaKPHexa.Location = new System.Drawing.Point(71, 195);
            this.txtKhoaKPHexa.MaxLength = 16;
            this.txtKhoaKPHexa.Name = "txtKhoaKPHexa";
            this.txtKhoaKPHexa.Size = new System.Drawing.Size(339, 20);
            this.txtKhoaKPHexa.TabIndex = 31;
            // 
            // txtKhoaKP
            // 
            this.txtKhoaKP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaKP.Location = new System.Drawing.Point(71, 167);
            this.txtKhoaKP.MaxLength = 20;
            this.txtKhoaKP.Name = "txtKhoaKP";
            this.txtKhoaKP.Size = new System.Drawing.Size(339, 20);
            this.txtKhoaKP.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "(v2, f(v2))";
            // 
            // txtV1
            // 
            this.txtV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtV1.Location = new System.Drawing.Point(71, 62);
            this.txtV1.MaxLength = 20;
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(166, 20);
            this.txtV1.TabIndex = 29;
            this.txtV1.Text = "151595058245452";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "(v1, f(v1))";
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BoxSecertSharing);
            this.Controls.Add(this.BoxTextCrypt);
            this.Controls.Add(this.BoxFileCrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaHoaDES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Mã hóa DES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaHoaDES_FormClosing);
            this.Load += new System.EventHandler(this.frmMaHoaDES_Load);
            this.groupBox1.ResumeLayout(false);
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.BoxSecertSharing.ResumeLayout(false);
            this.BoxSecertSharing.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaHoaVanBan;
        private System.Windows.Forms.Button btnGiaiMaVanBan;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.TextBox txtFileDich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFileNguon;
        private System.Windows.Forms.TextBox txtKhoaFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaHoaFile;
        private System.Windows.Forms.Button btnGiaiMaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtVanBanDich;
        private System.Windows.Forms.RichTextBox txtVanBanNguon;
        private System.Windows.Forms.GroupBox BoxSecertSharing;
        private System.Windows.Forms.Button btnChiaKhoa;
        private System.Windows.Forms.RichTextBox richTextBoxChia;
        private System.Windows.Forms.TextBox txtPChia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKChia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFv2;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtPGhep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFv1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGhepKhoa;
        private System.Windows.Forms.TextBox txtKhoaKPHexa;
        private System.Windows.Forms.TextBox txtKhoaKP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGTV2;
        private System.Windows.Forms.TextBox txtGTA1;
        private System.Windows.Forms.TextBox txtGTV1;
    }
}