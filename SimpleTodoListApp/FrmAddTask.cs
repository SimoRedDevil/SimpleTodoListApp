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
    public partial class FrmAddTask : Form
    {
        public DataAccess DA;

        public FrmAddTask()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text.Length > 0 && txtTaskDescription.Text.Length > 0)
            {
                SqlParameter[] sqlParams = new SqlParameter[5]
                {
                    new SqlParameter("@Name", SqlDbType.VarChar, 100),
                    new SqlParameter("@Description", SqlDbType.VarChar, 200),
                    new SqlParameter("@Type", SqlDbType.VarChar, 30),
                    new SqlParameter("@Date", SqlDbType.DateTime),
                    new SqlParameter("@Status", SqlDbType.VarChar, 20)
                };
                sqlParams[0].Value = txtTaskName.Text;
                sqlParams[1].Value = txtTaskDescription.Text;
                sqlParams[2].Value = cmbTaskType.Text;
                sqlParams[3].Value = DateTime.Now.ToString("G");
                sqlParams[4].Value = "Pending";
                DA.executeCommand("insert into TBL values (@Name,@Description,@Type,@Date,@Status)", sqlParams);
            }
        }
    }
}
