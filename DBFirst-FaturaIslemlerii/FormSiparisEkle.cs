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
    public partial class FormSiparisEkle : Form
    {
        


        public FormSiparisEkle()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            FillCustomers();
            FillEmployee();
            FillShipVia();
        }

        SatisEntities db = new SatisEntities();
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
            
            cmbEmploye.DisplayMember ="FullName";
            cmbEmploye.ValueMember = "EmployeeID";
            cmbEmploye.DataSource = list;

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

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerId = cmbCustomer.SelectedValue.ToString();
            var adres = db.Customers.Where(x => x.CustomerID == customerId).Select(x => new
            {
                x.Address
            }).ToList();

            foreach (var item in adres)
            {
                txtAdress.Text = item.Address.ToString();
            }
        }

        private void cmbShipVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int shipperId =Convert.ToInt32(cmbShipVia.SelectedValue);
            
        }
        public static string citys;
        public static string countrys;
        private void cmbEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int employeID =Convert.ToInt32(cmbEmploye.SelectedValue);
            var city = db.Employees.Where(x => x.EmployeeID == employeID).Select(x => new
            {   country = x.Country,
                city =x.City,
                FullName = x.Country + " " + x.City
            });
            foreach (var item in city)
            {
                txtCountryAndCity.Text = item.FullName.ToString();
                countrys = item.country;
                citys = item.city;
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CustomerID = cmbCustomer.SelectedValue.ToString() ;
            order.EmployeeID = Convert.ToInt32(cmbEmploye.SelectedValue);
            order.OrderDate = dateTimePickerOrder.Value;
            order.RequiredDate = dateTimePickerRequired.Value;
            order.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
            order.Freight = Convert.ToDecimal(txtFreight.Text);
            order.ShipAddress = txtAdress.Text;
            order.ShipCountry = countrys;
            order.ShipCity = citys;

            db.Orders.Add(order);
            db.SaveChanges();

            FormSiparisDetaylari frm = new FormSiparisDetaylari(order.OrderID);
            frm.Show();
            this.Hide();


        }
    }
}
//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 