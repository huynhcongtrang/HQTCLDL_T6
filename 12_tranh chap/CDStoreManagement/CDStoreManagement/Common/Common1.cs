using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Common
{
    public class Common1
    {
        public static int idRuleBuy = 1;
        public static int idRuleHire = 1;
        //position
        public static int positionAdmin = 1;
        public static int positionNhanVien = 2;
        public static int positionNhanVienKho = 3;
        public static int Id  = 0;
        public static int postionPermistion = 0 ;
        public static string imageDefultAdmin = "C:\\Users\\meohu\\OneDrive\\Máy tính\\ProjectT6\\Image\\icons8-businessman-64.png";
        public static string salaryBasic = "30000";
        public static List<Item> cart = new List<Item>();
        
        //Current user 
        
        public static string UploadImage()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter =
                    "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }
    }
}
