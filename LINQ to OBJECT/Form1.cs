using LINQ_to_OBJECT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LINQ_to_OBJECT
{
    public partial class Form1 : Form
    {
        List<Product> ProductList = new List<Product>();
        List<Product> SearchProductList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            ProductList.Add(new Product("sp1", "sữa bò", 5, 50000, "Nhật bản", new DateTime(2024,8,23)));
            ProductList.Add(new Product("sp2", "sữa dê", 25, 100000, "Hàn Quốc", new DateTime(2024, 12, 22)));
            ProductList.Add(new Product("sp3", "khoai tây lắc", 10, 60000, "Nhật bản", new DateTime(2025, 2, 11)));
            ProductList.Add(new Product("sp4", "Mì xào giòn", 12, 80000, "Việt Nam", new DateTime(2025, 8, 23)));
            gvproduct.DataSource = ProductList;
        }

        private void btnluusp_Click(object sender, EventArgs e)
        {
            string masp, tensp, xuatxu;
            int soluong = 0, dongia = 0;
            DateTime ngayhethan;
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtquantity.Text) || string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtorigin.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!int.TryParse(txtquantity.Text, out soluong) || !int.TryParse(txtprice.Text, out dongia))
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ");
            }
            else
            {
                masp = txtid.Text;
                tensp = txtname.Text;
                xuatxu = txtorigin.Text;
                ngayhethan = datetime.Value;
                Product product = new Product(masp, tensp, soluong, dongia, xuatxu, ngayhethan);
                ProductList.Add(product);
                gvproduct.DataSource = null;
                gvproduct.DataSource = ProductList;
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtorigin.Clear();
            txtquantity.Clear();
            
        }

        private void btnmaxgia_Click(object sender, EventArgs e)
        {
            var maxPriceProduct = ProductList.OrderByDescending(p => p.Price).FirstOrDefault();
            SearchProductList.Clear();
            SearchProductList.Add(maxPriceProduct);
            gvsearch.DataSource= null;
            gvsearch.DataSource = SearchProductList;
        }

        private void btnnhatban_Click(object sender, EventArgs e)
        {
            var japaneseProducts = ProductList.Where(p => p.Origin.Equals("Nhật Bản", StringComparison.OrdinalIgnoreCase)).ToList();

            if (japaneseProducts.Count > 0)
            {
                gvsearch.DataSource = null;
                gvsearch.DataSource = japaneseProducts;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào từ Nhật Bản.");
            }
        }

        private void btncheckdate_Click(object sender, EventArgs e)
        {
            var expiredProducts = ProductList.Where(p => p.Date < DateTime.Now).ToList();
            if (expiredProducts.Count > 0)
            {
                MessageBox.Show("Có sản phẩm bị hết hạn!");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào bị hết hạn.");
            }
        }

        private void btnoutprice_Click(object sender, EventArgs e)
        {
            int minprice=0, maxprice=0;
            if(!int.TryParse(txtminprice.Text,out minprice)||!int.TryParse(txtmaxprice.Text,out maxprice))
            {
                MessageBox.Show("Vui lòng nhập giá cả hợp lệ");
            }
            else
            {
                var filteredProducts = ProductList.Where(p => p.Price >= minprice && p.Price <= maxprice).ToList();
                if (filteredProducts.Count > 0)
                {
                    gvsearch.DataSource = null;
                    gvsearch.DataSource = filteredProducts;
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm trong tầm giá đã chọn");
                }
            }
        }

        private void btnoutdate_Click(object sender, EventArgs e)
        {
            var outdateProducts = ProductList.Where(p => p.Date < DateTime.Now).ToList();
            gvsearch.DataSource = null;
            gvsearch.DataSource=outdateProducts;
        }

        private void btndeleteid_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtdeleteorigin.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string origin = txtdeleteorigin.Text;
                ProductList.RemoveAll(p => p.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase));
                gvproduct.DataSource = null;
                gvproduct.DataSource = ProductList;
            }
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            ProductList.Clear();
            gvproduct.DataSource = null;
            gvproduct.DataSource = ProductList;
        }

        private void btndeletedate_Click(object sender, EventArgs e)
        {
            ProductList.RemoveAll(p => p.Date < DateTime.Now);
            gvproduct.DataSource = null;
            gvproduct.DataSource = ProductList;
        }
    }
}
