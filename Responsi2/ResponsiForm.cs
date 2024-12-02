using Npgsql;
using System.Data;

namespace Responsi2
{
    public partial class ResponsiForm : Form
    {
        public ResponsiForm()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost, Port=5432, Username=postgres, Password=informatika, Database=ResponsiDB";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void ResponsiForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from select_karyawan()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from add_karyawan(:in_id_karyawan, :in_nama_karyawan, :in_id_dep, :in_id_jabatan, :salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("in_nama_karyawan", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("in_id_dep", cbDepKaryawan.Text);
                cmd.Parameters.AddWithValue("in_id_jabatan", cbJabKaryawan.Text);
                cmd.Parameters.AddWithValue("salary", tbGaji.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil diinputkan", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ResponsiForm_Load(sender, e);
                    tbNamaKaryawan.Text = cbDepKaryawan.Text = cbJabKaryawan.Text = tbGaji.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNamaKaryawan.Text = r.Cells["Nama Karyawan"].Value.ToString();
                cbDepKaryawan.Text = r.Cells["id_dep"].Value.ToString();
                cbJabKaryawan.Text = r.Cells["id_jab"].Value.ToString();
                tbGaji.Text = r.Cells["Gaji"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di edit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from edit_karyawan(:in_id_karyawan, :in_nama_karyawan, :in_id_dep, :in_id_jabatan, :salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("in_nama_karyawan", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("in_id_dep", cbDepKaryawan.Text);
                cmd.Parameters.AddWithValue("in_id_jabatan", cbJabKaryawan.Text);
                cmd.Parameters.AddWithValue("salary", tbGaji.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil diupdate", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ResponsiForm_Load(sender, e);
                    tbNamaKaryawan.Text = cbDepKaryawan.Text = cbJabKaryawan.Text = tbGaji.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from delete_karyawan(:in_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil dihapus", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ResponsiForm_Load(sender, e);
                    tbNamaKaryawan.Text = cbDepKaryawan.Text = cbJabKaryawan.Text = tbGaji.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
