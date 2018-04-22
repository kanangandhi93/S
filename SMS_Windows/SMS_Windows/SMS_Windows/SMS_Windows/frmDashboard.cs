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

        List<Control> ControlList = new List<Control>();
        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is Button) ControlList.Add(c);
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
           


            Model.DBSchoolEntities db = new Model.DBSchoolEntities();
            var CheckMenus = db.tblMenus;

            GetAllControls(this);
            if (CheckMenus != null)
            {
                foreach (var menu in CheckMenus)
                {
                    foreach (Control c in ControlList)
                    {
                        if (c.Name == menu.MenuName)
                        {
                            c.Visible = true;
                        }
                    }
                }
            }

            Close.Visible = true;
            Settings.Visible = true;

            Welcome welcome = new Welcome();
            LoadControl(welcome);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            ctrlSchool ctrlschool = new ctrlSchool();
            LoadControl(ctrlschool);
           
        }

        private void LoadControl(UserControl userControl)
        {
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
    }
}
