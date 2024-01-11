using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThayDoiQuyDinh;
namespace test
{
    [TestClass]
    public class ChangeRuleTest
    {
        [TestMethod]
        public void LoadForm()
        {
            var form1 = new FormThayDoiQuyDinh();
            try
            {
                form1.loadQD();
                Assert.AreEqual("5 tháng", form1.lbthoihan.Text);
                Assert.AreEqual("8 năm", form1.lbLuuHanh.Text);
                Assert.AreEqual("55 tuổi", form1.lbTuoiMax.Text);
                Assert.AreEqual("18 tuổi", form1.lbTuoiMin.Text);
                Assert.AreEqual("4 ngày", form1.lbNgayMax.Text);
                Assert.AreEqual("5 cuốn", form1.lbSachMax.Text);
                Assert.AreEqual("1000 đồng", form1.lbTien.Text);
            }
      catch (Exception ex) { }
           
        }

        [TestMethod]
        public void CapNhat()
        {
            var form1 = new FormThayDoiQuyDinh();
            try
            {
                EventArgs e = new EventArgs();
                form1.nButton1_Click(null,e);
                Assert.AreEqual("5 tháng", form1.lbthoihan.Text);
                Assert.AreEqual("8 năm", form1.lbLuuHanh.Text);
                Assert.AreEqual("55 tuổi", form1.lbTuoiMax.Text);
                Assert.AreEqual("18 tuổi", form1.lbTuoiMin.Text);
                Assert.AreEqual("4 ngày", form1.lbNgayMax.Text);
                Assert.AreEqual("5 cuốn", form1.lbSachMax.Text);
                Assert.AreEqual("1000 đồng", form1.lbTien.Text);
            }
            catch (Exception ex) { }

        }
    }
}
