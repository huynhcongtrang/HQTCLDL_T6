using System.Windows.Forms;

namespace CDStoreManagement.Utils.CalendarEvent
{
    partial class EventNotificationInsert
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtDateEventBegin = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbTitleEvent = new System.Windows.Forms.TextBox();
            this.btnCLose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtTimeEventBegin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtDateEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dtTimeEventEnd = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtDateEventBegin
            // 
            this.dtDateEventBegin.Location = new System.Drawing.Point(16, 190);
            this.dtDateEventBegin.Name = "dtDateEventBegin";
            this.dtDateEventBegin.Size = new System.Drawing.Size(363, 20);
            this.dtDateEventBegin.TabIndex = 1;
            this.dtDateEventBegin.Value = new System.DateTime(2019, 3, 14, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(227, 12);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(125, 25);
            this.bunifuCustomLabel3.TabIndex = 56;
            this.bunifuCustomLabel3.Text = "Tạo sự kiện";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "Chủ đề";
            // 
            // tbTitleEvent
            // 
            this.tbTitleEvent.Location = new System.Drawing.Point(14, 73);
            this.tbTitleEvent.Multiline = true;
            this.tbTitleEvent.Name = "tbTitleEvent";
            this.tbTitleEvent.Size = new System.Drawing.Size(534, 63);
            this.tbTitleEvent.TabIndex = 57;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.Image = global::CDStoreManagement.Properties.Resources.icons8_delete_64;
            this.btnCLose.ImageActive = null;
            this.btnCLose.Location = new System.Drawing.Point(519, 10);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(33, 30);
            this.btnCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCLose.TabIndex = 120;
            this.btnCLose.TabStop = false;
            this.btnCLose.Zoom = 10;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "Thêm sự kiện";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = global::CDStoreManagement.Properties.Resources.btnInsert_Iconimage;
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 90D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(193, 379);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(185, 48);
            this.btnInsert.TabIndex = 58;
            this.btnInsert.Text = "Thêm sự kiện";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtTimeEventBegin
            // 
            this.dtTimeEventBegin.CustomFormat = "hh:mm";
            this.dtTimeEventBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeEventBegin.Location = new System.Drawing.Point(399, 190);
            this.dtTimeEventBegin.Name = "dtTimeEventBegin";
            this.dtTimeEventBegin.ShowUpDown = true;
            this.dtTimeEventBegin.Size = new System.Drawing.Size(136, 20);
            this.dtTimeEventBegin.TabIndex = 121;
            this.dtTimeEventBegin.Value = new System.DateTime(2019, 3, 14, 15, 12, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 10);
            this.panel1.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(557, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 441);
            this.panel2.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(-1, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 10);
            this.panel3.TabIndex = 123;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(-6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 428);
            this.panel4.TabIndex = 124;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 159);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 16);
            this.bunifuCustomLabel2.TabIndex = 125;
            this.bunifuCustomLabel2.Text = "Ngày bắt đầu";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 239);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(102, 16);
            this.bunifuCustomLabel4.TabIndex = 126;
            this.bunifuCustomLabel4.Text = "Ngày kết thúc";
            // 
            // dtDateEventEnd
            // 
            this.dtDateEventEnd.Location = new System.Drawing.Point(16, 269);
            this.dtDateEventEnd.Name = "dtDateEventEnd";
            this.dtDateEventEnd.Size = new System.Drawing.Size(363, 20);
            this.dtDateEventEnd.TabIndex = 127;
            this.dtDateEventEnd.Value = new System.DateTime(2019, 3, 14, 0, 0, 0, 0);
            // 
            // dtTimeEventEnd
            // 
            this.dtTimeEventEnd.CustomFormat = "hh:mm";
            this.dtTimeEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeEventEnd.Location = new System.Drawing.Point(399, 269);
            this.dtTimeEventEnd.Name = "dtTimeEventEnd";
            this.dtTimeEventEnd.ShowUpDown = true;
            this.dtTimeEventEnd.Size = new System.Drawing.Size(136, 20);
            this.dtTimeEventEnd.TabIndex = 128;
            this.dtTimeEventEnd.Value = new System.DateTime(2019, 3, 14, 15, 12, 0, 0);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(13, 325);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(87, 16);
            this.bunifuCustomLabel5.TabIndex = 129;
            this.bunifuCustomLabel5.Text = "Khuyến mãi";
            // 
            // txDiscount
            // 
            this.txDiscount.Location = new System.Drawing.Point(115, 321);
            this.txDiscount.Name = "txDiscount";
            this.txDiscount.Size = new System.Drawing.Size(100, 20);
            this.txDiscount.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 131;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "(Nếu có)";
            // 
            // EventNotificationInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDiscount);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dtTimeEventEnd);
            this.Controls.Add(this.dtDateEventEnd);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtTimeEventBegin);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbTitleEvent);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.dtDateEventBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventNotificationInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventNotification";
            this.Load += new System.EventHandler(this.EventNotificationInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DateTimePicker dtDateEventBegin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuImageButton btnCLose;
        private System.Windows.Forms.TextBox tbTitleEvent;
        private DateTimePicker dtTimeEventBegin;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DateTimePicker dtTimeEventEnd;
        private DateTimePicker dtDateEventEnd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Label label2;
        private Label label1;
        private TextBox txDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}