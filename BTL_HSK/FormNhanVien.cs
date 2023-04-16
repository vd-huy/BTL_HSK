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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            txbMaNV_TextChanged(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string querySelect = "SELECT * FROM vvSelectNV";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(querySelect, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dtgvNhanVien.DataSource = table;

                connection.Close();
            }
        }

        private void txbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txbLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }

        }


        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txbPhuCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void txbMaNV_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbMaNV.Text) || string.IsNullOrEmpty(txbTenNV.Text) || string.IsNullOrEmpty(txbLuongCoBan.Text) || string.IsNullOrEmpty(txbDiaChi.Text) || string.IsNullOrEmpty(txbSDT.Text) || string.IsNullOrEmpty(txbPhuCap.Text))
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private bool ThemNhanVien() 
        {
            int i = 0;
            string prThemNhanVien = "prThemNhanVien";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandText = prThemNhanVien;
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);
                Command.Parameters.AddWithValue("@sTenNV", txbTenNV.Text);

                if (rbNam.Checked)
                {
                    Command.Parameters.AddWithValue("@bGioiTinh", true);
                }else
                {
                    Command.Parameters.AddWithValue("@bGioiTinh", false);

                }
                Command.Parameters.AddWithValue("@sDiaChi", txbDiaChi.Text);
                Command.Parameters.AddWithValue("@sDienThoai", txbSDT.Text);
                Command.Parameters.AddWithValue("@dNgaySinh", dtpNgaySinh.Value);
                Command.Parameters.AddWithValue("@fLuongCoBan", Convert.ToDouble(txbLuongCoBan.Text));
                Command.Parameters.AddWithValue("@fPhuCap", Convert.ToDouble(txbPhuCap.Text));

                i = Command.ExecuteNonQuery();
                connection.Close();
            }
                

            return (i>0);
        }

        public bool KiemTraNVTonTai()
        {
            bool check = false;
            string query = "CheckNhanVien";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;

                command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    check = true;
                }else
                {
                    check = false;
                }

                connection.Close();
            }
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraNVTonTai() == false)
            {
                if (ThemNhanVien())
                {
                    MessageBox.Show("them du lieu thanh cong");
                    btnXem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("them khong du lieu thanh cong");
                }
            }else
            {
                MessageBox.Show("Ma nhan vien da ton tai");
            }
            
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvNhanVien.CurrentRow.Index;

            txbMaNV.Text = dtgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txbTenNV.Text = dtgvNhanVien.Rows[index].Cells[1].Value.ToString();
            bool GioiTinh = Convert.ToBoolean(dtgvNhanVien.Rows[index].Cells[2].Value);
            if(GioiTinh == false)
            {
                rbNu.Checked= true;
            }
            else
            {
                rbNam.Checked= true;
            }
            txbDiaChi.Text = dtgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txbSDT.Text = dtgvNhanVien.Rows[index].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dtgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txbLuongCoBan.Text = dtgvNhanVien.Rows[index].Cells[6].Value.ToString();
            txbPhuCap.Text = dtgvNhanVien.Rows[index].Cells[7].Value.ToString();





        }
    }
}
