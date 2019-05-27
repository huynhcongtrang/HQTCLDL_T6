namespace CDStoreManagement.Utils.StatisticaFunction
{
    partial class DetailStatisticalMonth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailStatisticalMonth));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhthu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCLose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExportExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(300, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(200, 39);
            this.bunifuCustomLabel1.TabIndex = 123;
            this.bunifuCustomLabel1.Text = "Thống kê doanh thu\r\n";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoanhthu);
            this.groupBox1.Location = new System.Drawing.Point(11, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 100);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng doanh thu";
            // 
            // dgvDoanhthu
            // 
            this.dgvDoanhthu.AllowUserToAddRows = false;
            this.dgvDoanhthu.AllowUserToDeleteRows = false;
            this.dgvDoanhthu.AllowUserToResizeColumns = false;
            this.dgvDoanhthu.AllowUserToResizeRows = false;
            this.dgvDoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhthu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhthu.Enabled = false;
            this.dgvDoanhthu.Location = new System.Drawing.Point(3, 16);
            this.dgvDoanhthu.Name = "dgvDoanhthu";
            this.dgvDoanhthu.Size = new System.Drawing.Size(778, 78);
            this.dgvDoanhthu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CDStoreManagement.Properties.Resources._5d8image_1475657664165;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.Image = global::CDStoreManagement.Properties.Resources.icons8_delete_64;
            this.btnCLose.ImageActive = null;
            this.btnCLose.Location = new System.Drawing.Point(764, 9);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(33, 30);
            this.btnCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCLose.TabIndex = 125;
            this.btnCLose.TabStop = false;
            this.btnCLose.Zoom = 10;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.BorderRadius = 0;
            this.btnExportExcel.ButtonText = "Lưu excel";
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_add_new_64;
            this.btnExportExcel.Iconimage_right = null;
            this.btnExportExcel.Iconimage_right_Selected = null;
            this.btnExportExcel.Iconimage_Selected = null;
            this.btnExportExcel.IconMarginLeft = 0;
            this.btnExportExcel.IconMarginRight = 0;
            this.btnExportExcel.IconRightVisible = true;
            this.btnExportExcel.IconRightZoom = 0D;
            this.btnExportExcel.IconVisible = true;
            this.btnExportExcel.IconZoom = 90D;
            this.btnExportExcel.IsTab = false;
            this.btnExportExcel.Location = new System.Drawing.Point(673, 73);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExportExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExportExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExportExcel.selected = false;
            this.btnExportExcel.Size = new System.Drawing.Size(115, 32);
            this.btnExportExcel.TabIndex = 126;
            this.btnExportExcel.Text = "Lưu excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Textcolor = System.Drawing.Color.White;
            this.btnExportExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnShow
            // 
            this.btnShow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.BorderRadius = 0;
            this.btnShow.ButtonText = "Xem";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DisabledColor = System.Drawing.Color.Gray;
            this.btnShow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShow.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShow.Iconimage")));
            this.btnShow.Iconimage_right = null;
            this.btnShow.Iconimage_right_Selected = null;
            this.btnShow.Iconimage_Selected = null;
            this.btnShow.IconMarginLeft = 0;
            this.btnShow.IconMarginRight = 0;
            this.btnShow.IconRightVisible = true;
            this.btnShow.IconRightZoom = 0D;
            this.btnShow.IconVisible = true;
            this.btnShow.IconZoom = 90D;
            this.btnShow.IsTab = false;
            this.btnShow.Location = new System.Drawing.Point(232, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnShow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShow.selected = false;
            this.btnShow.Size = new System.Drawing.Size(92, 32);
            this.btnShow.TabIndex = 130;
            this.btnShow.Text = "Xem";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Textcolor = System.Drawing.Color.White;
            this.btnShow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Làm mới";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_synchronize_64;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 70D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(345, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 131;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 228);
            this.panel1.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(804, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 228);
            this.panel2.TabIndex = 133;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(0, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 134;
            // 
            // DetailStatisticalMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 228);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnExportExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailStatisticalMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailStatisticalMonth";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCLose;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDoanhthu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnShow;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}