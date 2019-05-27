namespace CDStoreManagement.Utils
{
    partial class ControlBoxFunction
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCLose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lstFunction = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
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
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 24);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Các chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.Image = global::CDStoreManagement.Properties.Resources.icons8_delete_64;
            this.btnCLose.ImageActive = null;
            this.btnCLose.Location = new System.Drawing.Point(183, 3);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(22, 26);
            this.btnCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCLose.TabIndex = 125;
            this.btnCLose.TabStop = false;
            this.btnCLose.Zoom = 10;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lstFunction
            // 
            this.lstFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.lstFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFunction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFunction.ForeColor = System.Drawing.Color.White;
            this.lstFunction.FormattingEnabled = true;
            this.lstFunction.ItemHeight = 20;
            this.lstFunction.Items.AddRange(new object[] {
            "Đổi mật khẩu",
            "Xem thông tin cá nhân"});
            this.lstFunction.Location = new System.Drawing.Point(0, 36);
            this.lstFunction.Name = "lstFunction";
            this.lstFunction.Size = new System.Drawing.Size(208, 80);
            this.lstFunction.TabIndex = 1;
            this.lstFunction.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFunction_MouseDoubleClick);
            this.lstFunction.MouseHover += new System.EventHandler(this.lstFunction_MouseHover);
            // 
            // ControlBoxFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 116);
            this.Controls.Add(this.lstFunction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlBoxFunction";
            this.Text = "ControlBoxFunction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCLose;
        private System.Windows.Forms.ListBox lstFunction;
    }
}