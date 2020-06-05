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
using DevExpress.XtraEditors;

namespace MyInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public bool LogedIn=false;
        ConnectDB conDB = new ConnectDB();
        private void Form1_Load(object sender, EventArgs e)
        {
          //  ConnectDB conDB = new ConnectDB();
            MySqlConnection testJhcis = conDB.jhcisConnection();
            MySqlConnection testServer = conDB.serverConnection();
            try
            {
                testJhcis.Open();
                StatusLblJHCIS.Text = "";
                StatusLblJHCIS.Text = "การเชื่อมต่อ JHCIS : เชื่อมต่อได้";
                StatusLblJHCIS.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อ JHCIS"+Environment.NewLine+ex.Message, "Connect JHCIS Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                StatusLblJHCIS.Text = "";
                StatusLblJHCIS.Text = "การเชื่อมต่อ JHCIS : เชื่อมต่อไม่ได้";
                StatusLblJHCIS.ForeColor = Color.Red;
            }
            finally
            {
                testJhcis.Close();
            }
            try
            {
                testServer.Open();
                StatusLblServer.Text = "";
                StatusLblServer.Text = "การเชื่อมต่อ Server : เชื่อมต่อได้";
                StatusLblServer.ForeColor = Color.Green;
                if (LogedIn == false)
                {
                    FormLogin fl = new FormLogin();
                    fl.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อ Server ได้"+Environment.NewLine+"ตรวจสอบการเชื่อมต่อ Internet แล้วเปิดโปรแกรมใหม่"+Environment.NewLine+ex.Message,"Connect Server Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                StatusLblServer.Text = "";
                StatusLblServer.Text = "การเชื่อมต่อ Server : เชื่อมต่อไม่ได้";
                StatusLblServer.ForeColor = Color.Red;
            }
            finally
            {
                testServer.Close();
            }

        }

        private void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuSendData_Click(object sender, EventArgs e)
        {
            FormSentData frm = new FormSentData();
            frm.ConJ = conDB.jhcisConnection();
            frm.ConServer = conDB.serverConnection();
            frm.conHdc = conDB.hdcConnection();
            
            frm.ShowDialog();

        }
    }
}
