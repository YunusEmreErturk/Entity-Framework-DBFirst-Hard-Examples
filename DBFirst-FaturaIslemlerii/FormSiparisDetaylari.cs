using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 
namespace DBFirst_FaturaIslemlerii
{
    public partial class FormSiparisDetaylari : Form
    {
        private int gelenOrderID;
        private Order gelenOrder;
        private Order_Detail secilenOrderDetails;
        private int secilenProductID;
        SatisEntities db = new SatisEntities();
        
        public FormSiparisDetaylari()
        {
            InitializeComponent();
        }
        public FormSiparisDetaylari(int secilenOrderID)
        {
            InitializeComponent();
            gelenOrderID = secilenOrderID;
            gelenOrder = db.Orders.Find(gelenOrderID); 

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillCustomers();
            FillEmployee();
            FillShipVia();
            FillProducts();
            FillOrderHeader();
            FillOrderDetail();
        }

        public void FillOrderHeader()
        {

            txtOrderID.Text = gelenOrderID.ToString();
            txtOrderID.Enabled = false;
            cmbCustomer.SelectedValue = gelenOrder.CustomerID;
            cmbEmployee.SelectedValue = gelenOrder.EmployeeID;
            cmbShipVia.SelectedValue = gelenOrder.ShipVia;
            txtCustomerMulti.Text = gelenOrder.ShipAddress;
            txtCityCountry.Text = gelenOrder.ShipCity + " " + gelenOrder.ShipCountry;
            txtFreight.Text = gelenOrder.Freight.ToString();
            
        }

        public void FillOrderDetail()
        {
            var odList = db.Order_Details.Select(x => new
            {
                x.OrderID,
                x.ProductID,
                x.Product.ProductName,
                x.UnitPrice,
                x.Quantity,
                x.Discount,
                total = x.Quantity * x.UnitPrice
            }).Where(x => x.OrderID == gelenOrderID).ToList();

            txtToplamSiparis.Text = odList.Sum(x => x.total).ToString();
            dataGridViewOrderDetails.DataSource = odList;

        }

        public void FillCustomers()
        {

            var list = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName

            }).ToList();

            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = list;

        }
        public void FillEmployee()
        {

            var list = db.Employees.Select(x => new
            {
                x.EmployeeID,
                FullName = x.FirstName + " " + x.LastName

            }).ToList();

            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = list;

        }

        public void FillShipVia()
        {

            var list = db.Shippers.Select(x => new
            {
                x.ShipperID,
                x.CompanyName

            }).ToList();

            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DataSource = list;

        }
        decimal unitPrice;
        public void FillProducts()
        {

            var list = db.Products.Select(x => new
            {
                x.UnitPrice,
                x.ProductName,
                x.ProductID

            }).ToList();
            foreach (var item in list)
            {
                unitPrice =Convert.ToDecimal(item.UnitPrice);
            }
            

            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = list;

        }

        public string city, country;

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                db.Orders.Remove(gelenOrder);
                db.SaveChanges();
                MessageBox.Show("Sipariş Silindi");
                FillOrderDetail();
            }
            catch (Exception)
            {

                MessageBox.Show("Once Detaylari Silin");
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

            Order_Detail od = new Order_Detail();
            od.OrderID = gelenOrderID;
            od.ProductID =Convert.ToInt32(cmbProduct.SelectedValue);
            od.Quantity = Convert.ToInt16(txtQuantityy.Text);
            od.UnitPrice = unitPrice;
            od.Discount = 0;

            db.Order_Details.Add(od);
            db.SaveChanges();
            FillOrderDetail();

            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }
        }

        private void dataGridViewOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenProductID=(int)dataGridViewOrderDetails.CurrentRow.Cells[1].Value;
            secilenOrderDetails = db.Order_Details.Find(gelenOrderID, secilenProductID);

            txtQuantityy.Text = secilenOrderDetails.Quantity.ToString();
            cmbProduct.SelectedValue = secilenProductID;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

            db.Order_Details.Remove(secilenOrderDetails);
            db.SaveChanges();
            FillOrderDetail();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

            db.Order_Details.Remove(secilenOrderDetails);
            Order_Detail od = new Order_Detail();
            od.OrderID = Convert.ToInt32(txtOrderID.Text);
            od.ProductID = (int)cmbProduct.SelectedValue;
            od.Quantity = Convert.ToInt16(txtQuantityy.Text);
            Product product = db.Products.Find(od.ProductID);
            od.UnitPrice = (decimal)product.UnitPrice;
            db.Order_Details.Add(od);
            od.Discount = 0;
            db.SaveChanges();

            MessageBox.Show("Update Successfully");
            FillOrderDetail();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

            if (db.Orders.Any(x=>x.OrderID == gelenOrderID))
            {

            var city_country = db.Customers.Where(x => x.CustomerID == cmbCustomer.SelectedValue);
            foreach (var item in city_country)
            {
                city = item.City.ToString();
                country = item.Country;
            }


            var updateOrder = db.Orders.Where(x => x.OrderID == gelenOrderID);
            foreach (var item in updateOrder)
            {
                item.CustomerID = cmbCustomer.SelectedValue.ToString();
                item.EmployeeID = (int)cmbEmployee.SelectedValue;
                item.ShipVia =(int)cmbShipVia.SelectedValue;
                item.ShipAddress = txtCustomerMulti.Text;
                item.ShipCity = city;
                item.ShipCountry = country;
                item.Freight =Convert.ToDecimal(txtFreight.Text);

            }
                MessageBox.Show("Update Başarılı");
                db.SaveChanges();
                FillOrderHeader();
            }
            else
            {
                MessageBox.Show("Böyle bir OrderID YOK !");
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }
        }

        }

    }

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 
