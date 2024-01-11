using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FormLoaiSach;
namespace test
{
    [TestClass]
    public class FormLoaiSach
    {
        [TestMethod]
        public void LoadForm()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            Assert.AreEqual("MTL001", (formSach.txbMaTLS.Text));
            Assert.AreEqual("Văn Học Nghệ Thuật", (formSach.txbTenTLS.Text));
        }

        [TestMethod]
        public void Themoi()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            formSach.btnThemMoi_Click(null, e);
            Assert.AreEqual("MTL005", (formSach.txbMaTLS.Text));
            Assert.AreEqual("", (formSach.txbTenTLS.Text));
        }

        [TestMethod]
        public void LuuBtn()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            formSach.btnThemMoi_Click(null, e);
            formSach.txbTenTLS.Text = "Báo";
            var check = true;
            try
            {
                formSach.btnLuu_Click(null, e);
            }
       catch (Exception ex) { check = false; }

            Assert.IsTrue(check);
           
        }

        [TestMethod]
        public void XoaBtn()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
   
        
            var check = true;
            try
            {
                formSach.btnXoa_Click(null, e);
            }
            catch (Exception ex) { check = false; }

            Assert.IsTrue(check);

        }

        [TestMethod]
        public void CapNhat()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);


            var check = true;
            try
            {
                formSach.btnCapNhat_Click(null, e);
            }
            catch (Exception ex) { check = false; }

            Assert.IsTrue(check);

        }
    }
}
