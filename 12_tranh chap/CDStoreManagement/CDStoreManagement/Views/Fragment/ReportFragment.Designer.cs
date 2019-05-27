using System.Windows.Forms;

namespace CDStoreManagement.Views.Activities
{
    partial class ReportFragment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFragment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFillMonth = new System.Windows.Forms.DateTimePicker();
            this.dtFillDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rdMonth = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdnDay = new MaterialSkin.Controls.MaterialRadioButton();
            this.card1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabThue = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThueDia = new System.Windows.Forms.DataGridView();
            this.tabMua = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMuaDia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalRevue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabThue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueDia)).BeginInit();
            this.tabMua.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuaDia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.dtFillMonth);
            this.panel1.Controls.Add(this.dtFillDate);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.rdMonth);
            this.panel1.Controls.Add(this.rdnDay);
            this.panel1.Controls.Add(this.card1);
            this.panel1.Location = new System.Drawing.Point(5, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 193);
            this.panel1.TabIndex = 2;
            // 
            // dtFillMonth
            // 
            this.dtFillMonth.CustomFormat = "MM - yyyy";
            this.dtFillMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFillMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtFillMonth.Location = new System.Drawing.Point(166, 101);
            this.dtFillMonth.Name = "dtFillMonth";
            this.dtFillMonth.Size = new System.Drawing.Size(200, 20);
            this.dtFillMonth.TabIndex = 5;
            // 
            // dtFillDate
            // 
            this.dtFillDate.CustomFormat = "dd - MM - yyyy";
            this.dtFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFillDate.Location = new System.Drawing.Point(166, 68);
            this.dtFillDate.Name = "dtFillDate";
            this.dtFillDate.Size = new System.Drawing.Size(200, 20);
            this.dtFillDate.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 5;
            this.btnReset.ButtonText = "Reset";
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
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(247, 141);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(132, 39);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 5;
            this.btnFilter.ButtonText = "Lọc";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFilter.Iconimage")));
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 90D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(77, 141);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(132, 39);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Depth = 0;
            this.rdMonth.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdMonth.Location = new System.Drawing.Point(55, 91);
            this.rdMonth.Margin = new System.Windows.Forms.Padding(0);
            this.rdMonth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Ripple = true;
            this.rdMonth.Size = new System.Drawing.Size(99, 30);
            this.rdMonth.TabIndex = 2;
            this.rdMonth.TabStop = true;
            this.rdMonth.Text = "Theo tháng";
            this.rdMonth.UseVisualStyleBackColor = true;
            this.rdMonth.CheckedChanged += new System.EventHandler(this.rdMonth_CheckedChanged);
            // 
            // rdnDay
            // 
            this.rdnDay.AutoSize = true;
            this.rdnDay.Depth = 0;
            this.rdnDay.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdnDay.Location = new System.Drawing.Point(55, 61);
            this.rdnDay.Margin = new System.Windows.Forms.Padding(0);
            this.rdnDay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdnDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdnDay.Name = "rdnDay";
            this.rdnDay.Ripple = true;
            this.rdnDay.Size = new System.Drawing.Size(93, 30);
            this.rdnDay.TabIndex = 2;
            this.rdnDay.TabStop = true;
            this.rdnDay.Text = "Theo ngày ";
            this.rdnDay.UseVisualStyleBackColor = true;
            this.rdnDay.CheckedChanged += new System.EventHandler(this.rdnDay_CheckedChanged);
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Controls.Add(this.pictureBox1);
            this.card1.Controls.Add(this.bunifuCustomLabel2);
            this.card1.Dock = System.Windows.Forms.DockStyle.Top;
            this.card1.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.card1.GradientBottomRight = System.Drawing.Color.Cyan;
            this.card1.GradientTopLeft = System.Drawing.Color.Orchid;
            this.card1.GradientTopRight = System.Drawing.Color.Orchid;
            this.card1.Location = new System.Drawing.Point(0, 0);
            this.card1.Name = "card1";
            this.card1.Quality = 50;
            this.card1.Size = new System.Drawing.Size(440, 44);
            this.card1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CDStoreManagement.Properties.Resources.icons8_fill_color_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(51, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 20);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Lọc dữ liệu";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuGradientPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 55);
            this.panel3.TabIndex = 2;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 50;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(900, 55);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(397, -1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 48);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Thành viên\r\nBáo cáo";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.Location = new System.Drawing.Point(451, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 193);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbTotalRevue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.ButtonText = "Xuất báo cáo";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(153, 140);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(188, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Xuất báo cáo";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Orchid;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Orchid;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 50;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(446, 44);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CDStoreManagement.Properties.Resources.icons8_result_50;
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(51, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 20);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Kết quả lọc";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabThue);
            this.tabControl1.Controls.Add(this.tabMua);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 267);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 347);
            this.tabControl1.TabIndex = 3;
            // 
            // tabThue
            // 
            this.tabThue.Controls.Add(this.groupBox1);
            this.tabThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThue.Location = new System.Drawing.Point(4, 25);
            this.tabThue.Name = "tabThue";
            this.tabThue.Padding = new System.Windows.Forms.Padding(3);
            this.tabThue.Size = new System.Drawing.Size(892, 318);
            this.tabThue.TabIndex = 0;
            this.tabThue.Text = "Thuê đĩa";
            this.tabThue.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThueDia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 312);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuê đĩa";
            // 
            // dgvThueDia
            // 
            this.dgvThueDia.AllowUserToAddRows = false;
            this.dgvThueDia.AllowUserToDeleteRows = false;
            this.dgvThueDia.AllowUserToResizeColumns = false;
            this.dgvThueDia.AllowUserToResizeRows = false;
            this.dgvThueDia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThueDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThueDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThueDia.Location = new System.Drawing.Point(3, 16);
            this.dgvThueDia.Name = "dgvThueDia";
            this.dgvThueDia.Size = new System.Drawing.Size(880, 293);
            this.dgvThueDia.TabIndex = 0;
            // 
            // tabMua
            // 
            this.tabMua.Controls.Add(this.groupBox3);
            this.tabMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMua.Location = new System.Drawing.Point(4, 25);
            this.tabMua.Name = "tabMua";
            this.tabMua.Padding = new System.Windows.Forms.Padding(3);
            this.tabMua.Size = new System.Drawing.Size(892, 318);
            this.tabMua.TabIndex = 1;
            this.tabMua.Text = "Mua Đĩa";
            this.tabMua.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMuaDia);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 312);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mua đĩa";
            // 
            // dgvMuaDia
            // 
            this.dgvMuaDia.AllowUserToAddRows = false;
            this.dgvMuaDia.AllowUserToDeleteRows = false;
            this.dgvMuaDia.AllowUserToResizeColumns = false;
            this.dgvMuaDia.AllowUserToResizeRows = false;
            this.dgvMuaDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuaDia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMuaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuaDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuaDia.Location = new System.Drawing.Point(3, 16);
            this.dgvMuaDia.Name = "dgvMuaDia";
            this.dgvMuaDia.Size = new System.Drawing.Size(880, 293);
            this.dgvMuaDia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Fuchsia;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Location = new System.Drawing.Point(186, 16);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(107, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "28 - 02 - 2018";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doanh thu :";
            // 
            // lbTotalRevue
            // 
            this.lbTotalRevue.AutoSize = true;
            this.lbTotalRevue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevue.ForeColor = System.Drawing.Color.Red;
            this.lbTotalRevue.Location = new System.Drawing.Point(180, 54);
            this.lbTotalRevue.Name = "lbTotalRevue";
            this.lbTotalRevue.Size = new System.Drawing.Size(121, 24);
            this.lbTotalRevue.TabIndex = 3;
            this.lbTotalRevue.Text = "825,000,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(326, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "đ";
            // 
            // ReportFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ReportFragment";
            this.Size = new System.Drawing.Size(900, 614);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabThue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueDia)).EndInit();
            this.tabMua.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuaDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private MaterialSkin.Controls.MaterialRadioButton rdMonth;
        private MaterialSkin.Controls.MaterialRadioButton rdnDay;
        private Bunifu.Framework.UI.BunifuGradientPanel card1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThueDia;
        private System.Windows.Forms.TabPage tabMua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMuaDia;
        private System.Windows.Forms.DateTimePicker dtFillMonth;
        private System.Windows.Forms.DateTimePicker dtFillDate;
        private Label label1;
        private Label lbTime;
        private Label label2;
        private Label lbTotalRevue;
        private Label label3;
    }
}
