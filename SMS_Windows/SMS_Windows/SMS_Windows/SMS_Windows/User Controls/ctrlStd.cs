using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Windows.User_Controls
{
    public partial class ctrlStd : UserControl
    {
        DataTable tblStd = new DataTable();
        public ctrlStd()
        {
            InitializeComponent();
            tblStd.Columns.Add("StdName");
            BindStds();
        }

        private void BindStds()
        {
            Model.DBSchoolEntities db = new Model.DBSchoolEntities();
            var tblStds = db.tblStds;
            DataTable dt = new DataTable();
            dt.Columns.Add("StdName");
            dt.Columns.Add("StdId");

            foreach (var dr in tblStds)
            {
                DataRow drdt = dt.NewRow();
                drdt["StdName"] = dr.StdName;
                drdt["StdId"] = dr.StdId;

                dt.Rows.Add(drdt);
            }

            dgvStd.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClsName.Text))
            {
                DataRow dr = tblStd.NewRow();
                dr["StdName"] = txtClsName.Text;
                tblStd.Rows.Add(dr);

                dgvTempStd.DataSource = null;
                dgvTempStd.DataSource = tblStd;
            }
            else
            {
                GLOBAL.GLOBALMETHODS.SHOW_MESSAGEBOX("Please Enter Standrad Name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvTempStd.Rows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure want to save these data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Model.DBSchoolEntities db = new Model.DBSchoolEntities();
                    foreach (DataGridViewRow dr in dgvTempStd.Rows)
                    {
                        Model.tblStd std = new Model.tblStd()
                        {
                            BrId = null,
                            SchoolId = 1,
                            StdName = dr.Cells["StdName"].Value.ToString()
                        };
                        db.tblStds.Add(std);
                    }
                    db.SaveChanges();
                }
                GLOBAL.GLOBALMETHODS.SHOW_MESSAGEBOX(Resources.msgs.SaveRecord, Resources.msgs.SaveRecordTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GLOBAL.GLOBALMETHODS.SHOW_MESSAGEBOX("Please Add atleast one Standrad.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvStd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
