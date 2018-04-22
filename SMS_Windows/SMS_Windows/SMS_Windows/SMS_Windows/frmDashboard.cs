using SMS_Windows.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Windows
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            Welcome welcome=new Welcome();
            pnlCenter.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;

            Model.DBSchoolEntities db = new Model.DBSchoolEntities();
            var CheckMenus = db.tblMenus;

            if (CheckMenus != null)
            {
                foreach (var menu in CheckMenus)
                {
                    if (menu.MenuName == SchoolMaster.Name)
                    {
                        SchoolMaster.Visible = true;
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
        }

    }
}
