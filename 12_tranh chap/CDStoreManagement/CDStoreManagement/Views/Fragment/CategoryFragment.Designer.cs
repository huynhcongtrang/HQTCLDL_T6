namespace CDStoreManagement.Views.Activities
{
    partial class CategoryFragment
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCatalog = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditCatalog = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCatalog = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(385, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCatalog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 439);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // dtgvCatalog
            // 
            this.dtgvCatalog.AllowUserToAddRows = false;
            this.dtgvCatalog.AllowUserToDeleteRows = false;
            this.dtgvCatalog.AllowUserToOrderColumns = true;
            this.dtgvCatalog.AllowUserToResizeRows = false;
            this.dtgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCatalog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCatalog.Location = new System.Drawing.Point(3, 16);
            this.dtgvCatalog.MultiSelect = false;
            this.dtgvCatalog.Name = "dtgvCatalog";
            this.dtgvCatalog.ReadOnly = true;
            this.dtgvCatalog.Size = new System.Drawing.Size(894, 420);
            this.dtgvCatalog.TabIndex = 0;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(7, 120);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(116, 19);
            this.materialLabel10.TabIndex = 22;
            this.materialLabel10.Text = "Các chức năng :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CDStoreManagement.Properties.Resources.Catalog_example;
            this.pictureBox2.Location = new System.Drawing.Point(476, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CDStoreManagement.Properties.Resources.GetArticleImage;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::CDStoreManagement.Properties.Resources.icons8_cancel_64;
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(250, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 23;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditCatalog
            // 
            this.btnEditCatalog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditCatalog.Image = global::CDStoreManagement.Properties.Resources.icons8_edit_64;
            this.btnEditCatalog.ImageActive = null;
            this.btnEditCatalog.Location = new System.Drawing.Point(191, 114);
            this.btnEditCatalog.Name = "btnEditCatalog";
            this.btnEditCatalog.Size = new System.Drawing.Size(30, 30);
            this.btnEditCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditCatalog.TabIndex = 24;
            this.btnEditCatalog.TabStop = false;
            this.btnEditCatalog.Zoom = 10;
            this.btnEditCatalog.Click += new System.EventHandler(this.btnEditCatalog_Click);
            // 
            // btnAddCatalog
            // 
            this.btnAddCatalog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCatalog.Image = global::CDStoreManagement.Properties.Resources.icons8_add_new_64;
            this.btnAddCatalog.ImageActive = null;
            this.btnAddCatalog.Location = new System.Drawing.Point(127, 114);
            this.btnAddCatalog.Name = "btnAddCatalog";
            this.btnAddCatalog.Size = new System.Drawing.Size(30, 30);
            this.btnAddCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCatalog.TabIndex = 25;
            this.btnAddCatalog.TabStop = false;
            this.btnAddCatalog.Zoom = 10;
            this.btnAddCatalog.Click += new System.EventHandler(this.btnAddCatalog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 10);
            this.panel1.TabIndex = 28;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(251, 87);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(32, 16);
            this.bunifuCustomLabel16.TabIndex = 29;
            this.bunifuCustomLabel16.Text = "Xoá";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(190, 87);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(32, 16);
            this.bunifuCustomLabel15.TabIndex = 30;
            this.bunifuCustomLabel15.Text = "Sửa";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(124, 87);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(43, 16);
            this.bunifuCustomLabel14.TabIndex = 31;
            this.bunifuCustomLabel14.Text = "Thêm";
            // 
            // CategoryFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCatalog);
            this.Controls.Add(this.btnAddCatalog);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "CategoryFragment";
            this.Size = new System.Drawing.Size(900, 614);
            this.Load += new System.EventHandler(this.CategoryFragment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCatalog;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnEditCatalog;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCatalog;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
    }
}
