using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class GiayBLL
    {
        QLGiayDAL dalGiay;
        public GiayBLL()
        {
            dalGiay = new QLGiayDAL();
        }
        public DataTable getAllGiay()
        {
            return dalGiay.getAllGiay();
        }
        public bool ThemGiay(Giay giay)
        {
            try
            {
                return dalGiay.ThemGiay(giay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giày: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SuaGiay(Giay giay)
        {
            return dalGiay.SuaGiay(giay);
        }
        public bool XoaGiay(int giayID)
        {
            return dalGiay.XoaGiay(giayID);
        }
        public DataTable TimGiay(string giay)
        {
            return dalGiay.TimGiay(giay);
        }
    }
}
