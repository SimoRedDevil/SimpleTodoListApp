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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleTodoListApp
{
    public partial class FrmModifyTask : Form
    {
        public DataAccess DA;
        public int ID;

        public FrmModifyTask()
        {
            InitializeComponent();
        }

        private void FrmModifyTask_Load(object sender, EventArgs e)
        {
            DataTable dt = DA.selectData($"SELECT * FROM TBL WHERE ID={ID}");
            txtTaskName.Text = dt.Rows[0][1].ToString();
            txtTaskDescription.Text = dt.Rows[0][2].ToString();
            cmbTaskType.Text = dt.Rows[0][3].ToString();
            if (dt.Rows[0][5].ToString() == "Pending")
                rbPending.Checked = true;
            else
                rbComplete.Checked = true;
        }

        private void btnModifyTask_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams = new SqlParameter[5]
            {
                new SqlParameter("@ID", SqlDbType.Int),
                new SqlParameter("@Name", SqlDbType.VarChar, 100),
                new SqlParameter("@Description", SqlDbType.VarChar, 200),
                new SqlParameter("@Type", SqlDbType.VarChar, 30),
                new SqlParameter("@Status", SqlDbType.VarChar, 20)
            };
            sqlParams[0].Value = ID;
            sqlParams[1].Value = txtTaskName.Text;
            sqlParams[2].Value = txtTaskDescription.Text;
            sqlParams[3].Value = cmbTaskType.Text;
            if (rbPending.Checked == true)
                sqlParams[4].Value = "Pending";
            else
                sqlParams[4].Value = "Complete";
            DA.executeCommand("UPDATE TBL SET Name=@Name,Description=@Description,Type=@Type,Status=@Status WHERE ID=@ID", sqlParams);
        }
    }
}
