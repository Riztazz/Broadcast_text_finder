using System;
using System.Data;
using System.Windows.Forms;

namespace BroadcastTextFinder
{
    public partial class FrmBroadcastTextFinder : Form
    {
        DataSet DS = new DataSet();

        string sqltext = "";

        public FrmBroadcastTextFinder()
        {
            InitializeComponent();
        }

        private void FrmBroadcastTextFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btn_FindLike_Click(object sender, EventArgs e)
        {
            sqltext = "SELECT * FROM `broadcast_text` WHERE `MaleText` LIKE \"%" + txt_FindLike.Text.ToString() + "%\" OR `FemaleText` LIKE \"%" + txt_FindLike.Text.ToString() + "%\";";
            findBroadcast(sqltext, false);
        }

        private void Btn_FindID_Click(object sender, EventArgs e)
        {
            sqltext = "SELECT * FROM `broadcast_text` WHERE `ID`=" + txt_FindID.Text.ToString() + ";";
            findBroadcast(sqltext, true);
        }

        private void findBroadcast(string sqltext, bool searchtype)
        {
            try
            {
                DS = (DataSet)Module.database_conn(sqltext);
            }
            catch
            {
                MessageBox.Show("Search data is not valid. Recheck search data.", " Input Error");
                return;
            }

            if (DS.Tables["table1"].Rows.Count > 0)
            {
                dgv.DataSource = DS.Tables["table1"];
            }
            else
            {
                if (searchtype)
                    MessageBox.Show("That broadcast text ID does not exist.", "Nothing found");
                else
                    MessageBox.Show("No broadcast text with that string exist.", "Nothing found");
            }
        }
    }
}
