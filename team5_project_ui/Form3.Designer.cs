
namespace team5_project_ui
{
    partial class regiter_patient
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
            this.Patient_List = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.Emergency_Triage = new System.Windows.Forms.Label();
            this.Guardian = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Birth_Date = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.Patient_Name = new System.Windows.Forms.Label();
            this.Patient_Code = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Accident_Information = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_code = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_birth = new System.Windows.Forms.TextBox();
            this.p_phonenumber = new System.Windows.Forms.TextBox();
            this.p_address = new System.Windows.Forms.TextBox();
            this.p_protector = new System.Windows.Forms.TextBox();
            this.p_sex = new System.Windows.Forms.TextBox();
            this.p_register = new System.Windows.Forms.TextBox();
            this.d_code = new System.Windows.Forms.TextBox();
            this.p_accident = new System.Windows.Forms.TextBox();
            this.Patient_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Patient_List
            // 
            this.Patient_List.Controls.Add(this.dataGridView1);
            this.Patient_List.Location = new System.Drawing.Point(56, 90);
            this.Patient_List.Name = "Patient_List";
            this.Patient_List.Size = new System.Drawing.Size(756, 567);
            this.Patient_List.TabIndex = 1;
            this.Patient_List.TabStop = false;
            this.Patient_List.Text = "환자 목록";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(756, 524);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(876, 619);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(88, 30);
            this.Add.TabIndex = 48;
            this.Add.Text = "추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(892, 467);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(37, 15);
            this.Gender.TabIndex = 45;
            this.Gender.Text = "성별";
            // 
            // Emergency_Triage
            // 
            this.Emergency_Triage.AutoSize = true;
            this.Emergency_Triage.Location = new System.Drawing.Point(892, 410);
            this.Emergency_Triage.Name = "Emergency_Triage";
            this.Emergency_Triage.Size = new System.Drawing.Size(67, 15);
            this.Emergency_Triage.TabIndex = 41;
            this.Emergency_Triage.Text = "사고정보";
            // 
            // Guardian
            // 
            this.Guardian.AutoSize = true;
            this.Guardian.Location = new System.Drawing.Point(892, 358);
            this.Guardian.Name = "Guardian";
            this.Guardian.Size = new System.Drawing.Size(52, 15);
            this.Guardian.TabIndex = 39;
            this.Guardian.Text = "보호자";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(892, 308);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(37, 15);
            this.Address.TabIndex = 37;
            this.Address.Text = "주소";
            // 
            // Birth_Date
            // 
            this.Birth_Date.AutoSize = true;
            this.Birth_Date.Location = new System.Drawing.Point(892, 258);
            this.Birth_Date.Name = "Birth_Date";
            this.Birth_Date.Size = new System.Drawing.Size(67, 15);
            this.Birth_Date.TabIndex = 36;
            this.Birth_Date.Text = "전화번호";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(892, 204);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(67, 15);
            this.Tel.TabIndex = 35;
            this.Tel.Text = "생년월일";
            // 
            // Patient_Name
            // 
            this.Patient_Name.AutoSize = true;
            this.Patient_Name.Location = new System.Drawing.Point(892, 152);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Size = new System.Drawing.Size(72, 15);
            this.Patient_Name.TabIndex = 33;
            this.Patient_Name.Text = "환자 이름";
            // 
            // Patient_Code
            // 
            this.Patient_Code.AutoSize = true;
            this.Patient_Code.Location = new System.Drawing.Point(892, 103);
            this.Patient_Code.Name = "Patient_Code";
            this.Patient_Code.Size = new System.Drawing.Size(72, 15);
            this.Patient_Code.TabIndex = 31;
            this.Patient_Code.Text = "환자 코드";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::team5_project_ui.Properties.Resources.sah_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 81);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(985, 619);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(88, 30);
            this.Update.TabIndex = 56;
            this.Update.Text = "수정";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1094, 619);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 30);
            this.Delete.TabIndex = 57;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accident_Information
            // 
            this.Accident_Information.AutoSize = true;
            this.Accident_Information.Location = new System.Drawing.Point(890, 517);
            this.Accident_Information.Name = "Accident_Information";
            this.Accident_Information.Size = new System.Drawing.Size(67, 15);
            this.Accident_Information.TabIndex = 58;
            this.Accident_Information.Text = "등록날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "담당의사";
            // 
            // p_code
            // 
            this.p_code.Location = new System.Drawing.Point(988, 100);
            this.p_code.Name = "p_code";
            this.p_code.Size = new System.Drawing.Size(194, 25);
            this.p_code.TabIndex = 61;
            this.p_code.TextChanged += new System.EventHandler(this.p_code_TextChanged);
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(988, 149);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(194, 25);
            this.p_name.TabIndex = 62;
            this.p_name.TextChanged += new System.EventHandler(this.p_name_TextChanged);
            // 
            // p_birth
            // 
            this.p_birth.Location = new System.Drawing.Point(988, 201);
            this.p_birth.Name = "p_birth";
            this.p_birth.Size = new System.Drawing.Size(194, 25);
            this.p_birth.TabIndex = 63;
            this.p_birth.TextChanged += new System.EventHandler(this.p_birth_TextChanged);
            // 
            // p_phonenumber
            // 
            this.p_phonenumber.Location = new System.Drawing.Point(988, 255);
            this.p_phonenumber.Name = "p_phonenumber";
            this.p_phonenumber.Size = new System.Drawing.Size(194, 25);
            this.p_phonenumber.TabIndex = 64;
            this.p_phonenumber.TextChanged += new System.EventHandler(this.p_phonenumber_TextChanged);
            // 
            // p_address
            // 
            this.p_address.Location = new System.Drawing.Point(988, 305);
            this.p_address.Name = "p_address";
            this.p_address.Size = new System.Drawing.Size(194, 25);
            this.p_address.TabIndex = 65;
            this.p_address.TextChanged += new System.EventHandler(this.p_address_TextChanged);
            // 
            // p_protector
            // 
            this.p_protector.Location = new System.Drawing.Point(988, 355);
            this.p_protector.Name = "p_protector";
            this.p_protector.Size = new System.Drawing.Size(194, 25);
            this.p_protector.TabIndex = 66;
            this.p_protector.TextChanged += new System.EventHandler(this.p_protector_TextChanged);
            // 
            // p_sex
            // 
            this.p_sex.Location = new System.Drawing.Point(988, 464);
            this.p_sex.Name = "p_sex";
            this.p_sex.Size = new System.Drawing.Size(194, 25);
            this.p_sex.TabIndex = 68;
            this.p_sex.TextChanged += new System.EventHandler(this.p_sex_TextChanged);
            // 
            // p_register
            // 
            this.p_register.Location = new System.Drawing.Point(988, 514);
            this.p_register.Name = "p_register";
            this.p_register.Size = new System.Drawing.Size(194, 25);
            this.p_register.TabIndex = 69;
            this.p_register.TextChanged += new System.EventHandler(this.p_register_TextChanged);
            // 
            // d_code
            // 
            this.d_code.Location = new System.Drawing.Point(988, 565);
            this.d_code.Name = "d_code";
            this.d_code.Size = new System.Drawing.Size(194, 25);
            this.d_code.TabIndex = 70;
            this.d_code.TextChanged += new System.EventHandler(this.d_code_TextChanged);
            // 
            // p_accident
            // 
            this.p_accident.Location = new System.Drawing.Point(988, 407);
            this.p_accident.Name = "p_accident";
            this.p_accident.Size = new System.Drawing.Size(194, 25);
            this.p_accident.TabIndex = 71;
            this.p_accident.TextChanged += new System.EventHandler(this.p_accident_TextChanged);
            // 
            // regiter_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.p_accident);
            this.Controls.Add(this.d_code);
            this.Controls.Add(this.p_register);
            this.Controls.Add(this.p_sex);
            this.Controls.Add(this.p_protector);
            this.Controls.Add(this.p_address);
            this.Controls.Add(this.p_phonenumber);
            this.Controls.Add(this.p_birth);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Accident_Information);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Emergency_Triage);
            this.Controls.Add(this.Guardian);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Birth_Date);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Patient_Name);
            this.Controls.Add(this.Patient_Code);
            this.Controls.Add(this.Patient_List);
            this.Name = "regiter_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "환자등록";
            this.Load += new System.EventHandler(this.regiter_patient_Load);
            this.Patient_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Patient_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Emergency_Triage;
        private System.Windows.Forms.Label Guardian;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Birth_Date;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label Patient_Name;
        private System.Windows.Forms.Label Patient_Code;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Accident_Information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_code;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_birth;
        private System.Windows.Forms.TextBox p_phonenumber;
        private System.Windows.Forms.TextBox p_address;
        private System.Windows.Forms.TextBox p_protector;
        private System.Windows.Forms.TextBox p_sex;
        private System.Windows.Forms.TextBox p_register;
        private System.Windows.Forms.TextBox d_code;
        private System.Windows.Forms.TextBox p_accident;
    }
}