
namespace team5_project_ui
{
    partial class information
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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_Number_Of_Patients = new System.Windows.Forms.Label();
            this.Number_Of_Discharged_Patients_Today = new System.Windows.Forms.Label();
            this.Number_Of_Hospitalized_Patients_Today = new System.Windows.Forms.Label();
            this.Current_Number_Of_Treatment_Patients = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "000 명";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "000 명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "000 명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "000 명";
            // 
            // Total_Number_Of_Patients
            // 
            this.Total_Number_Of_Patients.AutoSize = true;
            this.Total_Number_Of_Patients.Location = new System.Drawing.Point(115, 317);
            this.Total_Number_Of_Patients.Name = "Total_Number_Of_Patients";
            this.Total_Number_Of_Patients.Size = new System.Drawing.Size(122, 15);
            this.Total_Number_Of_Patients.TabIndex = 15;
            this.Total_Number_Of_Patients.Text = "총 차트 누적 수 :";
            // 
            // Number_Of_Discharged_Patients_Today
            // 
            this.Number_Of_Discharged_Patients_Today.AutoSize = true;
            this.Number_Of_Discharged_Patients_Today.Location = new System.Drawing.Point(115, 254);
            this.Number_Of_Discharged_Patients_Today.Name = "Number_Of_Discharged_Patients_Today";
            this.Number_Of_Discharged_Patients_Today.Size = new System.Drawing.Size(167, 15);
            this.Number_Of_Discharged_Patients_Today.TabIndex = 14;
            this.Number_Of_Discharged_Patients_Today.Text = "응급실 근무 간호사 수 :";
            // 
            // Number_Of_Hospitalized_Patients_Today
            // 
            this.Number_Of_Hospitalized_Patients_Today.AutoSize = true;
            this.Number_Of_Hospitalized_Patients_Today.Location = new System.Drawing.Point(115, 195);
            this.Number_Of_Hospitalized_Patients_Today.Name = "Number_Of_Hospitalized_Patients_Today";
            this.Number_Of_Hospitalized_Patients_Today.Size = new System.Drawing.Size(152, 15);
            this.Number_Of_Hospitalized_Patients_Today.TabIndex = 13;
            this.Number_Of_Hospitalized_Patients_Today.Text = "응급실 근무 의사 수 :";
            // 
            // Current_Number_Of_Treatment_Patients
            // 
            this.Current_Number_Of_Treatment_Patients.AutoSize = true;
            this.Current_Number_Of_Treatment_Patients.Location = new System.Drawing.Point(115, 136);
            this.Current_Number_Of_Treatment_Patients.Name = "Current_Number_Of_Treatment_Patients";
            this.Current_Number_Of_Treatment_Patients.Size = new System.Drawing.Size(117, 15);
            this.Current_Number_Of_Treatment_Patients.TabIndex = 12;
            this.Current_Number_Of_Treatment_Patients.Text = "등록 총 환자수 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::team5_project_ui.Properties.Resources.sah_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 69);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total_Number_Of_Patients);
            this.Controls.Add(this.Number_Of_Discharged_Patients_Today);
            this.Controls.Add(this.Number_Of_Hospitalized_Patients_Today);
            this.Controls.Add(this.Current_Number_Of_Treatment_Patients);
            this.Name = "information";
            this.Text = "정보";
            this.Load += new System.EventHandler(this.information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Total_Number_Of_Patients;
        private System.Windows.Forms.Label Number_Of_Discharged_Patients_Today;
        private System.Windows.Forms.Label Number_Of_Hospitalized_Patients_Today;
        private System.Windows.Forms.Label Current_Number_Of_Treatment_Patients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}