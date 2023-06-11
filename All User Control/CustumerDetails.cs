using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto1.All_User_Control
{
    public partial class CustumerDetails : UserControl
    {
        function fn = new function();
        String query;
        public CustumerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBar.SelectedIndex == 0)
            {
                query = "select custumer.cid,custumer.cname,custumer.mobile,custumer.nationality,custumer.gender,custumer.dob,custumer.idproof,custumer.addres,custumer.checkin,custumer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from custumer inner join rooms on custumer.roomid = rooms.roomid";
                getRecord(query);
            }
            else if(txtSearchBar.SelectedIndex == 1)
            {
                query = "select custumer.cid,custumer.cname,custumer.mobile,custumer.nationality,custumer.gender,custumer.dob,custumer.idproof,custumer.addres,custumer.checkin,custumer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from custumer inner join rooms on custumer.roomid = rooms.roomid where checkout is null";
                getRecord(query);
            }
            else if( txtSearchBar.SelectedIndex == 2)
            {
                query = "select custumer.cid,custumer.cname,custumer.mobile,custumer.nationality,custumer.gender,custumer.dob,custumer.idproof,custumer.addres,custumer.checkin,custumer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from custumer inner join rooms on custumer.roomid = rooms.roomid where checkout is not null";
                getRecord(query);
            }
        }
        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
