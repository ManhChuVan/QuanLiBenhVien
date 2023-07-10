using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    class RefreshDGV
    {
        private string connectionString;
        public RefreshDGV(string connectionString)
        {
            this.connectionString = connectionString;
        }


        internal void Refresh_DGV(string view, DataGridView dgv)
        {
            string query = "SELECT * FROM " + view;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu từ view: " + ex.Message);
            }
        }
    }
}
