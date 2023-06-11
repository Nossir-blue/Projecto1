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
    public partial class UC_CustumerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustumerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CustumerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select custumer.cid,custumer.cname,custumer.mobile,custumer.nationality,custumer.gender,custumer.dob,custumer.idproof,custumer.addres,custumer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from custumer inner join rooms on custumer.roomid = rooms.roomid where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select custumer.cid,custumer.cname,custumer.mobile,custumer.nationality,custumer.gender,custumer.dob,custumer.idproof,custumer.addres,custumer.checkin,roomNo,rooms.roomType,rooms.bed,rooms.price from custumer inner join rooms on custumer.roomid = rooms.roomid where cname like '"+txtName.Text+"%' and chekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "")
            {
                if (MessageBox.Show("Tem a certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update custumer set chekout = 'YES',checkout = '"+cdate+"' where cid = "+id+" update rooms set booked = 'NO' where roomNo = '"+txtRoom.Text+"'";
                    fn.setData(query, "Check Out bem sucedido");
                    UC_CustumerCheckOut_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente seleccionado","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void ClearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();

        }

        private void UC_CustumerCheckOut_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
