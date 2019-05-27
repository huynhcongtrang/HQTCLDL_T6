namespace CDStoreManagement.Views.Activities
{
    partial class pnlSlideBar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSlideBar));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.prob4 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.prob3 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.prob2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.prob1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.txtProb4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProb3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProb2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.loadData = new System.Windows.Forms.Timer(this.components);
            this.dtpStatistical = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetailMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.proNearestYear = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.card4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbRevenueDamage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbRevenueYear = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbRevenueMonth = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbRevenueDay = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.chart1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(203, 84);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(689, 319);
            this.bunifuCards1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "Doanh thu";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Doanh thu";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(683, 266);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Name = "Doanhthu";
            this.chart1.Titles.Add(title1);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(108, 36);
            this.bunifuCustomLabel10.TabIndex = 2;
            this.bunifuCustomLabel10.Text = "Doanh thu";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(194, 81);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Thống kê cửa hàng và doanh số\r\n";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.White;
            this.bunifuCards2.Controls.Add(this.prob4);
            this.bunifuCards2.Controls.Add(this.prob3);
            this.bunifuCards2.Controls.Add(this.prob2);
            this.bunifuCards2.Controls.Add(this.prob1);
            this.bunifuCards2.Controls.Add(this.proNearestYear);
            this.bunifuCards2.Controls.Add(this.txtProb4);
            this.bunifuCards2.Controls.Add(this.txtProb3);
            this.bunifuCards2.Controls.Add(this.txtProb2);
            this.bunifuCards2.Controls.Add(this.txtProb1);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel12);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel11);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(203, 409);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(689, 189);
            this.bunifuCards2.TabIndex = 1;
            // 
            // prob4
            // 
            this.prob4.BackColor = System.Drawing.Color.LightGray;
            this.prob4.BorderRadius = 5;
            this.prob4.Location = new System.Drawing.Point(19, 133);
            this.prob4.MaximumValue = 100;
            this.prob4.Name = "prob4";
            this.prob4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prob4.Size = new System.Drawing.Size(315, 10);
            this.prob4.TabIndex = 5;
            this.prob4.Value = 76;
            // 
            // prob3
            // 
            this.prob3.BackColor = System.Drawing.Color.LightGray;
            this.prob3.BorderRadius = 5;
            this.prob3.Location = new System.Drawing.Point(19, 105);
            this.prob3.MaximumValue = 100;
            this.prob3.Name = "prob3";
            this.prob3.ProgressColor = System.Drawing.Color.DarkSlateGray;
            this.prob3.Size = new System.Drawing.Size(315, 10);
            this.prob3.TabIndex = 5;
            this.prob3.Value = 59;
            // 
            // prob2
            // 
            this.prob2.BackColor = System.Drawing.Color.LightGray;
            this.prob2.BorderRadius = 5;
            this.prob2.Location = new System.Drawing.Point(19, 77);
            this.prob2.MaximumValue = 100;
            this.prob2.Name = "prob2";
            this.prob2.ProgressColor = System.Drawing.Color.Salmon;
            this.prob2.Size = new System.Drawing.Size(315, 10);
            this.prob2.TabIndex = 5;
            this.prob2.Value = 45;
            // 
            // prob1
            // 
            this.prob1.BackColor = System.Drawing.Color.LightGray;
            this.prob1.BorderRadius = 5;
            this.prob1.Location = new System.Drawing.Point(19, 49);
            this.prob1.MaximumValue = 100;
            this.prob1.Name = "prob1";
            this.prob1.ProgressColor = System.Drawing.Color.SpringGreen;
            this.prob1.Size = new System.Drawing.Size(315, 10);
            this.prob1.TabIndex = 5;
            this.prob1.Value = 87;
            // 
            // txtProb4
            // 
            this.txtProb4.AutoSize = true;
            this.txtProb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProb4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProb4.Location = new System.Drawing.Point(340, 128);
            this.txtProb4.Name = "txtProb4";
            this.txtProb4.Size = new System.Drawing.Size(31, 17);
            this.txtProb4.TabIndex = 3;
            this.txtProb4.Text = "Sex";
            this.txtProb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProb3
            // 
            this.txtProb3.AutoSize = true;
            this.txtProb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProb3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProb3.Location = new System.Drawing.Point(340, 100);
            this.txtProb3.Name = "txtProb3";
            this.txtProb3.Size = new System.Drawing.Size(29, 17);
            this.txtProb3.TabIndex = 3;
            this.txtProb3.Text = "Hài";
            this.txtProb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProb2
            // 
            this.txtProb2.AutoSize = true;
            this.txtProb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProb2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProb2.Location = new System.Drawing.Point(340, 72);
            this.txtProb2.Name = "txtProb2";
            this.txtProb2.Size = new System.Drawing.Size(41, 17);
            this.txtProb2.TabIndex = 3;
            this.txtProb2.Text = "Nhạc";
            this.txtProb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProb1
            // 
            this.txtProb1.AutoSize = true;
            this.txtProb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProb1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProb1.Location = new System.Drawing.Point(341, 43);
            this.txtProb1.Name = "txtProb1";
            this.txtProb1.Size = new System.Drawing.Size(39, 17);
            this.txtProb1.TabIndex = 3;
            this.txtProb1.Text = "Phim";
            this.txtProb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(428, 4);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(108, 36);
            this.bunifuCustomLabel12.TabIndex = 3;
            this.bunifuCustomLabel12.Text = "Biểu đồ";
            this.bunifuCustomLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(3, 4);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(108, 36);
            this.bunifuCustomLabel11.TabIndex = 3;
            this.bunifuCustomLabel11.Text = "Phổ biến";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(422, 13);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 160);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // loadData
            // 
            this.loadData.Enabled = true;
            this.loadData.Interval = 500;
            this.loadData.Tick += new System.EventHandler(this.loadData_Tick);
            // 
            // dtpStatistical
            // 
            this.dtpStatistical.Location = new System.Drawing.Point(206, 41);
            this.dtpStatistical.Name = "dtpStatistical";
            this.dtpStatistical.Size = new System.Drawing.Size(200, 20);
            this.dtpStatistical.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Green;
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Xem";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.ForeColor = System.Drawing.Color.Violet;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = global::CDStoreManagement.Properties.Resources.icons8_search_64;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 70D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(421, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Green;
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(79, 29);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Xem";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnView_Click);
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
            this.btnReset.Location = new System.Drawing.Point(516, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(89, 30);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDetailMonth
            // 
            this.btnDetailMonth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDetailMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.btnDetailMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetailMonth.BorderRadius = 0;
            this.btnDetailMonth.ButtonText = "Chi tiết qua từng tháng";
            this.btnDetailMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailMonth.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetailMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetailMonth.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDetailMonth.Iconimage")));
            this.btnDetailMonth.Iconimage_right = null;
            this.btnDetailMonth.Iconimage_right_Selected = null;
            this.btnDetailMonth.Iconimage_Selected = null;
            this.btnDetailMonth.IconMarginLeft = 0;
            this.btnDetailMonth.IconMarginRight = 0;
            this.btnDetailMonth.IconRightVisible = true;
            this.btnDetailMonth.IconRightZoom = 0D;
            this.btnDetailMonth.IconVisible = true;
            this.btnDetailMonth.IconZoom = 90D;
            this.btnDetailMonth.IsTab = false;
            this.btnDetailMonth.Location = new System.Drawing.Point(694, 30);
            this.btnDetailMonth.Name = "btnDetailMonth";
            this.btnDetailMonth.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.btnDetailMonth.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDetailMonth.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetailMonth.selected = false;
            this.btnDetailMonth.Size = new System.Drawing.Size(186, 31);
            this.btnDetailMonth.TabIndex = 42;
            this.btnDetailMonth.Text = "Chi tiết qua từng tháng";
            this.btnDetailMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailMonth.Textcolor = System.Drawing.Color.White;
            this.btnDetailMonth.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailMonth.Click += new System.EventHandler(this.btnDetailMonth_Click);
            // 
            // proNearestYear
            // 
            this.proNearestYear.animated = false;
            this.proNearestYear.animationIterval = 1;
            this.proNearestYear.animationSpeed = 10;
            this.proNearestYear.BackColor = System.Drawing.Color.White;
            this.proNearestYear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proNearestYear.BackgroundImage")));
            this.proNearestYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.proNearestYear.ForeColor = System.Drawing.Color.Purple;
            this.proNearestYear.LabelVisible = true;
            this.proNearestYear.LineProgressThickness = 15;
            this.proNearestYear.LineThickness = 5;
            this.proNearestYear.Location = new System.Drawing.Point(491, 31);
            this.proNearestYear.Margin = new System.Windows.Forms.Padding(11);
            this.proNearestYear.MaxValue = 100;
            this.proNearestYear.Name = "proNearestYear";
            this.proNearestYear.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.proNearestYear.ProgressColor = System.Drawing.Color.Purple;
            this.proNearestYear.Size = new System.Drawing.Size(147, 147);
            this.proNearestYear.TabIndex = 4;
            this.proNearestYear.Value = 60;
            // 
            // card4
            // 
            this.card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card4.BackgroundImage")));
            this.card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card4.Controls.Add(this.lbRevenueDamage);
            this.card4.Controls.Add(this.pictureBox4);
            this.card4.Controls.Add(this.bunifuCustomLabel8);
            this.card4.GradientBottomLeft = System.Drawing.Color.Purple;
            this.card4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.card4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.card4.GradientTopRight = System.Drawing.Color.Purple;
            this.card4.Location = new System.Drawing.Point(8, 486);
            this.card4.Name = "card4";
            this.card4.Quality = 50;
            this.card4.Size = new System.Drawing.Size(170, 111);
            this.card4.TabIndex = 0;
            // 
            // lbRevenueDamage
            // 
            this.lbRevenueDamage.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenueDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRevenueDamage.ForeColor = System.Drawing.Color.White;
            this.lbRevenueDamage.Location = new System.Drawing.Point(3, 72);
            this.lbRevenueDamage.Name = "lbRevenueDamage";
            this.lbRevenueDamage.Size = new System.Drawing.Size(167, 28);
            this.lbRevenueDamage.TabIndex = 4;
            this.lbRevenueDamage.Text = "20,674 triệu đồng";
            this.lbRevenueDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CDStoreManagement.Properties.Resources.icons8_pos_terminal_80;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(3, 54);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel8.TabIndex = 3;
            this.bunifuCustomLabel8.Text = "Vốn tiêu hao";
            // 
            // card3
            // 
            this.card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card3.BackgroundImage")));
            this.card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card3.Controls.Add(this.lbRevenueYear);
            this.card3.Controls.Add(this.pictureBox3);
            this.card3.Controls.Add(this.bunifuCustomLabel6);
            this.card3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.card3.GradientBottomRight = System.Drawing.Color.Teal;
            this.card3.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.card3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.card3.Location = new System.Drawing.Point(8, 352);
            this.card3.Name = "card3";
            this.card3.Quality = 50;
            this.card3.Size = new System.Drawing.Size(170, 111);
            this.card3.TabIndex = 0;
            // 
            // lbRevenueYear
            // 
            this.lbRevenueYear.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenueYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRevenueYear.ForeColor = System.Drawing.Color.White;
            this.lbRevenueYear.Location = new System.Drawing.Point(3, 72);
            this.lbRevenueYear.Name = "lbRevenueYear";
            this.lbRevenueYear.Size = new System.Drawing.Size(167, 28);
            this.lbRevenueYear.TabIndex = 4;
            this.lbRevenueYear.Text = "20,674 triệu đồng";
            this.lbRevenueYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CDStoreManagement.Properties.Resources.icons8_firework_explosion_64;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 54);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(134, 17);
            this.bunifuCustomLabel6.TabIndex = 3;
            this.bunifuCustomLabel6.Text = "Danh thu trong năm";
            // 
            // card2
            // 
            this.card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card2.BackgroundImage")));
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Controls.Add(this.lbRevenueMonth);
            this.card2.Controls.Add(this.pictureBox2);
            this.card2.Controls.Add(this.bunifuCustomLabel5);
            this.card2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
            this.card2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(156)))));
            this.card2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(156)))));
            this.card2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
            this.card2.Location = new System.Drawing.Point(8, 218);
            this.card2.Name = "card2";
            this.card2.Quality = 50;
            this.card2.Size = new System.Drawing.Size(170, 111);
            this.card2.TabIndex = 0;
            // 
            // lbRevenueMonth
            // 
            this.lbRevenueMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenueMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRevenueMonth.ForeColor = System.Drawing.Color.White;
            this.lbRevenueMonth.Location = new System.Drawing.Point(3, 72);
            this.lbRevenueMonth.Name = "lbRevenueMonth";
            this.lbRevenueMonth.Size = new System.Drawing.Size(167, 28);
            this.lbRevenueMonth.TabIndex = 4;
            this.lbRevenueMonth.Text = "30,4 triệu đồng";
            this.lbRevenueMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CDStoreManagement.Properties.Resources.icons8_calendar_100;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 54);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(143, 17);
            this.bunifuCustomLabel5.TabIndex = 3;
            this.bunifuCustomLabel5.Text = "Danh thu trong tháng";
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Controls.Add(this.lbRevenueDay);
            this.card1.Controls.Add(this.bunifuCustomLabel2);
            this.card1.Controls.Add(this.pictureBox1);
            this.card1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.card1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.card1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(254)))));
            this.card1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.card1.Location = new System.Drawing.Point(8, 84);
            this.card1.Name = "card1";
            this.card1.Quality = 50;
            this.card1.Size = new System.Drawing.Size(170, 111);
            this.card1.TabIndex = 0;
            // 
            // lbRevenueDay
            // 
            this.lbRevenueDay.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenueDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRevenueDay.ForeColor = System.Drawing.Color.White;
            this.lbRevenueDay.Location = new System.Drawing.Point(3, 72);
            this.lbRevenueDay.Name = "lbRevenueDay";
            this.lbRevenueDay.Size = new System.Drawing.Size(167, 28);
            this.lbRevenueDay.TabIndex = 1;
            this.lbRevenueDay.Text = "20,674 triệu đồng";
            this.lbRevenueDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 54);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(138, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Danh thu trong ngày";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CDStoreManagement.Properties.Resources.icons8_today_100;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSlideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDetailMonth);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.dtpStatistical);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "pnlSlideBar";
            this.Size = new System.Drawing.Size(900, 614);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel card1;
        private Bunifu.Framework.UI.BunifuGradientPanel card2;
        private Bunifu.Framework.UI.BunifuGradientPanel card3;
        private Bunifu.Framework.UI.BunifuGradientPanel card4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRevenueDay;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRevenueDamage;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRevenueYear;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRevenueMonth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Timer loadData;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCircleProgressbar proNearestYear;
        private Bunifu.Framework.UI.BunifuProgressBar prob1;
        private Bunifu.Framework.UI.BunifuProgressBar prob2;
        private Bunifu.Framework.UI.BunifuProgressBar prob3;
        private Bunifu.Framework.UI.BunifuProgressBar prob4;
        private Bunifu.Framework.UI.BunifuCustomLabel txtProb1;
        private Bunifu.Framework.UI.BunifuCustomLabel txtProb4;
        private Bunifu.Framework.UI.BunifuCustomLabel txtProb3;
        private Bunifu.Framework.UI.BunifuCustomLabel txtProb2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dtpStatistical;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetailMonth;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
    }
}
