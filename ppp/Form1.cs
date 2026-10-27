using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        // Koneksi default XAMPP: user root, tanpa password, port 3306.
        // Kalau root di XAMPP kamu sudah diberi password, isi di bagian password=
        private string connectionString =
            "server=localhost;port=3306;user=root;password=;database=pi_school;";

        // Warna tema biru tua
        private static readonly Color NavBg = Color.FromArgb(6, 13, 36);
        private static readonly Color NavHover = Color.FromArgb(17, 31, 74);
        private static readonly Color Accent = Color.FromArgb(37, 99, 235);
        private static readonly Color AccentHover = Color.FromArgb(59, 130, 246);
        private static readonly Color TextLight = Color.FromArgb(230, 236, 255);
        private static readonly Color TextMuted = Color.FromArgb(148, 163, 204);

        private int studentId = 0;
        private int visitorId = 0;

        private enum Page
        {
            Student,
            Visitor
        }

        public Form1()
        {
            InitializeComponent();

            ApplyGridTheme(dgvData);
            ApplyGridTheme(dgvVisitors);

            btnNavStudent.Click += (s, e) => Navigate(Page.Student);
            btnNavVisitor.Click += (s, e) => Navigate(Page.Visitor);

            btnSave.Click += btnSave_Click;
            btnSaveVisitors.Click += btnSaveVisitors_Click;

            btnUpdateStudent.Click += btnUpdateStudent_Click;
            btnDeleteStudent.Click += btnDeleteStudent_Click;

            btnUpdateVisitors.Click += btnUpdateVisitors_Click;
            btnDeleteVisitors.Click += btnDeleteVisitors_Click;

            dgvData.CellClick += dgvData_CellClick;
            dgvVisitors.CellClick += dgvVisitors_CellClick;

            
            txtSearchStudent.TextChanged += (s, e) =>
                ShowData(txtSearchStudent.Text.Trim());

            Navigate(Page.Student); 
        }

        private void Navigate(Page page)
        {
            pnlStudent.Visible = page == Page.Student;
            pnlVisitor.Visible = page == Page.Visitor;

            
            SetNavButton(btnNavStudent, page == Page.Student);
            SetNavButton(btnNavVisitor, page == Page.Visitor);

            if (page == Page.Student)
            {
                Text = "School App - Students";
                ShowData(txtSearchStudent.Text.Trim());
            }
            else
            {
                Text = "School App - Visitors";
                ShowVisitors();
            }
        }

        private void SetNavButton(Button btn, bool active)
        {
            btn.BackColor = active ? Accent : NavBg;
            btn.ForeColor = active ? Color.White : TextMuted;
            btn.FlatAppearance.MouseOverBackColor = active ? AccentHover : NavHover;
        }

        private static void ApplyGridTheme(DataGridView g)
        {
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersVisible = false;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Color.FromArgb(12, 24, 58);
            g.GridColor = Color.FromArgb(30, 45, 94);
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 38;
            g.RowTemplate.Height = 32;

            g.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(30, 58, 138),
                ForeColor = TextLight,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                SelectionBackColor = Color.FromArgb(30, 58, 138),
                SelectionForeColor = TextLight,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 8, 0)
            };

            g.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(12, 24, 58),
                ForeColor = TextLight,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                SelectionBackColor = Accent,
                SelectionForeColor = Color.White,
                Padding = new Padding(8, 0, 8, 0)
            };

            g.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(16, 30, 70)
            };
        }

        private void ShowData(string keyword = "")
        {
            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "SELECT id, nis, name, class_name, address " +
                    "FROM students " +
                    "WHERE name LIKE @k OR nis LIKE @k OR class_name LIKE @k " +
                    "ORDER BY name";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@k", "%" + keyword + "%");

                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dgvData.DataSource = tabel;

                dgvData.Columns["id"].Visible = false;
                dgvData.Columns["nis"].HeaderText = "NIS";
                dgvData.Columns["nis"].FillWeight = 60;
                dgvData.Columns["name"].HeaderText = "Nama";
                dgvData.Columns["class_name"].HeaderText = "Kelas";
                dgvData.Columns["address"].HeaderText = "Alamat";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void ClearStudentForm()
        {
            txtName.Clear();
            txtNIS.Clear();
            txtClass.Clear();
            txtAddress.Clear();
            studentId = 0;
        }

        private bool StudentFormValid()
        {
            if (txtName.Text.Trim() == "" ||
                txtNIS.Text.Trim() == "" ||
                txtClass.Text.Trim() == "")
            {
                MessageBox.Show("Nama, NIS, dan Kelas tidak boleh kosong");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!StudentFormValid())
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "INSERT INTO students (name, nis, class_name, address) " +
                    "VALUES (@name, @nis, @class, @address)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@nis", txtNIS.Text.Trim());
                cmd.Parameters.AddWithValue("@class", txtClass.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil disimpan");

                ClearStudentForm();
                ShowData(txtSearchStudent.Text.Trim());
            }
            catch (MySqlException ex)
            {
                
                if (ex.Number == 1062)
                    MessageBox.Show("NIS sudah terdaftar");
                else
                    MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void dgvData_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];

            studentId = Convert.ToInt32(row.Cells["id"].Value);
            txtNIS.Text = row.Cells["nis"].Value?.ToString() ?? "";
            txtName.Text = row.Cells["name"].Value?.ToString() ?? "";
            txtClass.Text = row.Cells["class_name"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["address"].Value?.ToString() ?? "";
        }

        private void btnUpdateStudent_Click(object? sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            if (!StudentFormValid())
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "UPDATE students SET name = @name, nis = @nis, " +
                    "class_name = @class, address = @address WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@nis", txtNIS.Text.Trim());
                cmd.Parameters.AddWithValue("@class", txtClass.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                    MessageBox.Show("Data student berhasil diupdate");
                else
                    MessageBox.Show("Data student tidak ditemukan");

                ClearStudentForm();
                ShowData(txtSearchStudent.Text.Trim());
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("NIS sudah dipakai siswa lain");
                else
                    MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object? sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data student ini?",
                "Konfirmasi Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "DELETE FROM students WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil dihapus");

                ClearStudentForm();
                ShowData(txtSearchStudent.Text.Trim());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void ShowVisitors()
        {
            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "SELECT id, visitors, institution FROM visitors";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dgvVisitors.DataSource = tabel;

                dgvVisitors.Columns["id"].Visible = false;
                dgvVisitors.Columns["visitors"].HeaderText = "Nama Visitor";
                dgvVisitors.Columns["institution"].HeaderText = "Institusi";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnSaveVisitors_Click(object? sender, EventArgs e)
        {
            string nama = txtVisitors.Text.Trim();
            string instansi = txtInstitution.Text.Trim();

            if (nama == "" || instansi == "")
            {
                MessageBox.Show("Visitor dan institution tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "INSERT INTO visitors (visitors, institution) " +
                    "VALUES (@visitors, @institution)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@visitors", nama);
                cmd.Parameters.AddWithValue("@institution", instansi);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data visitor berhasil disimpan");

                txtVisitors.Clear();
                txtInstitution.Clear();

                visitorId = 0;
                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void dgvVisitors_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvVisitors.Rows[e.RowIndex];

            visitorId = Convert.ToInt32(row.Cells["id"].Value);
            txtVisitors.Text = row.Cells["visitors"].Value?.ToString() ?? "";
            txtInstitution.Text = row.Cells["institution"].Value?.ToString() ?? "";
        }

        private void btnUpdateVisitors_Click(object? sender, EventArgs e)
        {
            string nama = txtVisitors.Text.Trim();
            string instansi = txtInstitution.Text.Trim();

            if (visitorId == 0)
            {
                MessageBox.Show("Pilih visitor dari tabel terlebih dahulu");
                return;
            }

            if (nama == "" || instansi == "")
            {
                MessageBox.Show("Visitor dan institution tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "UPDATE visitors SET visitors = @visitors, " +
                    "institution = @institution WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@visitors", nama);
                cmd.Parameters.AddWithValue("@institution", instansi);
                cmd.Parameters.AddWithValue("@id", visitorId);

                conn.Open();
                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                    MessageBox.Show("Data visitor berhasil diupdate");
                else
                    MessageBox.Show("Data visitor tidak ditemukan");

                txtVisitors.Clear();
                txtInstitution.Clear();
                visitorId = 0;

                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnDeleteVisitors_Click(object? sender, EventArgs e)
        {
            if (visitorId == 0)
            {
                MessageBox.Show("Pilih visitor dari tabel terlebih dahulu");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data visitor ini?",
                "Konfirmasi Delete Visitor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "DELETE FROM visitors WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", visitorId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data visitor berhasil dihapus");

                txtVisitors.Clear();
                txtInstitution.Clear();
                visitorId = 0;

                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }
    }
}
