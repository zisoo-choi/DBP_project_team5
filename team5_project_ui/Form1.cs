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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Treatment treatment; //Form2
        regiter_patient patient; //Form3
        information information; //Form4
        medical_staff medistaff; //Form5
        chart chart; //Form6

        private void Form1_Load(object sender, EventArgs e)
        {
            treatment = new Treatment();
            treatment.MdiParent = this;
            treatment.Show();
        }

        private void 환자등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(patient == null || patient.IsDisposed)  //Form3
            {
                patient = new regiter_patient();
                patient.MdiParent = this;
                patient.Show();
            }
        }

        private void 의료진목록ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (medistaff == null || medistaff.IsDisposed)  //Form3
            {
                medistaff = new medical_staff();
                medistaff.MdiParent = this;
                medistaff.Show();
            }
        }

        private void 차트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chart == null || chart.IsDisposed)  //Form3
            {
                chart = new chart();
                chart.MdiParent = this;
                chart.Show();
            }
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (information == null || information.IsDisposed)  //Form3
            {
                information = new information();
                information.MdiParent = this;
                information.Show();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
