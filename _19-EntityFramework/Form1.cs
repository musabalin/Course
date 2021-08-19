using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }

        private void LoadProduct()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStockAmount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = TxtName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            MessageBox.Show("Added");
            LoadProduct();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = TxtName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt16(txtStockAmount.Text)
            });
            LoadProduct();
            MessageBox.Show("Updated..");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)

            });
            LoadProduct();
            MessageBox.Show("Deleted..");
        }

        private void SearchProduct(string key)
        {
            //dataGridView1.DataSource = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            //veritabanında aratmak için sınıfta direk veritabanında arama yapılması daha verimli olur
            dataGridView1.DataSource = _productDal.GetByName(key);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(textBox1.Text);
        }
    }
}
