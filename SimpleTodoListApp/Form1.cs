using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTodoListApp
{
    public partial class Form1 : Form
    {
        private DataAccess DA;

        public Form1()
        {
            InitializeComponent();
            DA = new DataAccess();
            DA.openConnection();
            lvData.IsAccessible = true;
        }

        private void refreshLV()
        {
            DataTable dt = DA.selectData("SELECT * FROM TBL");
            lvData.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Name"].ToString());
                item.SubItems.Add(dr["Description"].ToString());
                item.SubItems.Add(dr["Type"].ToString());
                item.SubItems.Add(dr["Date"].ToString());
                item.SubItems.Add(dr["Status"].ToString());
                item.Checked = dr["Status"].ToString() == "Pending" ? false : true;
                item.ToolTipText = dr["ID"].ToString();
                lvData.Items.Add(item);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddTask frmAddTask = new FrmAddTask();
            frmAddTask.DA = DA;
            frmAddTask.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvData.SelectedItems)
                {
                    FrmModifyTask frmModifyTask = new FrmModifyTask();
                    frmModifyTask.DA = DA;
                    frmModifyTask.ID = int.Parse(item.ToolTipText);
                    frmModifyTask.ShowDialog();
                }
                refreshLV();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvData.SelectedItems)
                    DA.executeCommand("DELETE FROM TBL WHERE ID=" + item.ToolTipText, null);
                refreshLV();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshLV();
        }

        private void lvData_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string status = "Pending";
            if (e.Item.Checked)
                status = "Complete";
            SqlParameter[] sqlParams = new SqlParameter[2]
            {
                new SqlParameter("@ID", SqlDbType.Int),
                new SqlParameter("@Status", SqlDbType.VarChar, 20)
            };
            sqlParams[0].Value = int.Parse(e.Item.ToolTipText);
            sqlParams[1].Value = status;
            DA.executeCommand("UPDATE TBL SET Status=@Status WHERE ID=@ID", sqlParams);
        }

        private void lvData_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}
