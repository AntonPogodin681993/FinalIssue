using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex2
{

    
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private OrderDatabaseDataSet.CustomersRow GetSelectedRow()
        {
            int CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value);
            OrderDatabaseDataSet.CustomersRow SelectedRow =
            orderDatabaseDataSet1.Customers.FindByCustomerID(CustomerID);

            return SelectedRow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderDatabaseDataSet1.Customers;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            sqlDataAdapter1.Fill(orderDatabaseDataSet1.Customers);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(orderDatabaseDataSet1);
        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
    }
}
