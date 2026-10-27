namespace SchoolApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlNav = new Panel();
            pnlNavLine = new Panel();
            lblBrand = new Label();
            btnNavStudent = new Button();
            btnNavVisitor = new Button();
            pnlStudent = new Panel();
            pnlStudentCard = new Panel();
            pnlVisitor = new Panel();
            pnlVisitorCard = new Panel();

            label1 = new Label();
            label2 = new Label();
            lblClass = new Label();
            lblAddress = new Label();
            lblStudentList = new Label();
            txtName = new TextBox();
            txtNIS = new TextBox();
            txtClass = new TextBox();
            txtAddress = new TextBox();
            txtSearchStudent = new TextBox();
            btnSave = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            dgvData = new DataGridView();

            label3 = new Label();
            label4 = new Label();
            lblVisitorList = new Label();
            txtVisitors = new TextBox();
            txtInstitution = new TextBox();
            btnSaveVisitors = new Button();
            btnUpdateVisitors = new Button();
            btnDeleteVisitors = new Button();
            dgvVisitors = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).BeginInit();
            pnlNav.SuspendLayout();
            pnlStudent.SuspendLayout();
            pnlStudentCard.SuspendLayout();
            pnlVisitor.SuspendLayout();
            pnlVisitorCard.SuspendLayout();
            SuspendLayout();
            //
            // pnlNav (menu navigasi di atas)
            //
            pnlNav.BackColor = Color.FromArgb(6, 13, 36);
            pnlNav.Controls.Add(pnlNavLine);
            pnlNav.Controls.Add(btnNavVisitor);
            pnlNav.Controls.Add(btnNavStudent);
            pnlNav.Controls.Add(lblBrand);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(1000, 60);
            pnlNav.TabIndex = 0;
            //
            // pnlNavLine (garis aksen biru di bawah menu)
            //
            pnlNavLine.BackColor = Color.FromArgb(37, 99, 235);
            pnlNavLine.Dock = DockStyle.Bottom;
            pnlNavLine.Name = "pnlNavLine";
            pnlNavLine.Size = new Size(1000, 2);
            pnlNavLine.TabIndex = 3;
            //
            // lblBrand
            //
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.ForeColor = Color.FromArgb(230, 236, 255);
            lblBrand.Location = new Point(24, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.TabIndex = 2;
            lblBrand.Text = "SCHOOL APP";
            //
            // btnNavStudent
            //
            btnNavStudent.Cursor = Cursors.Hand;
            btnNavStudent.FlatAppearance.BorderSize = 0;
            btnNavStudent.FlatStyle = FlatStyle.Flat;
            btnNavStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNavStudent.Location = new Point(230, 12);
            btnNavStudent.Name = "btnNavStudent";
            btnNavStudent.Size = new Size(130, 36);
            btnNavStudent.TabIndex = 0;
            btnNavStudent.Text = "Students";
            btnNavStudent.UseVisualStyleBackColor = false;
            //
            // btnNavVisitor
            //
            btnNavVisitor.Cursor = Cursors.Hand;
            btnNavVisitor.FlatAppearance.BorderSize = 0;
            btnNavVisitor.FlatStyle = FlatStyle.Flat;
            btnNavVisitor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNavVisitor.Location = new Point(366, 12);
            btnNavVisitor.Name = "btnNavVisitor";
            btnNavVisitor.Size = new Size(130, 36);
            btnNavVisitor.TabIndex = 1;
            btnNavVisitor.Text = "Visitors";
            btnNavVisitor.UseVisualStyleBackColor = false;
            //
            // pnlStudent (halaman Students)
            //
            pnlStudent.BackColor = Color.FromArgb(10, 20, 50);
            pnlStudent.Controls.Add(dgvData);
            pnlStudent.Controls.Add(txtSearchStudent);
            pnlStudent.Controls.Add(lblStudentList);
            pnlStudent.Controls.Add(pnlStudentCard);
            pnlStudent.Dock = DockStyle.Fill;
            pnlStudent.Name = "pnlStudent";
            pnlStudent.TabIndex = 1;
            //
            // pnlStudentCard (kartu form input siswa)
            //
            pnlStudentCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlStudentCard.BackColor = Color.FromArgb(17, 31, 74);
            pnlStudentCard.Controls.Add(btnDeleteStudent);
            pnlStudentCard.Controls.Add(btnUpdateStudent);
            pnlStudentCard.Controls.Add(btnSave);
            pnlStudentCard.Controls.Add(txtAddress);
            pnlStudentCard.Controls.Add(lblAddress);
            pnlStudentCard.Controls.Add(txtClass);
            pnlStudentCard.Controls.Add(lblClass);
            pnlStudentCard.Controls.Add(txtNIS);
            pnlStudentCard.Controls.Add(label2);
            pnlStudentCard.Controls.Add(txtName);
            pnlStudentCard.Controls.Add(label1);
            pnlStudentCard.Location = new Point(20, 20);
            pnlStudentCard.Name = "pnlStudentCard";
            pnlStudentCard.Size = new Size(960, 205);
            pnlStudentCard.TabIndex = 0;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(148, 163, 204);
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "NAMA SISWA";
            //
            // txtName
            //
            txtName.BackColor = Color.FromArgb(24, 41, 92);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(230, 236, 255);
            txtName.Location = new Point(24, 38);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "masukan nama....";
            txtName.Size = new Size(420, 27);
            txtName.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(148, 163, 204);
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.TabIndex = 2;
            label2.Text = "NOMOR INDUK SISWA";
            //
            // txtNIS
            //
            txtNIS.BackColor = Color.FromArgb(24, 41, 92);
            txtNIS.BorderStyle = BorderStyle.FixedSingle;
            txtNIS.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNIS.ForeColor = Color.FromArgb(230, 236, 255);
            txtNIS.Location = new Point(24, 104);
            txtNIS.Name = "txtNIS";
            txtNIS.PlaceholderText = "masukan nis....";
            txtNIS.Size = new Size(420, 27);
            txtNIS.TabIndex = 3;
            //
            // lblClass
            //
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblClass.ForeColor = Color.FromArgb(148, 163, 204);
            lblClass.Location = new Point(480, 16);
            lblClass.Name = "lblClass";
            lblClass.TabIndex = 4;
            lblClass.Text = "KELAS";
            //
            // txtClass
            //
            txtClass.BackColor = Color.FromArgb(24, 41, 92);
            txtClass.BorderStyle = BorderStyle.FixedSingle;
            txtClass.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass.ForeColor = Color.FromArgb(230, 236, 255);
            txtClass.Location = new Point(480, 38);
            txtClass.Name = "txtClass";
            txtClass.PlaceholderText = "contoh: XII RPL 1";
            txtClass.Size = new Size(456, 27);
            txtClass.TabIndex = 5;
            //
            // lblAddress
            //
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.FromArgb(148, 163, 204);
            lblAddress.Location = new Point(480, 82);
            lblAddress.Name = "lblAddress";
            lblAddress.TabIndex = 6;
            lblAddress.Text = "ALAMAT";
            //
            // txtAddress
            //
            txtAddress.BackColor = Color.FromArgb(24, 41, 92);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.FromArgb(230, 236, 255);
            txtAddress.Location = new Point(480, 104);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "masukan alamat....";
            txtAddress.Size = new Size(456, 27);
            txtAddress.TabIndex = 7;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(24, 152);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            //
            // btnUpdateStudent
            //
            btnUpdateStudent.BackColor = Color.FromArgb(30, 64, 175);
            btnUpdateStudent.Cursor = Cursors.Hand;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216);
            btnUpdateStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(162, 152);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(130, 36);
            btnUpdateStudent.TabIndex = 9;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            //
            // btnDeleteStudent
            //
            btnDeleteStudent.BackColor = Color.FromArgb(153, 27, 27);
            btnDeleteStudent.Cursor = Cursors.Hand;
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 29, 29);
            btnDeleteStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            btnDeleteStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteStudent.ForeColor = Color.White;
            btnDeleteStudent.Location = new Point(300, 152);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(130, 36);
            btnDeleteStudent.TabIndex = 10;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            //
            // lblStudentList
            //
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentList.ForeColor = Color.FromArgb(230, 236, 255);
            lblStudentList.Location = new Point(20, 242);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "DAFTAR SISWA";
            //
            // txtSearchStudent
            //
            txtSearchStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchStudent.BackColor = Color.FromArgb(24, 41, 92);
            txtSearchStudent.BorderStyle = BorderStyle.FixedSingle;
            txtSearchStudent.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchStudent.ForeColor = Color.FromArgb(230, 236, 255);
            txtSearchStudent.Location = new Point(660, 240);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.PlaceholderText = "cari nama / NIS / kelas...";
            txtSearchStudent.Size = new Size(320, 27);
            txtSearchStudent.TabIndex = 2;
            //
            // dgvData
            //
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.Location = new Point(20, 282);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(960, 328);
            dgvData.TabIndex = 3;
            //
            // pnlVisitor (halaman Visitors)
            //
            pnlVisitor.BackColor = Color.FromArgb(10, 20, 50);
            pnlVisitor.Controls.Add(dgvVisitors);
            pnlVisitor.Controls.Add(lblVisitorList);
            pnlVisitor.Controls.Add(pnlVisitorCard);
            pnlVisitor.Dock = DockStyle.Fill;
            pnlVisitor.Name = "pnlVisitor";
            pnlVisitor.TabIndex = 2;
            pnlVisitor.Visible = false;
            //
            // pnlVisitorCard (kartu form input visitor)
            //
            pnlVisitorCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlVisitorCard.BackColor = Color.FromArgb(17, 31, 74);
            pnlVisitorCard.Controls.Add(btnDeleteVisitors);
            pnlVisitorCard.Controls.Add(btnUpdateVisitors);
            pnlVisitorCard.Controls.Add(btnSaveVisitors);
            pnlVisitorCard.Controls.Add(txtInstitution);
            pnlVisitorCard.Controls.Add(label4);
            pnlVisitorCard.Controls.Add(txtVisitors);
            pnlVisitorCard.Controls.Add(label3);
            pnlVisitorCard.Location = new Point(20, 20);
            pnlVisitorCard.Name = "pnlVisitorCard";
            pnlVisitorCard.Size = new Size(960, 145);
            pnlVisitorCard.TabIndex = 0;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(148, 163, 204);
            label3.Location = new Point(24, 16);
            label3.Name = "label3";
            label3.TabIndex = 0;
            label3.Text = "NAMA VISITOR";
            //
            // txtVisitors
            //
            txtVisitors.BackColor = Color.FromArgb(24, 41, 92);
            txtVisitors.BorderStyle = BorderStyle.FixedSingle;
            txtVisitors.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtVisitors.ForeColor = Color.FromArgb(230, 236, 255);
            txtVisitors.Location = new Point(24, 38);
            txtVisitors.Name = "txtVisitors";
            txtVisitors.PlaceholderText = "masukan visitors...";
            txtVisitors.Size = new Size(420, 27);
            txtVisitors.TabIndex = 1;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(148, 163, 204);
            label4.Location = new Point(480, 16);
            label4.Name = "label4";
            label4.TabIndex = 2;
            label4.Text = "INSTITUSI";
            //
            // txtInstitution
            //
            txtInstitution.BackColor = Color.FromArgb(24, 41, 92);
            txtInstitution.BorderStyle = BorderStyle.FixedSingle;
            txtInstitution.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstitution.ForeColor = Color.FromArgb(230, 236, 255);
            txtInstitution.Location = new Point(480, 38);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "masukan institusi...";
            txtInstitution.Size = new Size(456, 27);
            txtInstitution.TabIndex = 3;
            //
            // btnSaveVisitors
            //
            btnSaveVisitors.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveVisitors.Cursor = Cursors.Hand;
            btnSaveVisitors.FlatAppearance.BorderSize = 0;
            btnSaveVisitors.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216);
            btnSaveVisitors.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnSaveVisitors.FlatStyle = FlatStyle.Flat;
            btnSaveVisitors.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveVisitors.ForeColor = Color.White;
            btnSaveVisitors.Location = new Point(24, 88);
            btnSaveVisitors.Name = "btnSaveVisitors";
            btnSaveVisitors.Size = new Size(130, 36);
            btnSaveVisitors.TabIndex = 4;
            btnSaveVisitors.Text = "Save";
            btnSaveVisitors.UseVisualStyleBackColor = false;
            //
            // btnUpdateVisitors
            //
            btnUpdateVisitors.BackColor = Color.FromArgb(30, 64, 175);
            btnUpdateVisitors.Cursor = Cursors.Hand;
            btnUpdateVisitors.FlatAppearance.BorderSize = 0;
            btnUpdateVisitors.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216);
            btnUpdateVisitors.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnUpdateVisitors.FlatStyle = FlatStyle.Flat;
            btnUpdateVisitors.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateVisitors.ForeColor = Color.White;
            btnUpdateVisitors.Location = new Point(162, 88);
            btnUpdateVisitors.Name = "btnUpdateVisitors";
            btnUpdateVisitors.Size = new Size(130, 36);
            btnUpdateVisitors.TabIndex = 5;
            btnUpdateVisitors.Text = "Update";
            btnUpdateVisitors.UseVisualStyleBackColor = false;
            //
            // btnDeleteVisitors
            //
            btnDeleteVisitors.BackColor = Color.FromArgb(153, 27, 27);
            btnDeleteVisitors.Cursor = Cursors.Hand;
            btnDeleteVisitors.FlatAppearance.BorderSize = 0;
            btnDeleteVisitors.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 29, 29);
            btnDeleteVisitors.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnDeleteVisitors.FlatStyle = FlatStyle.Flat;
            btnDeleteVisitors.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteVisitors.ForeColor = Color.White;
            btnDeleteVisitors.Location = new Point(300, 88);
            btnDeleteVisitors.Name = "btnDeleteVisitors";
            btnDeleteVisitors.Size = new Size(130, 36);
            btnDeleteVisitors.TabIndex = 6;
            btnDeleteVisitors.Text = "Delete";
            btnDeleteVisitors.UseVisualStyleBackColor = false;
            //
            // lblVisitorList
            //
            lblVisitorList.AutoSize = true;
            lblVisitorList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVisitorList.ForeColor = Color.FromArgb(230, 236, 255);
            lblVisitorList.Location = new Point(20, 182);
            lblVisitorList.Name = "lblVisitorList";
            lblVisitorList.TabIndex = 1;
            lblVisitorList.Text = "DAFTAR VISITOR";
            //
            // dgvVisitors
            //
            dgvVisitors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVisitors.Location = new Point(20, 218);
            dgvVisitors.Name = "dgvVisitors";
            dgvVisitors.Size = new Size(960, 392);
            dgvVisitors.TabIndex = 2;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 20, 50);
            ClientSize = new Size(1000, 670);
            Controls.Add(pnlStudent);
            Controls.Add(pnlVisitor);
            Controls.Add(pnlNav);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School App";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).EndInit();
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            pnlStudent.ResumeLayout(false);
            pnlStudent.PerformLayout();
            pnlStudentCard.ResumeLayout(false);
            pnlStudentCard.PerformLayout();
            pnlVisitor.ResumeLayout(false);
            pnlVisitor.PerformLayout();
            pnlVisitorCard.ResumeLayout(false);
            pnlVisitorCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Panel pnlNavLine;
        private Label lblBrand;
        private Button btnNavStudent;
        private Button btnNavVisitor;
        private Panel pnlStudent;
        private Panel pnlStudentCard;
        private Panel pnlVisitor;
        private Panel pnlVisitorCard;

        private Label label1;
        private Label label2;
        private Label lblClass;
        private Label lblAddress;
        private Label lblStudentList;
        private TextBox txtName;
        private TextBox txtNIS;
        private TextBox txtClass;
        private TextBox txtAddress;
        private TextBox txtSearchStudent;
        private Button btnSave;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private DataGridView dgvData;

        private Label label3;
        private Label label4;
        private Label lblVisitorList;
        private TextBox txtVisitors;
        private TextBox txtInstitution;
        private Button btnSaveVisitors;
        private Button btnUpdateVisitors;
        private Button btnDeleteVisitors;
        private DataGridView dgvVisitors;
    }
}
