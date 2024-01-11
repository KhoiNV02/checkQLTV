using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TraCuuSach;
namespace test
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var search = new FormTraCuu();
            try
            {
                search.loadCombobox();
                Assert.IsNotNull(search.cbMaSach.DataSource);
                Assert.IsNotNull(search.cbTheLoai.DataSource);
                Assert.IsNotNull(search.cbTenSach.DataSource);
                Assert.IsNotNull(search.cbTacGia.DataSource);
            }
            catch (Exception ex) {
                
            }
           
        }
    }
}
