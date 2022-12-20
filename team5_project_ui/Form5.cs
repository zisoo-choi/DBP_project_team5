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
    public partial class medical_staff : Form
    {
        string doctorsql; // 1.변수선언
        string nursesql; // 1.변수선언
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수

        public medical_staff()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        public void doctor_counter()
        {
            int i;
            i = dataGridView1.RowCount;
            label5.Text = "총 " + i + " 명";
        }

        public void nurse_counter()
        {
            int i;
            i = dataGridView2.RowCount;
            label6.Text = "총 " + i + " 명";
        }

        public void doctor_header()
        {
            dataGridView1.Columns[0].HeaderText = "의사코드";
            dataGridView1.Columns[1].HeaderText = "의사이름";
            dataGridView1.Columns[2].HeaderText = "전화번호";
            dataGridView1.Columns[3].HeaderText = "전공부서";
            dataGridView1.Columns[4].HeaderText = "이메일";
            dataGridView1.Columns[5].HeaderText = "휴무일";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
        }

        public void nurse_header()
        {
            dataGridView2.Columns[0].HeaderText = "간호사코드";
            dataGridView2.Columns[1].HeaderText = "주요업무";
            dataGridView2.Columns[2].HeaderText = "간호사이름";
            dataGridView2.Columns[3].HeaderText = "성별";
            dataGridView2.Columns[4].HeaderText = "전화번호";
            dataGridView2.Columns[5].HeaderText = "이메일";
            dataGridView2.Columns[6].HeaderText = "직급";
            dataGridView2.Columns[7].HeaderText = "휴무일";

            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 80;
            dataGridView2.Columns[5].Width = 80;
            dataGridView2.Columns[6].Width = 80;
            dataGridView2.Columns[7].Width = 80;
        }

        // 사용자 함수 정의로 실행을 해준다.
        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의,  sql_execute(쿼리문이 들어오고, 데이터셋이 들어온다)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "doctor"); //--> 결과값을 book이라고 하는 table 에 저장해달라 !
            dsstr.Tables["doctor"].Clear(); //--> sql_execute이 자주 실행되니까 혹시몰라서 그 전 것을 (지운다) clear한다 !
            //***** 방법1 :DS를 하나만 정의한 상태에서 기존의 DS의 book만 제거
            //*****  sql_execute()의 방법1은 DS를 하나만 정의할 경우로 테이블 단위로 클리어 한다.
            //dbc.DS.Clear(); 
            //위의 DS를 지우면 dataGridView2까지 클리어 되어서 안 됨! 
            // 이 경우는 dataGridView마다 다른 DS를 사용할 것
            dbc.DA.Fill(dsstr, "doctor"); //--> 다시 채운다 !

            dataGridView1.DataSource = dsstr.Tables["doctor"].DefaultView; // DataGridView1에 doctor 데이터를 화면에 보여준다.
            doctor_counter();  //함수 호출 --> 총 00명 을 말함 !
            doctor_header();   //함수 호출 --> 의사 스키마를 불러와줌 !
        }

        public void list_search(String Find, String Sort)
        {

            if (Find == "" && Sort == "")           //기본으로 FInd와 Sort의 값이 null이라면
            {
                doctorsql = "Select * From doctor"; //doctor 데이터를 보여줘라
                sql_execute(doctorsql, dbc.DS);     //보여주기 위한 실행
            }

            else if (Find == "" && Sort != "")  //정렬
            {
                if (Sort == "d_code")
                { doctorsql = "Select * From doctor ORDER BY d_code ASC"; }
                else if (Sort == "d_name")
                { doctorsql = "Select * From doctor ORDER BY d_name ASC"; }

                sql_execute(doctorsql, dbc.DS);
            }

            else if (Find != "")  //검색
            {
                if (Find != "")
                { doctorsql = "Select * From doctor Where d_code Like '%" + Find + "%'"; }

                sql_execute(doctorsql, dbc.DS);
                if (dbc.DS.Tables["doctor"].Rows.Count == 0) //--> 해당되는 것이 없으면 에러메시지
                {
                    MessageBox.Show("해당 의사가 없습니다");
                    doctorsql = "Select * From doctor ORDER BY d_code ASC";
                    sql_execute(doctorsql, dbc.DS);
                }
            }
        }



        private void medical_staff_Load(object sender, EventArgs e)
        {
            list_search("", "");    //의사 실행파일
            list_search2("", "");   //간호사 실행파일

            try
            {
                //의사
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                doctorsql = "Select * From doctor ORDER BY d_code ASC";
                dbc.DCom.CommandText = doctorsql;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "doctor");
                dbc.DS.Tables["doctor"].Clear();
                dbc.DA.Fill(dbc.DS, "doctor");
                dataGridView1.DataSource = dbc.DS.Tables["doctor"].DefaultView;
                doctor_counter();
                doctor_header();


                //간호사
                nursesql = "Select * From nurse ORDER BY n_code ASC";
                dbc.DCom.CommandText = nursesql;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "nurse");
                dbc.DS.Tables["nurse"].Clear();
                dbc.DA.Fill(dbc.DS, "nurse");
                dataGridView2.DataSource = dbc.DS.Tables["nurse"].DefaultView;
                nurse_counter();
                nurse_header();
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

        //의사 검색 버튼
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textFind1.Text.Trim() == "")            //textFind1에 들어오는 입력이 없다면
                MessageBox.Show("검색 미입력");
            else
                list_search(textFind1.Text.Trim(), ""); //이건 list_search(find, sort)이다.

        }

        //의사 정렬 버튼
        private void code_btn_Click(object sender, EventArgs e)
        {
            list_search("", "d_code");
        }

        private void name_btn_Click(object sender, EventArgs e)
        {
            list_search("", "d_name");
        }

        // 간호사 검색과 간호사 정렬에 해당하는 코드
        public void list_search2(String Find, String Sort)
        {

            if (Find == "" && Sort == "")  //기본
            {
                nursesql = "Select * From nurse";
                sql_execute2(nursesql, dbc.DS);
            }

            else if (Find == "" && Sort != "")  //정렬
            {
                if (Sort == "n_code")
                { nursesql = "Select * From nurse ORDER BY n_code ASC"; }
                else if (Sort == "n_name")
                { nursesql = "Select * From nurse ORDER BY n_name ASC"; }

                sql_execute2(nursesql, dbc.DS);
            }

            else if (Find != "")  //검색
            {
                if (Find != "")
                { nursesql = "Select * From nurse Where n_code Like '%" + Find + "%'"; }

                sql_execute2(nursesql, dbc.DS);
                if (dbc.DS.Tables["nurse"].Rows.Count == 0) //--> 해당되는 것이 없으면 에러메시지
                {
                    MessageBox.Show("해당 간호사가 없습니다");
                    nursesql = "Select * From nurse ORDER BY n_code ASC";
                    sql_execute2(nursesql, dbc.DS);
                }
            }
        }

        // 간호사 실행코드 (의사와 별도로 만들어줘야 함)
        public void sql_execute2(String sqlstr, DataSet dsstr)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "nurse"); //--> 결과값을 book이라고 하는 table 에 저장해달라 !
            dsstr.Tables["nurse"].Clear(); //--> sql_execute이 자주 실행되니까 혹시몰라서 그 전 것을 (지운다) clear한다 !
            //***** 방법1 :DS를 하나만 정의한 상태에서 기존의 DS의 book만 제거
            //*****  sql_execute()의 방법1은 DS를 하나만 정의할 경우로 테이블 단위로 클리어 한다.
            //dbc.DS.Clear(); 
            //위의 DS를 지우면 dataGridView2까지 클리어 되어서 안 됨! 
            // 이 경우는 dataGridView마다 다른 DS를 사용할 것
            dbc.DA.Fill(dsstr, "nurse"); //--> 다시 채운다 !

            dataGridView2.DataSource = dsstr.Tables["nurse"].DefaultView;
            nurse_counter();  //함수 호출 --> 총 00명 을 말함 !
            nurse_header();   //함수 호출 --> 간호사 스키마라고 생각하면 된다.
        }

        private void code_btn2_Click(object sender, EventArgs e)
        {
            list_search2("", "n_code");
        }

        private void name_btn2_Click(object sender, EventArgs e)
        {
            list_search2("", "n_name");
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            if (textFind2.Text.Trim() == "")
                MessageBox.Show("검색 미입력");
            else
                list_search2(textFind2.Text.Trim(), ""); //--> list_search(find, sort) 임 !

        }
    }
}
