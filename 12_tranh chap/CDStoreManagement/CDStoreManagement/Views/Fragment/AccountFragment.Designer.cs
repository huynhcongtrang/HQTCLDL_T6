namespace CDStoreManagement.Views.Activities
{
    partial class AccountFragment
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
            this.components = new System.ComponentModel.Container();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbfill = new System.Windows.Forms.ComboBox();
            this.lbNameAdmin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalUserStock = new System.Windows.Forms.Label();
            this.lbTotalUserSell = new System.Windows.Forms.Label();
            this.lbTotalUserAdmin = new System.Windows.Forms.Label();
            this.lbTotalUser = new System.Windows.Forms.Label();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDetailEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb = new System.Windows.Forms.Label();
            this.lbNotifi = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtgvEvent = new System.Windows.Forms.DataGridView();
            this.ImageAdmin = new CDStoreManagement.Utils.CircleImageBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(16, 253);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(187, 20);
            this.bunifuCustomLabel13.TabIndex = 36;
            this.bunifuCustomLabel13.Text = "Chức năng nhân viên :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(589, 255);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(41, 18);
            this.materialLabel8.TabIndex = 32;
            this.materialLabel8.Text = "Lọc :";
            // 
            // cbbfill
            // 
            this.cbbfill.FormattingEnabled = true;
            this.cbbfill.Items.AddRange(new object[] {
            "Tất cả",
            "Nhân viên",
            "Nhân viên kho"});
            this.cbbfill.Location = new System.Drawing.Point(636, 254);
            this.cbbfill.Name = "cbbfill";
            this.cbbfill.Size = new System.Drawing.Size(145, 21);
            this.cbbfill.TabIndex = 33;
            this.cbbfill.Text = "Tất cả";
            this.cbbfill.SelectedIndexChanged += new System.EventHandler(this.cbbfill_SelectedIndexChanged);
            // 
            // lbNameAdmin
            // 
            this.lbNameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameAdmin.AutoSize = true;
            this.lbNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAdmin.Location = new System.Drawing.Point(47, 147);
            this.lbNameAdmin.Name = "lbNameAdmin";
            this.lbNameAdmin.Size = new System.Drawing.Size(133, 16);
            this.lbNameAdmin.TabIndex = 1;
            this.lbNameAdmin.Text = "Lê Minh Trung Nghĩa";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Quản lý nhân sự";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(19, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Sự kiện";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dtgvEvent);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.btnCalendar);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Location = new System.Drawing.Point(343, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 220);
            this.panel2.TabIndex = 29;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thêm sự kiện";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_view_details_64;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(62, 182);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(139, 38);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Thêm sự kiện";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendar.BorderRadius = 0;
            this.btnCalendar.ButtonText = "Thứ sáu 8-3-2019";
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalendar.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_calendar_64;
            this.btnCalendar.Iconimage_right = null;
            this.btnCalendar.Iconimage_right_Selected = null;
            this.btnCalendar.Iconimage_Selected = null;
            this.btnCalendar.IconMarginLeft = 0;
            this.btnCalendar.IconMarginRight = 0;
            this.btnCalendar.IconRightVisible = true;
            this.btnCalendar.IconRightZoom = 0D;
            this.btnCalendar.IconVisible = true;
            this.btnCalendar.IconZoom = 80D;
            this.btnCalendar.IsTab = false;
            this.btnCalendar.Location = new System.Drawing.Point(4, 35);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalendar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalendar.selected = false;
            this.btnCalendar.Size = new System.Drawing.Size(272, 53);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Thứ sáu 8-3-2019";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Textcolor = System.Drawing.Color.White;
            this.btnCalendar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(92, 8);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(94, 20);
            this.bunifuCustomLabel7.TabIndex = 1;
            this.bunifuCustomLabel7.Text = "Thông báo";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(35, 134);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(109, 16);
            this.bunifuCustomLabel10.TabIndex = 1;
            this.bunifuCustomLabel10.Text = "- Nhân viên kho : ";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(35, 102);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(196, 16);
            this.bunifuCustomLabel9.TabIndex = 1;
            this.bunifuCustomLabel9.Text = "- Số lượng nhân viên bán hàng : ";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(16, 44);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(160, 16);
            this.bunifuCustomLabel8.TabIndex = 1;
            this.bunifuCustomLabel8.Text = "- Số lượng nhân viên : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbTotalUserStock);
            this.panel1.Controls.Add(this.lbTotalUserSell);
            this.panel1.Controls.Add(this.lbTotalUserAdmin);
            this.panel1.Controls.Add(this.lbTotalUser);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.btnDetailEmployees);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 220);
            this.panel1.TabIndex = 30;
            // 
            // lbTotalUserStock
            // 
            this.lbTotalUserStock.AutoSize = true;
            this.lbTotalUserStock.Location = new System.Drawing.Point(150, 137);
            this.lbTotalUserStock.Name = "lbTotalUserStock";
            this.lbTotalUserStock.Size = new System.Drawing.Size(19, 13);
            this.lbTotalUserStock.TabIndex = 8;
            this.lbTotalUserStock.Text = "20";
            // 
            // lbTotalUserSell
            // 
            this.lbTotalUserSell.AutoSize = true;
            this.lbTotalUserSell.Location = new System.Drawing.Point(237, 104);
            this.lbTotalUserSell.Name = "lbTotalUserSell";
            this.lbTotalUserSell.Size = new System.Drawing.Size(19, 13);
            this.lbTotalUserSell.TabIndex = 7;
            this.lbTotalUserSell.Text = "20";
            // 
            // lbTotalUserAdmin
            // 
            this.lbTotalUserAdmin.AutoSize = true;
            this.lbTotalUserAdmin.Location = new System.Drawing.Point(186, 74);
            this.lbTotalUserAdmin.Name = "lbTotalUserAdmin";
            this.lbTotalUserAdmin.Size = new System.Drawing.Size(19, 13);
            this.lbTotalUserAdmin.TabIndex = 6;
            this.lbTotalUserAdmin.Text = "20";
            // 
            // lbTotalUser
            // 
            this.lbTotalUser.AutoSize = true;
            this.lbTotalUser.Location = new System.Drawing.Point(179, 46);
            this.lbTotalUser.Name = "lbTotalUser";
            this.lbTotalUser.Size = new System.Drawing.Size(19, 13);
            this.lbTotalUser.TabIndex = 5;
            this.lbTotalUser.Text = "20";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(35, 71);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(153, 16);
            this.bunifuCustomLabel11.TabIndex = 3;
            this.bunifuCustomLabel11.Text = "- Số lượng Quản trị viên : ";
            // 
            // btnDetailEmployees
            // 
            this.btnDetailEmployees.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDetailEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDetailEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetailEmployees.BorderRadius = 0;
            this.btnDetailEmployees.ButtonText = "Chi tiết cá nhân";
            this.btnDetailEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailEmployees.DisabledColor = System.Drawing.Color.Green;
            this.btnDetailEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetailEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetailEmployees.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_view_details_64;
            this.btnDetailEmployees.Iconimage_right = null;
            this.btnDetailEmployees.Iconimage_right_Selected = null;
            this.btnDetailEmployees.Iconimage_Selected = null;
            this.btnDetailEmployees.IconMarginLeft = 0;
            this.btnDetailEmployees.IconMarginRight = 0;
            this.btnDetailEmployees.IconRightVisible = true;
            this.btnDetailEmployees.IconRightZoom = 0D;
            this.btnDetailEmployees.IconVisible = true;
            this.btnDetailEmployees.IconZoom = 80D;
            this.btnDetailEmployees.IsTab = false;
            this.btnDetailEmployees.Location = new System.Drawing.Point(63, 182);
            this.btnDetailEmployees.Name = "btnDetailEmployees";
            this.btnDetailEmployees.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDetailEmployees.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetailEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetailEmployees.selected = false;
            this.btnDetailEmployees.Size = new System.Drawing.Size(142, 38);
            this.btnDetailEmployees.TabIndex = 2;
            this.btnDetailEmployees.Text = "Chi tiết cá nhân";
            this.btnDetailEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailEmployees.Textcolor = System.Drawing.Color.White;
            this.btnDetailEmployees.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailEmployees.Click += new System.EventHandler(this.btnDetailEmployees_Click);
            // 
            // dtgvUser
            // 
            this.dtgvUser.AllowUserToAddRows = false;
            this.dtgvUser.AllowUserToDeleteRows = false;
            this.dtgvUser.AllowUserToOrderColumns = true;
            this.dtgvUser.AllowUserToResizeRows = false;
            this.dtgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUser.Location = new System.Drawing.Point(3, 16);
            this.dtgvUser.MultiSelect = false;
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.ReadOnly = true;
            this.dtgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvUser.Size = new System.Drawing.Size(894, 303);
            this.dtgvUser.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ImageAdmin);
            this.panel3.Controls.Add(this.btnUpdateAccount);
            this.panel3.Controls.Add(this.lbNameAdmin);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Location = new System.Drawing.Point(663, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 220);
            this.panel3.TabIndex = 31;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAccount.BorderRadius = 0;
            this.btnUpdateAccount.ButtonText = "Cập nhật";
            this.btnUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateAccount.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_edit_641;
            this.btnUpdateAccount.Iconimage_right = null;
            this.btnUpdateAccount.Iconimage_right_Selected = null;
            this.btnUpdateAccount.Iconimage_Selected = null;
            this.btnUpdateAccount.IconMarginLeft = 0;
            this.btnUpdateAccount.IconMarginRight = 0;
            this.btnUpdateAccount.IconRightVisible = true;
            this.btnUpdateAccount.IconRightZoom = 0D;
            this.btnUpdateAccount.IconVisible = true;
            this.btnUpdateAccount.IconZoom = 80D;
            this.btnUpdateAccount.IsTab = false;
            this.btnUpdateAccount.Location = new System.Drawing.Point(53, 182);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateAccount.selected = false;
            this.btnUpdateAccount.Size = new System.Drawing.Size(122, 38);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.Textcolor = System.Drawing.Color.White;
            this.btnUpdateAccount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 322);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng nhân viên";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tb.Location = new System.Drawing.Point(436, 255);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(0, 16);
            this.tb.TabIndex = 40;
            // 
            // lbNotifi
            // 
            this.lbNotifi.AutoSize = true;
            this.lbNotifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifi.ForeColor = System.Drawing.Color.Blue;
            this.lbNotifi.Location = new System.Drawing.Point(416, 262);
            this.lbNotifi.Name = "lbNotifi";
            this.lbNotifi.Size = new System.Drawing.Size(0, 16);
            this.lbNotifi.TabIndex = 41;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::CDStoreManagement.Properties.Resources.icons8_cancel_64;
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(322, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 37;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = global::CDStoreManagement.Properties.Resources.icons8_edit_64;
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(260, 254);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 38;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::CDStoreManagement.Properties.Resources.icons8_add_new_64;
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(200, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 39;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton2.Image = global::CDStoreManagement.Properties.Resources.icons8_todo_list_64;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(793, 249);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 34;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.Image = global::CDStoreManagement.Properties.Resources.icons8_grid_64;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(829, 249);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(196, 231);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(43, 16);
            this.bunifuCustomLabel14.TabIndex = 28;
            this.bunifuCustomLabel14.Text = "Thêm";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(262, 231);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(32, 16);
            this.bunifuCustomLabel15.TabIndex = 27;
            this.bunifuCustomLabel15.Text = "Sửa";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(323, 231);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(32, 16);
            this.bunifuCustomLabel16.TabIndex = 26;
            this.bunifuCustomLabel16.Text = "Xoá";
            // 
            // dtgvEvent
            // 
            this.dtgvEvent.AllowUserToAddRows = false;
            this.dtgvEvent.AllowUserToDeleteRows = false;
            this.dtgvEvent.AllowUserToResizeColumns = false;
            this.dtgvEvent.AllowUserToResizeRows = false;
            this.dtgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEvent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEvent.Location = new System.Drawing.Point(0, 92);
            this.dtgvEvent.Name = "dtgvEvent";
            this.dtgvEvent.Size = new System.Drawing.Size(273, 84);
            this.dtgvEvent.TabIndex = 10;
            this.dtgvEvent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvEvent_MouseClick);
            // 
            // ImageAdmin
            // 
            this.ImageAdmin.Location = new System.Drawing.Point(61, 32);
            this.ImageAdmin.Name = "ImageAdmin";
            this.ImageAdmin.Size = new System.Drawing.Size(100, 100);
            this.ImageAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageAdmin.TabIndex = 3;
            this.ImageAdmin.TabStop = false;
            // 
            // AccountFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNotifi);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.cbbfill);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountFragment";
            this.Size = new System.Drawing.Size(900, 614);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalendar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ComboBox cbbfill;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNameAdmin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetailEmployees;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Panel panel3;
        private Utils.CircleImageBox ImageAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotalUserStock;
        private System.Windows.Forms.Label lbTotalUserSell;
        private System.Windows.Forms.Label lbTotalUserAdmin;
        private System.Windows.Forms.Label lbTotalUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Label lbNotifi;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.DataGridView dtgvEvent;
    }
}
