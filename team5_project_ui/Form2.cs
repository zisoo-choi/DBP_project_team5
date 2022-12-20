using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace team5_project_ui
{
    public partial class Treatment : Form
    {
        string sqlstr;

        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수


        public Treatment()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (findp_code.Text.Trim() == "")
                MessageBox.Show("검색 미입력");
            else
                list_search(findp_code.Text.Trim());
        }
            public void list_search(string Find)
                
            {
                if (!string.IsNullOrEmpty(Find))
                {



                    sqlstr = "Select p_name From Patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.SelectCommand = dbc.DCom;  //*
                    dbc.DA.Fill(dbc.DS, "sql_Result");
                    dbc.DS.Tables["sql_Result"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result");
                    currRow = dbc.DS.Tables["sql_Result"].Rows[0];
                    label11.Text = currRow[0].ToString();

                    sqlstr = "Select p_birth From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result2");
                    dbc.DS.Tables["sql_Result2"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result2");
                    currRow = dbc.DS.Tables["sql_Result2"].Rows[0];
                    label12.Text = currRow[0].ToString();

                    sqlstr = "Select p_phonenumber From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result3");
                    dbc.DS.Tables["sql_Result3"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result3");
                    currRow = dbc.DS.Tables["sql_Result3"].Rows[0];
                    label13.Text = currRow[0].ToString();

                    sqlstr = "Select p_address From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result4");
                    dbc.DS.Tables["sql_Result4"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result4");
                    currRow = dbc.DS.Tables["sql_Result4"].Rows[0];
                    label14.Text = currRow[0].ToString();

                    sqlstr = "Select p_protector From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result5");
                    dbc.DS.Tables["sql_Result5"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result5");
                    currRow = dbc.DS.Tables["sql_Result5"].Rows[0];
                    label15.Text = currRow[0].ToString();

                    sqlstr = "Select p_accident From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result6");
                    dbc.DS.Tables["sql_Result6"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result6");
                    currRow = dbc.DS.Tables["sql_Result6"].Rows[0];
                    label16.Text = currRow[0].ToString();

                    sqlstr = "Select p_sex From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result7");
                    dbc.DS.Tables["sql_Result7"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result7");
                    currRow = dbc.DS.Tables["sql_Result7"].Rows[0];
                    label17.Text = currRow[0].ToString();

                    sqlstr = "Select d_code From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result8");
                    dbc.DS.Tables["sql_Result8"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result8");
                    currRow = dbc.DS.Tables["sql_Result8"].Rows[0];
                    label18.Text = currRow[0].ToString();

                    sqlstr = "Select p_register From patient Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result9");
                    dbc.DS.Tables["sql_Result9"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result9");
                    currRow = dbc.DS.Tables["sql_Result9"].Rows[0];
                    label19.Text = currRow[0].ToString();

                    sqlstr = "Select c_code From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result10");
                    dbc.DS.Tables["sql_Result10"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result10");
                    currRow = dbc.DS.Tables["sql_Result10"].Rows[0];
                    label31.Text = currRow[0].ToString();

                    sqlstr = "Select t_code From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result11");
                    dbc.DS.Tables["sql_Result11"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result11");
                    currRow = dbc.DS.Tables["sql_Result11"].Rows[0];
                    label32.Text = currRow[0].ToString();

                    sqlstr = "Select d_code From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result12");
                    dbc.DS.Tables["sql_Result12"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result12");
                    currRow = dbc.DS.Tables["sql_Result12"].Rows[0];
                    label33.Text = currRow[0].ToString();

                    sqlstr = "Select p_code From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result13");
                    dbc.DS.Tables["sql_Result13"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result13");
                    currRow = dbc.DS.Tables["sql_Result13"].Rows[0];
                    label34.Text = currRow[0].ToString();

                    sqlstr = "Select n_code From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result14");
                    dbc.DS.Tables["sql_Result14"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result14");
                    currRow = dbc.DS.Tables["sql_Result14"].Rows[0];
                    label35.Text = currRow[0].ToString();

                    sqlstr = "Select c_opinion From chart Where p_code Like '%" + Find + "%'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.Fill(dbc.DS, "sql_Result15");
                    dbc.DS.Tables["sql_Result15"].Clear();
                    dbc.DA.Fill(dbc.DS, "sql_Result15");
                    currRow = dbc.DS.Tables["sql_Result15"].Rows[0];
                    richTextBox2.Text = currRow[0].ToString();


                    

                }

            }


        

        private void Treatment_Load(object sender, EventArgs e)
        {
            list_search("");

        }
    }
}
