using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using FormLoaiDocGia;
using System.Data.SqlClient;
namespace test
{
    [TestClass]
    public class LoadDGVLoaidocgiaTest
    {
        [TestMethod]
        public void TestdgvBox()
        {
            // Arrange
          var  FormLoaiDocGia = new Form1(); // Instantiate your form

            FormLoaiDocGia.loadDgv();

            // Assert
            Assert.IsNotNull(FormLoaiDocGia.dgvLoaiDocGia.DataSource);
            Assert.IsTrue(FormLoaiDocGia.dgvLoaiDocGia.RowCount > 0);
            Assert.AreEqual("MLDG001", ((DataTable)FormLoaiDocGia.dgvLoaiDocGia.DataSource).Rows[0]["Mã Loại Độc Giả"]);
            Assert.AreEqual("Sinh Viên", ((DataTable)FormLoaiDocGia.dgvLoaiDocGia.DataSource).Rows[0]["Tên Loại Độc Giả"]);
            //Assert.AreEqual("ExpectedValue2", FormLoaiDocGia.dgvLoaiDocGia.DataSource.rows[0]["Tên Loại Độc Giả"]);
        }

        [TestMethod]
        public void Testdgv2()
        {
            // Arrange
            var FormLoaiDocGia = new Form1(); // Instantiate your form

            FormLoaiDocGia.loadDgv();

            // Assert
            Assert.IsNotNull(FormLoaiDocGia.dgvLoaiDocGia.DataSource);
            Assert.IsTrue(FormLoaiDocGia.dgvLoaiDocGia.RowCount > 0);
            Assert.AreEqual("MLDG002", ((DataTable)FormLoaiDocGia.dgvLoaiDocGia.DataSource).Rows[1]["Mã Loại Độc Giả"]);
            Assert.AreEqual("Giảng Viên", ((DataTable)FormLoaiDocGia.dgvLoaiDocGia.DataSource).Rows[1]["Tên Loại Độc Giả"]);
            //Assert.AreEqual("ExpectedValue2", FormLoaiDocGia.dgvLoaiDocGia.DataSource.rows[0]["Tên Loại Độc Giả"]);
        }

        [TestMethod]
        public void TestBoxMLDG()
        {
            // Arrange
            var FormLoaiDocGia = new Form1(); // Instantiate your form
             EventArgs e = new EventArgs();
   
            FormLoaiDocGia.Form1_Load(null,e);
          

            // Assert
            Assert.IsNotNull(FormLoaiDocGia.txbMaLoaiDocGia);
            Assert.AreEqual("MLDG001", (FormLoaiDocGia.txbMaLoaiDocGia.Text));
            Assert.AreEqual("Sinh Viên", (FormLoaiDocGia.txbTenLoaiDocGia.Text));
            //Assert.AreEqual("ExpectedValue2", FormLoaiDocGia.dgvLoaiDocGia.DataSource.rows[0]["Tên Loại Độc Giả"]);
        }

        [TestMethod]
        public void TestBoxMLDG2Themmoi()
        {
            // Arrange
            var FormLoaiDocGia = new Form1(); // Instantiate your form
            EventArgs e = new EventArgs();
            FormLoaiDocGia.Form1_Load(null, e);
            FormLoaiDocGia.btnThemMoi_Click(null, e);

            // Assert
            Assert.IsNotNull(FormLoaiDocGia.txbMaLoaiDocGia);
            Assert.AreEqual("MLDG003", (FormLoaiDocGia.txbMaLoaiDocGia.Text));
            Assert.AreEqual("", (FormLoaiDocGia.txbTenLoaiDocGia.Text));
            //Assert.AreEqual("ExpectedValue2", FormLoaiDocGia.dgvLoaiDocGia.DataSource.rows[0]["Tên Loại Độc Giả"]);
        }

        [TestMethod]
        public void TestBoxMLDGLuu()
        {
            // Arrange
            var k = true;
            var FormLoaiDocGia = new Form1(); // Instantiate your form
            EventArgs e = new EventArgs();
            FormLoaiDocGia.Form1_Load(null, e);
            try
            {
                FormLoaiDocGia.btnThemMoi_Click(null, e);
                FormLoaiDocGia.txbTenLoaiDocGia.Text = "Nông Dân";
                FormLoaiDocGia.btnLuu_Click(null, e);
        
            }
           catch (Exception ex) {
                k = false;
            }

            // Assert
            Assert.AreEqual(true, (k));
        }

        [TestMethod]
        public void TestBoxMLDGCapNhat()
        {
            // Arrange
            var k = true;
            var FormLoaiDocGia = new Form1(); // Instantiate your form
            EventArgs e = new EventArgs();
            FormLoaiDocGia.Form1_Load(null, e);
            try
            {
                FormLoaiDocGia.txbMaLoaiDocGia.Text = "MLDG003";
                FormLoaiDocGia.txbTenLoaiDocGia.Text = "Bác Sĩ";
                FormLoaiDocGia.btnCapNhat_Click(null, e);
            }
            catch (Exception ex)
            {
                k = false;
            }

            // Assert
            Assert.AreEqual(true, (k));
        }
    }
}
