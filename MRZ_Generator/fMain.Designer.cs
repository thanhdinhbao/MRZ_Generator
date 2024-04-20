
namespace MRZ_Generator
{
    partial class Form1
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFName.Location = new System.Drawing.Point(105, 34);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(185, 20);
            this.txtFName.TabIndex = 1;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Hà Nội",
            "Hà Giang",
            "Cao Bằng",
            "Bắc Kạn",
            "Tuyên Quang",
            "Lào Cai",
            "Điện Biên",
            "Lai Châu",
            "Sơn La",
            "Yên Bái",
            "Hòa Bình",
            "Thái Nguyên",
            "Lạng Sơn",
            "Quảng Ninh",
            "Bắc Giang",
            "Phú Thọ",
            "Vĩnh Phúc",
            "Bắc Ninh",
            "Hải Dương",
            "Hải Phòng",
            "Hưng Yên",
            "Thái Bình",
            "Hà Nam",
            "Nam Định",
            "Ninh Bình",
            "Thanh Hóa",
            "Nghệ An",
            "Hà Tĩnh",
            "Quảng Bình",
            "Quảng Trị",
            "Thừa Thiên Huế",
            "Đà Nẵng",
            "Quảng Nam",
            "Quảng Ngãi",
            "Bình Định",
            "Phú Yên",
            "Khánh Hòa",
            "Ninh Thuận",
            "Bình Thuận",
            "Kon Tum",
            "Gia Lai",
            "Đắk Lắk",
            "Đắk Nông",
            "Lâm Đồng",
            "Bình Phước",
            "Tây Ninh",
            "Bình Dương",
            "Đồng Nai",
            "Bà Rịa - Vũng Tàu",
            "Hồ Chí Minh",
            "Long An",
            "Tiền Giang",
            "Bến Tre",
            "Trà Vinh",
            "Vĩnh Long",
            "Đồng Tháp",
            "An Giang",
            "Kiên Giang",
            "Cần Thơ",
            "Hậu Giang",
            "Sóc Trăng",
            "Bạc Liêu",
            "Cà Mau"});
            this.cbProvince.Location = new System.Drawing.Point(105, 127);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(185, 21);
            this.cbProvince.TabIndex = 3;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(128, 174);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(219, 174);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 5;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 325);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 8;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(353, 108);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(87, 61);
            this.btnGen.TabIndex = 9;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(27, 370);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(350, 163);
            this.txtResult.TabIndex = 11;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(383, 430);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 34);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày hết hạn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID:";
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(105, 218);
            this.dtDOB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(176, 20);
            this.dtDOB.TabIndex = 6;
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCap.Location = new System.Drawing.Point(105, 269);
            this.dtNgayCap.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgayCap.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(175, 20);
            this.dtNgayCap.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 28;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tên:";
            // 
            // txtLName
            // 
            this.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLName.Location = new System.Drawing.Point(105, 76);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(185, 20);
            this.txtLName.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 46);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 568);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtNgayCap);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRZ Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Button btnExit;
    }
}

