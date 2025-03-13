﻿using BLL;
using DAL.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;


namespace PresentationLayer
{
    public partial class AdminDashBoard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        SupplierService supplierService;

        int ProductId;
        ProductService PS = new ProductService();
        StockService S = new StockService();
        SaleService SaleService = new SaleService();
        SaleDetailsService Sd = new SaleDetailsService();
        ReportService reportService = new ReportService();
        public AdminDashBoard()
        {
            InitializeComponent();
            // Apply Material Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500,
                Accent.LightBlue700, TextShade.WHITE
            );
            supplierService = new SupplierService();
            //LoadSuppliers();
        }
        private async void AdminDashBoard_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSupplier();
            LoadCategory();
            LoadStock();
            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;
            lbl_CountOfProd.Text = PS.GetTotalCount().ToString();
            lbl_dashTotalSales.Text = SaleService.GetTotalRevenue().ToString();
            lbl_dashTotalCust.Text = SaleService.GetTotalCustomers().ToString();
            lbl_dashBestSellingProd.Text = Sd.GetBestSellingProduct().ToString();
            lbl_dashTotalOrders.Text = SaleService.GetTotalOrders().ToString();
            lbl_dashLowStock.Text = PS.GetLowStockProdCount().ToString();
            await Task.Delay(500);
            CheckLowStock();
            loadProductInCB();
            LoadSaleData();
             LoadSalesIntoComboBox();
        }

        private void dgv_dashStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_dashStock.Columns[e.ColumnIndex].Name == "Status")
            {
                if (dgv_dashStock.Rows[e.RowIndex].Cells["TotalStock"].Value != null)
                {
                    int quantity = Convert.ToInt32(dgv_dashStock.Rows[e.RowIndex].Cells["TotalStock"].Value);

                    if (quantity < 10)
                    {
                        e.Value = "Low";
                        e.CellStyle.ForeColor = Color.Red;

                    }
                    else if (quantity <= 20)
                    {
                        e.Value = "Medium";
                        e.CellStyle.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        e.Value = "High";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    e.CellStyle.Font = new Font(dgv_dashStock.Font, FontStyle.Bold);
                }
            }
        }
        #region Product Tap
        public void LoadProducts()
        {
            var Products = PS.GetAll();
            dgv_Products.DataSource = Products;
            dgv_Products.Columns["ProductId"].Visible = false;

            dgv_Products.RowTemplate.Height = 40;

            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;

            dgv_dashStock.DataSource = Products;
            dgv_dashStock.Columns["ProductId"].Visible = false;
            dgv_dashStock.Columns["Price"].Visible = false;
            dgv_dashStock.Columns["CategoryName"].Visible = false;
            dgv_dashStock.Columns["SupplierName"].Visible = false;

            cmb_stockProd.DataSource = Products.Select(p => new
            {
                Id = (int)p.GetType().GetProperty("ProductId").GetValue(p),
                Name = (string)p.GetType().GetProperty("Name").GetValue(p)
            }).ToList();
            cmb_stockProd.ValueMember = "Id";
            cmb_stockProd.DisplayMember = "Name";
        }
        public void LoadSupplier()
        {
            SupplierService S = new SupplierService();
            cmb_SupProduct.DataSource = S.GetAll();
            cmb_SupProduct.ValueMember = "Id";
            cmb_SupProduct.DisplayMember = "Name";
            cmb_SupProduct.SelectedIndex = -1;

            cmb_searchProdSupplier.DataSource = S.GetAll();
            cmb_searchProdSupplier.ValueMember = "Id";
            cmb_searchProdSupplier.DisplayMember = "Name";
            cmb_searchProdSupplier.SelectedIndex = -1;
        }
        public void LoadCategory()
        {
            CategoryService GS = new CategoryService();
            cmb_CatProducts.DataSource = GS.GetAllCategories();
            cmb_CatProducts.ValueMember = "Id";
            cmb_CatProducts.DisplayMember = "Name";
            cmb_CatProducts.SelectedIndex = -1;

            cmb_searchProdCat.DataSource = GS.GetAllCategories();
            cmb_searchProdCat.ValueMember = "Id";
            cmb_searchProdCat.DisplayMember = "Name";
            cmb_searchProdCat.SelectedIndex = -1;
        }
        private void txt_PriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void dgv_Products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgv_Products.SelectedRows[0];
            ProductId = (int)row.Cells["ProductId"].Value;
            Product P = PS.GetById(ProductId);
            txt_NameProduct.Text = P.Name;
            txt_PriceProduct.Text = P.Price.ToString();
            cmb_CatProducts.SelectedValue = P.CategoryId;
            cmb_SupProduct.SelectedValue = P.SupplierId;
            cmb_CatProducts.Refresh();
            cmb_SupProduct.Refresh();
            btn_EditProduct.Visible = true;
            btn_deleteProduct.Visible = true;
            btn_AddProduct.Visible = false;
            btn_ResetProduct.Location = new Point(400, 227);
            lbl_quantityProd.Visible = false;
            txt_QuantityProd.Visible = false;
        }
        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            btn_ResetProduct.Location = new Point(462, 227);
            btn_AddProduct.Visible = true;
            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;
            txt_NameProduct.Clear();
            txt_PriceProduct.Clear();
            txt_PriceProduct.Clear();
            txt_QuantityProd.Clear();
            cmb_CatProducts.SelectedIndex = -1;
            cmb_SupProduct.SelectedIndex = -1;
            cmb_CatProducts.Refresh();
            cmb_SupProduct.Refresh();
            lbl_quantityProd.Visible = true;
            txt_QuantityProd.Visible = true;
        }
        private bool ValidateProductInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_NameProduct.Text) ||
                string.IsNullOrWhiteSpace(txt_PriceProduct.Text) ||
                cmb_CatProducts.SelectedIndex == -1 ||
                cmb_SupProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInputs()) return;

            var Name = txt_NameProduct.Text;
            decimal Price = decimal.Parse(txt_PriceProduct.Text);
            int CategoryId = (int)cmb_CatProducts.SelectedValue;
            int SupplierId = (int)cmb_SupProduct.SelectedValue;
            int Quantity = int.Parse(txt_QuantityProd.Text);

            PS.Add(Name, Price, CategoryId, SupplierId, Quantity);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(100);
            LoadProducts();
            btn_ResetProduct_Click(sender, e);
        }
        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInputs()) return;

            var Name = txt_NameProduct.Text;
            decimal Price = decimal.Parse(txt_PriceProduct.Text);
            int CategoryId = (int)cmb_CatProducts.SelectedValue;
            int SupplierId = (int)cmb_SupProduct.SelectedValue;

            PS.Update(ProductId, Name, Price, CategoryId, SupplierId);
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
            btn_ResetProduct_Click(sender, e);
        }
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you Want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                PS.Delete(ProductId);
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                btn_ResetProduct_Click(sender, e);
            }
        }
        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            string Name = txt_searchProdName.Text;
            int? CategoryId = null;
            if (cmb_searchProdCat.SelectedIndex != -1 && cmb_searchProdCat.SelectedValue != null)
            {
                CategoryId = Convert.ToInt32(cmb_searchProdCat.SelectedValue);
            }
            int? SupplierId = null;
            if (cmb_searchProdSupplier.SelectedIndex != -1 && cmb_searchProdSupplier.SelectedValue != null)
            {
                SupplierId = Convert.ToInt32(cmb_searchProdSupplier.SelectedValue);
            }
            var results = PS.Search(Name, CategoryId, SupplierId);
            dgv_Products.DataSource = results;
            dgv_Products.Refresh();
            dgv_Products.Columns["ProductId"].Visible = false;
        }
        private void btn_resetSearchProd_Click(object sender, EventArgs e)
        {
            txt_searchProdName.Clear();
            cmb_searchProdCat.SelectedIndex = -1;
            cmb_searchProdSupplier.SelectedIndex = -1;
            cmb_searchProdCat.Refresh();
            cmb_searchProdSupplier.Refresh();
            LoadProducts();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignForm signForm = new SignForm();
                signForm.ShowDialog();
                this.Close();
            }
        }
        #endregion
        #region Stock Tap
        public void LoadStock()
        {
            var stocks = S.GetAll();
            dgv_StockTap.DataSource = stocks;
            dgv_StockTap.Columns["ProductId"].Visible = false;
            cmb_StockType.SelectedIndex = -1;
            cmb_stockProd.SelectedIndex = -1;
        }
        private void CheckLowStock()
        {
            bool lowStockExists = false;
            foreach (DataGridViewRow row in dgv_dashStock.Rows)
            {
                if (row.Cells["TotalStock"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["TotalStock"].Value);
                    if (quantity < 10)
                    {
                        lowStockExists = true;
                        break;
                    }
                }
            }
            if (lowStockExists)
            {
                MessageBox.Show("There are low stock products that need to be restocked!", "Stock alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_StockSearch_Click(object sender, EventArgs e)
        {
            int? productId = cmb_stockProd.SelectedValue as int?;
            string stocktype = cmb_StockType.SelectedItem?.ToString() ?? "";

            var results = S.SearchStocks(stocktype, productId);

            dgv_StockTap.DataSource = results;
        }
        private void btn_StockReset_Click(object sender, EventArgs e)
        {
            cmb_StockType.SelectedIndex = -1;
            cmb_stockProd.SelectedIndex = -1;
            cmb_stockProd.Refresh();
            cmb_StockType.Refresh();

            dgv_StockTap.DataSource = S.GetAll();
        }
        #endregion


        // my code Ahmed Ramadan
        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (CB_Product.SelectedIndex == -1 || (n_QTY.Value <= 0) || Txt_CName.Text.Length <= 2)
            { 
                MessageBox.Show("Failed to add Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sale = SaleService.GetLastSaleWithNoName();
                addSaleWithoutCustName(sale);
                sale = SaleService.GetLastSaleWithNoName();
                var rlt = Sd.AddSalesDetails(sale.Id, (int)CB_Product.SelectedValue!, (int)n_QTY.Value);

                if (!rlt)
                {
                    MessageBox.Show("Failed to add Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Clearfilds();
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_CName.ReadOnly = true;
                    Txt_CName.ForeColor = Color.Gray;
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
                var result = SaleService.AddSale(null!);
                if (!result)
                {
                    MessageBox.Show("Failed to add sale", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (Txt_CName.Text.Length <= 3)
            {
                Txt_CName.ReadOnly = false;
                MessageBox.Show("name length shoud by more than 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (Txt_CName.Text != null && Txt_CName.Text.Length > 3 && n_QTY.Value == 0 && CB_Product.SelectedValue == null)
            {
                var result = SaleService.AddSale(Txt_CName.Text);
                Txt_CName.Text = string.Empty;
                Txt_CName.ReadOnly = false ;
                Txt_CName.ForeColor = Color.White;
            }else
            {
                CB_Product.SelectedValue = -1;
                MessageBox.Show("remove value from Quantity or add new product first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //get new data
            LoadSaleData();
            dgv_SaleDetails.DataSource = null;
        }
        private void LoadSaleData()
        {
            dgv_Sale.DataSource = SaleService.GetSalesWithoutNoName();
            var sales = SaleService.GetSalesWithoutNoName();
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
            var SaleDetails = Sd.GetSaleDetailsById(SaleId);
            dgv_SaleDetails.DataSource = SaleDetails;
            dgv_SaleDetails.Columns["ProductId"]!.Visible = false;
            dgv_SaleDetails.Columns["Sale"]!.Visible = false;
            dgv_SaleDetails.Columns["Sale"]!.Visible = false;

        }
        private void LoadSalesIntoComboBox()
        {

            var sales = SaleService.GetAll();

            if (sales == null || sales.Count == 0)
            {
                MessageBox.Show("No sales records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CB_SALES.DataSource = sales;
            CB_SALES.DisplayMember = "Customer_Name";
            CB_SALES.ValueMember = "Id";
        }
        private async void btn_Receive_sale_Click(object sender, EventArgs e)
        {
            try
            {

                myshoereport.Visible = true;
                await LoadHtmlReport((int)CB_SALES.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadHtmlReport(int saleid)
        {
            await myshoereport.EnsureCoreWebView2Async();

            string reportPath = reportService.GenerateHtmlReport(saleid);
            if (string.IsNullOrEmpty(reportPath))
            {
                MessageBox.Show("No sales data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 🟢 إجبار WebView2 على إعادة تحميل الصفحة بعد كل اختيار جديد
            myshoereport.Source = new Uri("about:blank");
            await Task.Delay(100); // إعطاء وقت قصير لإعادة التهيئة
            myshoereport.Source = new Uri(reportPath);
        }
        private void loadProductInCB()
        {
            var allProduct = PS.GetAll().ToList();

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









































































































































































































































































































































































































































        #region Helper methods
        public void LoadSuppliers()
        {
            List<Supplier> suppliers = supplierService.GetAll();


            dgv_supplier.AutoGenerateColumns = false;

            // Add columns manually (excluding Id)
            dgv_supplier.Columns.Clear();
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contact", DataPropertyName = "Contact" });
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });

            // Bind the data
            dgv_supplier.DataSource = suppliers;

        }

        public void ResetInputs()
        {
            txt_contact.Text = txt_Address.Text = txt_name.Text = string.Empty;
        }

        public bool CheckEmptyInput(string content, string message)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show($"Please enter a supplier {message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetInputs();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+?\d{10,15}$");
        }
        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string supplierName = txt_name.Text.Trim();
            string supplierContact = txt_contact.Text.Trim();
            string supplierAddress = txt_Address.Text.Trim();


            if (CheckEmptyInput(supplierName, "Name") ||
                CheckEmptyInput(supplierContact, "Contact") ||
                CheckEmptyInput(supplierAddress, "Address"))
            {
                return;
            }
            if (!IsValidPhoneNumber(supplierContact))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var existingSupplier = supplierService.GetSupplierByname(supplierName);
            if (existingSupplier != null)
            {
                MessageBox.Show("Supplier with this name already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isAdded = supplierService.Add(supplierName, supplierAddress, supplierContact);
            if (isAdded)
            {
                MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ResetInputs();
            }
            else
            {
                MessageBox.Show("Failed to add supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string originalName = "";
        private string originalContact = "";
        private string originalAddress = "";

        private void dgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_supplier.Rows[e.RowIndex];

                txt_name.Text = row.Cells[0].Value.ToString();
                txt_contact.Text = row.Cells[1].Value.ToString();
                txt_Address.Text = row.Cells[2].Value.ToString();

                originalName = txt_name.Text;
                originalContact = txt_contact.Text;
                originalAddress = txt_Address.Text;

                lbl_Id.Text = supplierService.GetAll()[e.RowIndex].Id.ToString();
            }
            btn_Add.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_Id.Text))
            {
                string supplierName = txt_name.Text.Trim();
                string supplierContact = txt_contact.Text.Trim();
                string supplierAddress = txt_Address.Text.Trim();

                if (CheckEmptyInput(supplierName, "Name") ||
                    CheckEmptyInput(supplierContact, "Contact") ||
                    CheckEmptyInput(supplierAddress, "Address"))
                {
                    return;
                }
                if (!IsValidPhoneNumber(supplierContact))
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int supplierId = int.Parse(lbl_Id.Text);


                if (supplierName == originalName && supplierContact == originalContact && supplierAddress == originalAddress)
                {
                    MessageBox.Show("No changes detected. Please modify some fields before updating.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isUpdated = supplierService.update(supplierId, supplierName, supplierAddress, supplierContact);

                if (isUpdated)
                {
                    MessageBox.Show("Supplier updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                    ResetInputs();
                    btn_Add.Enabled = true;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to update supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier first.");
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int supplierId = int.Parse(lbl_Id.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (supplierService.Delete(supplierId))
                    {
                        MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliers();
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string lastDisplayedReport = "ProductStock";
        public string GetUrl(string name)
        {
            return $"http://localhost/ReportServer?/Report%20Project/{name}&rs:Command=Render&rc:Toolbar=false&rc:Parameters=false&rc:Zoom=Page%20Width";
        }

        private void btn_currentStock_Click(object sender, EventArgs e)
        {
            string url = GetUrl("ProductStock");
            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
        }

        private void btn_salesPerformance_Click(object sender, EventArgs e)
        {
            string url = GetUrl("SalesPerformance");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "SalesPerformance";
        }

        private void btn_lowStock_Click(object sender, EventArgs e)
        {
            string url = GetUrl("LowStockLevel");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "LowStockLevel";
        }

        private void btn_mostSold_Click(object sender, EventArgs e)
        {
            string url = GetUrl("MostSoldProduct");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "MostSoldProduct";
        }
        private async Task DownloadReport(string format, string fileExtension)
        {
            try
            {
                string downloadUrl = GetUrl(lastDisplayedReport) + $"&rs:Format={format}";


                HttpClientHandler handler = new HttpClientHandler
                {
                    Credentials = CredentialCache.DefaultCredentials // Use logged-in user's credentials
                };

                using (HttpClient client = new HttpClient(handler))
                {
                    HttpResponseMessage response = await client.GetAsync(downloadUrl);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] reportBytes = await response.Content.ReadAsByteArrayAsync();



                    // Ensure the file contains valid Excel data
                    if (reportBytes.Length < 1000) // Arbitrary small file size check
                    {
                        MessageBox.Show("Downloaded file is too small. The report may not have been generated correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = $"{format} files|*.{fileExtension}",
                        Title = $"Save Report as {format}",
                        FileName = $"Report.{fileExtension}"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await File.WriteAllBytesAsync(saveFileDialog.FileName, reportBytes);
                        MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_DownloadPdf_Click(object sender, EventArgs e)
        {
            await DownloadReport("PDF", "pdf");
        }

        private async void btn_downloadExcel_Click(object sender, EventArgs e)
        {
            await DownloadReport("EXCELOPENXML", "xlsx");
        }

        
    }
}
