using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Ex4
{
    public partial class Form1 : Form
    {
        private OrdersDatabaseEntities productContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productContext = new OrdersDatabaseEntities();
        }

        private void showProductbutton_Click(object sender, EventArgs e)
        {
            productGridView.DataSource = productContext.Products.ToList();
        }

        private void addProductbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductName = this.nametextBox.Text,
                    Size = this.sizetextBox.Text,
                    Color = this.colortextBox.Text,
                    ProductID = Int32.Parse(this.IdBox.Text),
                };

                productContext.Products.Add(product);
                productContext.SaveChanges();
                productGridView.DataSource = productContext.Products.ToList();




                nametextBox.Text = String.Empty;
                sizetextBox.Text = String.Empty;
                colortextBox.Text = String.Empty;
                IdBox.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.CurrentRow == null)
                return;
            var product = productGridView.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;
            labelId.Text = Convert.ToString(product.ProductID);
            nametextBox.Text = product.ProductName;
            sizetextBox.Text = product.Size;
            colortextBox.Text = product.Color;
            IdBox.Text = Convert.ToString(product.ProductID);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty)
                return;
            var id = Convert.ToInt32(labelId.Text);
            var product = productContext.Products.Find(id);
            if (product == null)
                return;
            product.Size = this.sizetextBox.Text;
            product.ProductName = this.nametextBox.Text;
            product.Color = this.colortextBox.Text;
            product.ProductID = Int32.Parse(this.IdBox.Text);

            productContext.Entry(product).State = EntityState.Modified;
            productContext.SaveChanges();
            productGridView.DataSource = productContext.Products.ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty)
                return;
            var id = Convert.ToInt32(labelId.Text);
            var product = productContext.Products.Find(id);
            productContext.Entry(product).State = EntityState.Deleted;
            productContext.SaveChanges();
            productGridView.DataSource = productContext.Products.ToList();
        }
    }
}
