using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BTL_HSK
{
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();

        }
        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {

            string queryNhaCungCap = "SELECT * FROM vvNhaCungCap";
            
            using (SqlConnection connection= new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(queryNhaCungCap, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table= new DataTable();
                table.Load(reader);
                cbMaNCC.DataSource = table;
                cbMaNCC.DisplayMember= "sMaKH";
                cbMaNCC.ValueMember= "sMaKH";

                // đóng kết nối
                connection.Close();


            }

            txbMaThuoc_TextChanged(sender, e);



        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string SelectThuoc = "SELECT * FROM vvSelectThuoc";
    
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(SelectThuoc, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tableThuoc = new DataTable();

                adapter.Fill(tableThuoc);
                dtgvThuoc.DataSource = tableThuoc;

                // đóng kết nối
                connection.Close();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraMaThuocTonTai() == false)
            {
                if (ThemDuLieuThuoc() > 0)
                {
                    MessageBox.Show("them du lieu thanh cong");
                    btnXem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("them du lieu khong thanh cong");
                }
            }else MessageBox.Show("Ma thuoc da ton tai");


        }

        public int ThemDuLieuThuoc()
        {
            string procThemThuoc = "prThemThuoc";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procThemThuoc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaThuoc", txbMaThuoc.Text);
                command.Parameters.AddWithValue("@sTenThuoc", txbTenThuoc.Text);
                command.Parameters.AddWithValue("@sMaNCC", cbMaNCC.SelectedValue);
                command.Parameters.AddWithValue("@dHanSuDung", dtpHSD.Value);
                command.Parameters.AddWithValue("@iSoLuong", Convert.ToInt32(txbSoLuong.Text));
                command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));

                // trả về số dữ liệu được insert vào bảng 
                i = command.ExecuteNonQuery();

                // đóng kết nối
                connection.Close();

            }

            return i;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(XoaThuocTheoMa(dtgvThuoc)) {
                MessageBox.Show("xoa du lieu thanh cong");
                btnXem_Click(sender, e);
            }
           else
            {
                MessageBox.Show("xoa du lieu khong thanh cong");
            }
        }

        public bool XoaThuocTheoMa(DataGridView data)
        {
            string procXoaID = "prXoaTheoMaThuoc";
            int i;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procXoaID;
                command.CommandType = CommandType.StoredProcedure;

                string MaThuoc = data.SelectedCells[0].OwningRow.Cells["sMaThuoc"].Value.ToString();
                command.Parameters.AddWithValue("@sMaThuoc", MaThuoc);
              i = command.ExecuteNonQuery();

            }

            return (i > 0);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SuaDuLieuThuoc(dtgvThuoc))
            {
                MessageBox.Show("cap nhat du lieu thanh cong");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("cap nhat du lieu khong thanh cong");
            }
        }

        // khi bấm vào ô muốn sửa dữ liệu thì tất cả dữ liệu của bản ghi sẽ hiện lên ở các textbox combobox 
        private void dtgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvThuoc.CurrentRow.Index;

            txbMaThuoc.Text = dtgvThuoc.Rows[index].Cells[0].Value.ToString();
            txbTenThuoc.Text = dtgvThuoc.Rows[index].Cells[1].Value.ToString();
            cbMaNCC.SelectedValue = dtgvThuoc.Rows[index].Cells[2].Value;
            dtpHSD.Text = dtgvThuoc.Rows[index].Cells[3].Value.ToString();
            txbSoLuong.Text = dtgvThuoc.Rows[index].Cells[4].Value.ToString();
            txbDonGia.Text = dtgvThuoc.Rows[index].Cells[5].Value.ToString();
        }


        public bool SuaDuLieuThuoc (DataGridView data)
        {
            string procSuaThuoc = "prSuaThuoc";
            int i;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procSuaThuoc;
                command.CommandType = CommandType.StoredProcedure;


             
                
                    command.Parameters.AddWithValue("@sMaThuoc", txbMaThuoc.Text);
                    command.Parameters.AddWithValue("@sTenThuoc", txbTenThuoc.Text);
                    command.Parameters.AddWithValue("@sMaNCC", cbMaNCC.SelectedValue);
                    command.Parameters.AddWithValue("@dHanSuDung", dtpHSD.Value);
                    command.Parameters.AddWithValue("@iSoLuong", Convert.ToInt32(txbSoLuong.Text));
                    command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));
                 
                


                i = command.ExecuteNonQuery();

                connection.Close();

            }

            return (i > 0);
        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm được nhập số và . vào textbox
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ được nhập số vào textbox
            if(!char.IsDigit(e.KeyChar) &&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }

        private void txbMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ được nhập số và chữ trong textbox
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ đươc nhập chữ vào textbox
            if (!((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == 8)))
            {
                e.Handled = true;
            }
        }

        public bool KiemTraMaThuocTonTai()
        {
            string checkMaThuoc = "checkMaThuoc ";
            bool check;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = checkMaThuoc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@sMaThuoc" , txbMaThuoc.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    check = true;
                }
                else check= false;
                // đóng kết nối
                connection.Close();

            }

            return check;
            
        }

        private void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string prTimKiemThuocTheoMa = "prTimKiemThuocTheoMa";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = prTimKiemThuocTheoMa;
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                command.Parameters.AddWithValue("@sMaThuoc", txbTimKiem.Text);

                adapter.Fill(table);
                

                if(table.Rows.Count <= 0)
                {
                    MessageBox.Show("khong co loai thuoc muon tim");
                }else
                {
                    dtgvThuoc.DataSource = table;
                }

                // đóng kết nối
                connection.Close();

            }
        }

        private void txbMaThuoc_TextChanged(object sender, EventArgs e)
        {
            
                // kiểm tra nếu ít nhất 1 trong 4 textbox không có dữ liệu thì vô hiệu hóa các nút button
                if (string.IsNullOrEmpty(txbMaThuoc.Text) ||
                    string.IsNullOrEmpty(txbTenThuoc.Text) ||
                    string.IsNullOrEmpty(txbSoLuong.Text) ||
                    string.IsNullOrEmpty(txbDonGia.Text))
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

     
<<<<<<< HEAD
     
=======
        //hello xin chào thất cả các bạn
>>>>>>> b9e054000cac2b5c17d7fd3808ae629699d8de60

    }
}
