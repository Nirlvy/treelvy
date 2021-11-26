using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treelvy
{
    public partial class combo : Form
    {
        public combo()
        {
            InitializeComponent();
            manager_user_Click(null, null);
        }

        private void manager_user_Click(object sender, EventArgs e)
        {            
            manager_user.BackColor = Color.FromArgb(0, 122, 204);
            area.BackColor = Color.FromArgb(45, 45, 48);
            sift.BackColor = Color.FromArgb(45, 45, 48);
            now.BackColor = Color.FromArgb(45, 45, 48);
            common.manager_user = new manager_user();
            common.manager_user.TopLevel = false;
            common.manager_user.Dock = DockStyle.Fill;
            common.manager_user.Parent = panel;
            panel.Controls.Clear();
            panel.Controls.Add(common.manager_user);
            common.getManager_userForm().Show();
        }

        private void area_Click(object sender, EventArgs e)
        {
            manager_user.BackColor = Color.FromArgb(45, 45, 48);
            area.BackColor = Color.FromArgb(0, 122, 204);
            sift.BackColor = Color.FromArgb(45, 45, 48);
            now.BackColor = Color.FromArgb(45, 45, 48); 
            common.area = new area();
            common.area.TopLevel = false;
            common.area.Dock = DockStyle.Fill;
            common.area.Parent = panel;
            panel.Controls.Clear();
            panel.Controls.Add(common.area);
            common.getAreaForm().Show();
        }

        private void sift_Click(object sender, EventArgs e)
        {
            manager_user.BackColor = Color.FromArgb(45, 45, 48);
            area.BackColor = Color.FromArgb(45, 45, 48);
            sift.BackColor = Color.FromArgb(0, 122, 204);
            now.BackColor = Color.FromArgb(45, 45, 48);
            common.sift = new sift();
            common.sift.TopLevel = false;
            common.sift.Dock = DockStyle.Fill;
            common.sift.Parent = panel;
            panel.Controls.Clear();
            panel.Controls.Add(common.sift);
            common.getSiftForm().Show();
        }

        private void now_Click(object sender, EventArgs e)
        {
            manager_user.BackColor = Color.FromArgb(45, 45, 48);
            area.BackColor = Color.FromArgb(45, 45, 48);
            sift.BackColor = Color.FromArgb(45, 45, 48);
            now.BackColor = Color.FromArgb(0, 122, 204); 
            common.now = new now();
            common.now.TopLevel = false;
            common.now.Dock = DockStyle.Fill;
            common.now.Parent = panel;
            panel.Controls.Clear();
            panel.Controls.Add(common.now);
            common.getNowForm().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.combo = null;
            common.getManagerForm().Show();
        }
    }
}
