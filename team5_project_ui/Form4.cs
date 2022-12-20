using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team5_project_ui
{
    public partial class information : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DataRow currRow;
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        public information()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }
        public void information_display()
        {

            sqlstr = "Select Count(*) From Patient";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;  //*
            dbc.DA.Fill(dbc.DS, "sql_Result");
            dbc.DS.Tables["sql_Result"].Clear();
            dbc.DA.Fill(dbc.DS, "sql_Result");
            currRow = dbc.DS.Tables["sql_Result"].Rows[0];
            label7.Text = currRow[0].ToString() + "명";

            sqlstr = "Select Count(*) From Doctor";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.Fill(dbc.DS, "sql_Result");
            dbc.DS.Tables["sql_Result"].Clear();
            dbc.DA.Fill(dbc.DS, "sql_Result");
            currRow = dbc.DS.Tables["sql_Result"].Rows[0];
            label8.Text = currRow[0].ToString() + "명";

            sqlstr = "Select Count(*) From Nurse";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.Fill(dbc.DS, "sql_Result");
            dbc.DS.Tables["sql_Result"].Clear();
            dbc.DA.Fill(dbc.DS, "sql_Result");
            currRow = dbc.DS.Tables["sql_Result"].Rows[0];
            label9.Text = currRow[0].ToString() + "명";

            sqlstr = "Select Count(*) From Chart";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.Fill(dbc.DS, "sql_Result");
            dbc.DS.Tables["sql_Result"].Clear();
            dbc.DA.Fill(dbc.DS, "sql_Result");
            currRow = dbc.DS.Tables["sql_Result"].Rows[0];
            label11.Text = currRow[0].ToString() + "개";
        }


        private void information_Load(object sender, EventArgs e)
        {
            information_display();
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F");
        }
    }
}
