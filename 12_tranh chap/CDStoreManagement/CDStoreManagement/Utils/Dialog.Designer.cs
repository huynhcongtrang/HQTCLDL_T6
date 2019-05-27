namespace CDStoreManagement.Utils
{
    partial class Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressDialogFragment1 = new CDStoreManagement.Views.Fragment.ProgressDialogFragment();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please waiting !";
            // 
            // btnCancle
            // 
            this.btnCancle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancle.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancle.BorderRadius = 0;
            this.btnCancle.ButtonText = "Cancle";
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancle.Iconimage")));
            this.btnCancle.Iconimage_right = null;
            this.btnCancle.Iconimage_right_Selected = null;
            this.btnCancle.Iconimage_Selected = null;
            this.btnCancle.IconMarginLeft = 0;
            this.btnCancle.IconMarginRight = 0;
            this.btnCancle.IconRightVisible = true;
            this.btnCancle.IconRightZoom = 0D;
            this.btnCancle.IconVisible = true;
            this.btnCancle.IconZoom = 90D;
            this.btnCancle.IsTab = false;
            this.btnCancle.Location = new System.Drawing.Point(216, 179);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancle.selected = false;
            this.btnCancle.Size = new System.Drawing.Size(102, 48);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Textcolor = System.Drawing.Color.White;
            this.btnCancle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // progressDialogFragment1
            // 
            this.progressDialogFragment1.Location = new System.Drawing.Point(125, 76);
            this.progressDialogFragment1.Name = "progressDialogFragment1";
            this.progressDialogFragment1.Size = new System.Drawing.Size(80, 80);
            this.progressDialogFragment1.TabIndex = 3;
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(330, 239);
            this.Controls.Add(this.progressDialogFragment1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancle;
        private Views.Fragment.ProgressDialogFragment progressDialogFragment1;
    }
}