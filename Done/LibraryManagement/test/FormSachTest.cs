using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FormSach;
using System.Windows.Forms;

namespace FormSachTest
{
    [TestClass]
    public class FormSachTest
    {
        [TestMethod]
        public void LoadFormSach()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null,e);
            var date = new DateTime(2018, 1, 1, 0, 0, 0);
            Assert.AreEqual("MS001", (formSach.txbMaSach.Text));
            Assert.AreEqual("MDS001", (formSach.cbMaDS.Text));
            Assert.AreEqual("Đắc Nhân Tâm", (formSach.cbTenSach.Text));
            Assert.AreEqual("Dale Caregie", (formSach.txbTenTG.Text));
            Assert.AreEqual(date, (formSach.dtpNamXuatBan.Value));
            Assert.AreEqual("NXB Trẻ", (formSach.txbNhaXuatBan.Text));
            Assert.AreEqual("1", (formSach.txbSoLuongTon.Text));
            Assert.AreEqual("100,000 VNĐ", (formSach.txbGiaTien.Text));
        }

        [TestMethod]
        public void ThemMoiBTN()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            var date = DateTime.Now;
            formSach.btnThemMoi_Click(null,e);
            Assert.AreEqual("MS012", (formSach.txbMaSach.Text));
            Assert.AreEqual("", (formSach.cbMaDS.Text));
            Assert.AreEqual("", (formSach.cbTenSach.Text));
            Assert.AreEqual("", (formSach.txbTenTG.Text));
            //Assert.AreEqual(date, (formSach.dtpNamXuatBan.Value));
            Assert.AreEqual("", (formSach.txbNhaXuatBan.Text));
            Assert.AreEqual("0", (formSach.txbSoLuongTon.Text));
            Assert.AreEqual("", (formSach.txbGiaTien.Text));
        }

        [TestMethod]
        public void LuuBTN()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            var date=new DateTime();
            formSach.btnThemMoi_Click(null, e);

            formSach.cbMaDS.SelectedIndex=0;
            formSach.txbNhaXuatBan.Text = "VanKhoi";
            //formSach.txbSoLuongTon.Text = "2";
            formSach.txbGiaTien.Text = "100";
            formSach.dtpNamXuatBan.Value = DateTime.Now;
            bool check = true;
            try
            {
                formSach.btnLuu_Click(null, e);
                check = false;
            }
            catch   (Exception ex)
            {
                check = true;
            }
            Assert.IsTrue(check);
           
        }

        [TestMethod]
        public void XoaBTN()
        {
            var formSach = new Form1();
            EventArgs e = new EventArgs();
            formSach.Form1_Load(null, e);
            var date = new DateTime();

            int rowIndex = formSach.dgvSach.SelectedCells[0].RowIndex;
            int lastCellIndex = formSach.dgvSach.Rows[rowIndex].Cells.Count - 1;

            formSach.dgvSach.CurrentCell = formSach.dgvSach.Rows[rowIndex].Cells[lastCellIndex];
            var a = new DataGridViewCellEventArgs(rowIndex, lastCellIndex);

            Assert.AreEqual("MDS001", (formSach.cbMaDS.Text));
            var k = true; 
            try
            {
                formSach.btnXoa_Click(null, a);
               
            }
           
           
            catch(Exception ex) {
                k = false;
            }
            Assert.IsTrue(k);
        }
    }
}
