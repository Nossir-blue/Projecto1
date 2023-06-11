using Projecto1.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddCustumerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddCustumerRegistration.Left+18;
            uC_CustumerRegistration1.Visible = true;
            uC_CustumerRegistration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left+18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CustumerCheckOut1.Visible = true;
            uC_CustumerCheckOut1.BringToFront();

            MovingPanel.Left=btnCheckOut.Left+18;
        }

        private void btnCustumerDetail_Click(object sender, EventArgs e)
        {
            custumerDetails1.Visible = true; 
            custumerDetails1.BringToFront();
            MovingPanel.Left=btnCustumerDetail.Left+18;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            MovingPanel.Left= btnEmployee.Left+18;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustumerRegistration1.Visible = false;
        }
    }
}
