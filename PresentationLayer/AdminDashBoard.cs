using MaterialSkin;
using MaterialSkin.Controls;
using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using DAL.Models;

namespace PresentationLayer
{
    public partial class AdminDashBoard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly SaleService _saleService;
        private readonly SaleDetailsService _saleDetailsService;
        private readonly ProductService _productService;
        public AdminDashBoard()
        {
            InitializeComponent();
            _productService = new ProductService();
            _saleDetailsService = new SaleDetailsService();
            _saleService = new SaleService();
            // Apply Material Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500,
                Accent.LightBlue700, TextShade.WHITE
            );
            this.Load += AdminDashBoard_Load;
        }
        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            loadProductInCB();
            LoadSaleData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadProductInCB()
        {
            var allProduct = _productService.GetAll().ToList();

            if (allProduct.Count == 0)
            {
                MessageBox.Show("No products available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CB_Product.DataSource = allProduct;
            CB_Product.DisplayMember = "Name";
            CB_Product.ValueMember = "ProductId";
            CB_Product.SelectedIndex = -1; // Optionally clear the selected item
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //add Sale With noname $$ product (saleDetails)
        // button add Product 
        private void AddSale_Click(object sender, EventArgs e)
        {
            if (CB_Product.SelectedIndex == -1 || (n_QTY.Value <= 0))
            {
                MessageBox.Show("Failed to add Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sale = _saleService.GetLastSaleWithNoName();
                addSaleWithoutCustName(sale);
                sale = _saleService.GetLastSaleWithNoName();
                var rlt = _saleDetailsService.AddSalesDetails(sale.Id, (int)CB_Product.SelectedValue!, (int)n_QTY.Value);

                if (!rlt)
                {
                    MessageBox.Show("Failed to add Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Clearfilds();
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Clearfilds()
        {
            CB_Product.SelectedIndex = -1;
            n_QTY.Value = 0;
            
        }
        private void addSaleWithoutCustName(Sale sale)
        {

            //add sale  With noname
            if (sale == null)
            {
                var result = _saleService.AddSale(null!);
                if (!result)
                {
                    MessageBox.Show("Failed to add sale", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (Txt_CName.Text != null && Txt_CName.Text.Length > 3 && n_QTY.Value == 0 && CB_Product.SelectedValue == null)
            {
                var result = _saleService.AddSale(Txt_CName.Text);
                Txt_CName.Text = string.Empty;
            }
            //get new data
            LoadSaleData(); 
            dgv_SaleDetails.DataSource = null;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSaleData();
        }
        private void LoadSaleData()
        {
            dgv_Sale.DataSource = _saleService.GetSalesWithoutNoName();
            var sales = _saleService.GetSalesWithoutNoName();
            if (sales.Count == 0)
            {
                MessageBox.Show("No sales data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        int SaleId;
        private void dgv_Sale_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SaleId = (int)(dgv_Sale.SelectedRows[0].Cells[0].Value)!;
            getSaleDetals();
        }

        private void getSaleDetals()
        {
            var SaleDetails = _saleDetailsService.GetSaleDetailsById(SaleId);
            dgv_SaleDetails.DataSource = SaleDetails;
            dgv_SaleDetails.Columns["ProductId"]!.Visible = false;
            dgv_SaleDetails.Columns["Sale"]!.Visible = false;
            dgv_SaleDetails.Columns["Sale"]!.Visible = false;

        }

        private void CB_Product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
