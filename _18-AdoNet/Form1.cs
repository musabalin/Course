using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _product = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _product.GetAll();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _product.Add(new Product
            {
                Name = TxtName.Text,
                StockAmount = Convert.ToInt32(txtStockAmount.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text)
            });
            dataGridView1.DataSource = _product.GetAll();

            MessageBox.Show("Added");

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
               
            };
            _product.Delete(product);
            dataGridView1.DataSource = _product.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = textBox1.Text,
                UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt16(textBox3.Text)
            };
            _product.Update(product);
            dataGridView1.DataSource = _product.GetAll();
        }
    }
}
