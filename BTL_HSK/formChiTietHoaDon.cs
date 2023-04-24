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

        //string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";

        private void formChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //string queryNhaCungCap = "SELECT * FROM vvNhaCungCap";

            //using (SqlConnection connection = new SqlConnection(connectionSTR))
            //{
            //    // mở kết nối
            //    connection.Open();

            //    SqlCommand command = new SqlCommand(queryNhaCungCap, connection);
            //    SqlDataReader reader = command.ExecuteReader();

            //    // dùng datatable để load dữ liệu của SqlDataReader
            //    DataTable table = new DataTable();
            //    table.Load(reader);
            //    cbMaNCC.DataSource = table;
            //    cbMaNCC.DisplayMember = "sMaKH";
            //    cbMaNCC.ValueMember = "sMaKH";

            //    cbMaNCCSearch.DataSource = table;
            //    cbMaNCCSearch.DisplayMember = "sMaKH";
            //    cbMaNCCSearch.ValueMember = "sMaKH";

            //    // đóng kết nối
            //    connection.Close();


            }
        }
    }

