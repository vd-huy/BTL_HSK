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

namespace BTL_HSK
{
    public partial class formChiTietHoaDon : Form
    {
        public formChiTietHoaDon()
        {
            InitializeComponent();
        }

        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";
        private void formChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.HoaDon";
            string queryThuoc = "SELECT * FROM dbo.Thuoc";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaHD.DataSource = table;
                cbMaHD.DisplayMember = "sMaHD";
                cbMaHD.ValueMember = "sMaHD";

                // đóng kết nối
                connection.Close();


            }

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(queryThuoc, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaThuoc.DataSource = table;
                cbMaThuoc.DisplayMember = "sMaThuoc";
                cbMaThuoc.ValueMember = "sMaThuoc";

                // đóng kết nối
                connection.Close();


            }

            txbSoLuong_TextChanged(sender, e);
        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbDonGia.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbMucGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbMucGiamGia.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled= true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbSoLuong.Text) || string.IsNullOrEmpty(txbDonGia.Text) || string.IsNullOrEmpty(txbMucGiamGia.Text))
            {
                btnThem.Enabled= false;
                btnSua.Enabled= false;
            }
            else
            {
                btnThem.Enabled= true;
                btnSua.Enabled= true;
            }
        }

        

        private void btnXem_Click(object sender, EventArgs e)
        {
            string querySelect = "SELECT * FROM ChiTietHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(querySelect, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dtgvCTHD.DataSource = table;

                connection.Close();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XoaCTHD() == true )
            {
                MessageBox.Show("thêm dữ liệu thành công");
                btnThem_Click(sender,e);
            }
            else
            {
                MessageBox.Show("thêm dữ liệu không thành công");
            }
        }

        public bool XoaCTHD()
        {
            string proc = "prThemCTHD";
            int i;
            
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command = connection.CreateCommand();
                    command.CommandText = proc;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@sMaHD", cbMaHD.SelectedValue);
                    command.Parameters.AddWithValue("@sMaThuoc", cbMaThuoc.SelectedValue);
                    command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.ToString()));
                    command.Parameters.AddWithValue("@iSoLuongMua", Convert.ToInt32(txbSoLuong.ToString()));
                    command.Parameters.AddWithValue("@fMucGiamGia", Convert.ToDouble(txbMucGiamGia.ToString()));

                    i = command.ExecuteNonQuery();

                    connection.Close();


                }

                return i > 0;
           
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvCTHD.CurrentRow.Index;

            cbMaHD.SelectedValue = dtgvCTHD.Rows[index].Cells[0].Value;
            cbMaThuoc.SelectedValue = dtgvCTHD.Rows[index].Cells[1].Value;
            txbDonGia.Text = dtgvCTHD.Rows[index].Cells[2].Value.ToString();
            txbSoLuong.Text = dtgvCTHD.Rows[index].Cells[3].Value.ToString();
            txbMucGiamGia.Text = dtgvCTHD.Rows[index].Cells[4].Value.ToString();
        }
    }
}

