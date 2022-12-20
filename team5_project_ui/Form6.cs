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

namespace team5_project_ui
{
    public partial class chart : Form
    {
        string charsql;
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수

        public chart()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        public void chart_counter()
        {
            int i;
            i = dataGridView1.RowCount;
            label7.Text = "총 " + i + " 명";
        }

        public void chart_header()
        {
            dataGridView1.Columns[0].HeaderText = "차트코드";
            dataGridView1.Columns[1].HeaderText = "소견";
            dataGridView1.Columns[2].HeaderText = "치료코드";
            dataGridView1.Columns[3].HeaderText = "환자코드";
            dataGridView1.Columns[4].HeaderText = "의사코드";
            dataGridView1.Columns[5].HeaderText = "간호사코드";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
        }

        private void chart_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                charsql = "Select * From chart ORDER BY c_code ASC";
                dbc.DCom.CommandText = charsql;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "chart");
                dbc.DS.Tables["chart"].Clear();
                dbc.DA.Fill(dbc.DS, "chart");
                dataGridView1.DataSource = dbc.DS.Tables["chart"].DefaultView;
                chart_counter();
                chart_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
