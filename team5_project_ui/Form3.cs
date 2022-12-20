using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // 3. 넣어주기
using team5_project_ui;

namespace team5_project_ui
{
    public partial class regiter_patient : Form
    {
        OracleConnection connection = new OracleConnection("User Id= team5; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) )");

        string patientsql; // 1.변수선언
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수

        public regiter_patient() // 2. 아래 넣어주기
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }


       

        public void patient_header()
        {
            dataGridView1.Columns[0].HeaderText = "환자코드";
            dataGridView1.Columns[1].HeaderText = "환자이름";
            dataGridView1.Columns[2].HeaderText = "생년월일";
            dataGridView1.Columns[3].HeaderText = "전화번호";
            dataGridView1.Columns[4].HeaderText = "주소";
            dataGridView1.Columns[5].HeaderText = "보호자";
            dataGridView1.Columns[6].HeaderText = "사고정보";
            dataGridView1.Columns[7].HeaderText = "성별";
            dataGridView1.Columns[8].HeaderText = "등록시간";
            dataGridView1.Columns[9].HeaderText = "담당 의사코드";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[9].Width = 130;
        }
        // load 부분
        DataTable table = new DataTable();
 



        private void regiter_patient_Load(object sender, EventArgs e)
        {
          
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                patientsql = "Select * From patient ORDER BY p_code ASC";
                dbc.DCom.CommandText = patientsql;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "patient");
                dbc.DS.Tables["patient"].Clear();
                dbc.DA.Fill(dbc.DS, "patient");
                dataGridView1.DataSource = dbc.DS.Tables["patient"].DefaultView;
                
                patient_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }

            {
                table.Columns.Add("환자코드",typeof(string));
                table.Columns.Add("이름", typeof(string));
                table.Columns.Add("생년월일", typeof(double));
                table.Columns.Add("전화번호", typeof(double));
                table.Columns.Add("주소", typeof(string));
                table.Columns.Add("보호자", typeof(string));
                table.Columns.Add("사고정보", typeof(string));
                table.Columns.Add("성별", typeof(string));
                table.Columns.Add("등록날짜", typeof(double));
                table.Columns.Add("담당의사", typeof(string));

                dataGridView1.DataSource = table;
            }

           
        }

        private void Add_Click(object sender, EventArgs e)
        {
      

             table.Rows.Add(p_code.Text, p_name.Text, p_birth.Text, p_phonenumber.Text, p_address.Text, p_protector.Text, p_accident.Text, p_sex.Text, p_register.Text, d_code.Text);
             dataGridView1.DataSource = table; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void p_code_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_phonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_protector_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_accident_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_register_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow rw = dataGridView1.Rows[index];
            p_code.Text = rw.Cells[0].Value.ToString();
            p_name.Text = rw.Cells[1].Value.ToString();
            p_birth.Text = rw.Cells[2].Value.ToString();
            p_phonenumber.Text = rw.Cells[3].Value.ToString();
            p_address.Text = rw.Cells[4].Value.ToString();
            p_protector.Text = rw.Cells[5].Value.ToString();
            p_accident.Text = rw.Cells[6].Value.ToString();
            p_sex.Text = rw.Cells[7].Value.ToString();
            p_register.Text = rw.Cells[8].Value.ToString();
            d_code.Text = rw.Cells[9].Value.ToString();

        }
    }
}