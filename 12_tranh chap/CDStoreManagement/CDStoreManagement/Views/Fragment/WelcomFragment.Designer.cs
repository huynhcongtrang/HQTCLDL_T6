namespace CDStoreManagement.Views.Fragment
{
    partial class WelcomFragment
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
            this.text2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.text1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.loadComponent = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("SVN-Avo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.White;
            this.text2.Location = new System.Drawing.Point(274, 220);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(332, 51);
            this.text2.TabIndex = 2;
            this.text2.Text = "QUẢN LÝ BĂNG ĐĨA NTP";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("SVN-Avo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.White;
            this.text1.Location = new System.Drawing.Point(214, 181);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(470, 39);
            this.text1.TabIndex = 3;
            this.text1.Text = "CHÀO MỪNG ĐẾN VỚI ỨNG DỤNG";
            // 
            // loadComponent
            // 
            this.loadComponent.Enabled = true;
            // 
            // WelcomFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDStoreManagement.Properties.Resources.bg_013;
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "WelcomFragment";
            this.Size = new System.Drawing.Size(904, 614);
            this.Load += new System.EventHandler(this.WelcomFragment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel text2;
        private Bunifu.Framework.UI.BunifuCustomLabel text1;
        private System.Windows.Forms.Timer loadComponent;
    }
}
