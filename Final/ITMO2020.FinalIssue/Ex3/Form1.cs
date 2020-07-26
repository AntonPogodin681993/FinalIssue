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

namespace Ex3
{
    public partial class SalesViewer : Form
    {
        private OrdersDatabaseEntities orderContext;
        public SalesViewer()
        {
            InitializeComponent();
        }

        private void SalesViewer_Load(object sender, EventArgs e)
        {
            salesGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            orderContext = new OrdersDatabaseEntities();

            var orders = from d in orderContext.Customers.Include("Orders")
                              orderby d.CustomerID
                              select d;

            try
            {
                this.salesList.DisplayMember = "LastName";
                this.salesList.DataSource = orders.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Customer order = (Customer)this.salesList.SelectedItem;
                salesGridView.DataSource = order.Orders.ToList();
                salesGridView.Columns["LineItems"].Visible = false;
                salesGridView.Columns["Customer"].Visible = false;
                salesGridView.AllowUserToDeleteRows = false;
                salesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                orderContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
            orderContext.Dispose();
        }
    }
}
