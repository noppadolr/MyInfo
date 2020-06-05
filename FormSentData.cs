using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace MyInfo
{
    public partial class FormSentData : Form
    {
        public FormSentData()
        {
            InitializeComponent();
        }
        public string hcode { get; set; }

        public string hname { get; set; }

        public int yearprocess { get; set; }

        public MySqlConnection ConJ { get; set; }

        public MySqlConnection ConServer { get; set; }
        public MySqlConnection conHdc { get; set; }
        private void FormSentData_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSentAll_CheckStateChanged(object sender, EventArgs e)
        {
            //if(checkBoxSentAll.CheckState==CheckState.Checked)
             
            //    {
            //        dateBegin.Enabled = false;
            //        dateEnd.Enabled = false;
            //    }
            //    else
            //    {
            //        dateBegin.Enabled = true;
            //        dateEnd.Enabled = true;
            //    }
        }

        private void checkBoxSentAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSentAll.Checked)
            {
                dateBegin.Enabled = false;
                dateEnd.Enabled = false;
            }
            else
            {
                dateBegin.Enabled = true;
                dateEnd.Enabled = true;
            }
        }

        private void btnSentData_Click(object sender, EventArgs e)
        {
            string sqlVisitFP = null;
            int yy = dateBegin.Value.Year;
            string y = yy.ToString();
            string m = dateBegin.Value.Month.ToString("00");
            string d = dateBegin.Value.Date.ToString("dd");
            string beginDate = y + m + d;
            yy = dateEnd.Value.Year;
            y = yy.ToString();
            m = dateEnd.Value.Month.ToString("00");
            d = dateEnd.Value.Date.ToString("dd");
            string endDate = y + m + d;
            MessageBox.Show(beginDate + "   " + endDate);
        }
    }
}
