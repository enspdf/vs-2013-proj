using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CargarGrid()
        {
            using (AdbEntities context = new AdbEntities())
            {
                IQueryable<Customer> Cliente = from q in context.Customer
                                               select q;
                List<Customer> lista = Cliente.ToList();

                DGCostumer.DataSource = lista;
                DGCostumer.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int vId = Convert.ToInt32(this.txtCustomerId.Text);
            using (AdbEntities context = new AdbEntities())
            {
                IQueryable<Customer> Cliente = from q in context.Customer
                                               where q.CustomerID == vId
                                               select q;
                List<Customer> lista = Cliente.ToList();
                var oCliente = lista[0];

                chkNameStyle.Checked = oCliente.NameStyle;
                txtTitle.Text = oCliente.Title;
                txtFirstName.Text = oCliente.FirstName;
                txtMiddleName.Text = oCliente.MiddleName;
                txtLastName.Text = oCliente.LastName;
                txtSuffiix.Text = oCliente.Suffix;
                txtCompanyName.Text = oCliente.CompanyName;
                txtSalesPerson.Text = oCliente.SalesPerson;
                txtEmailAddress.Text = oCliente.EmailAddress;
                txtPhone.Text = oCliente.Phone;
                txtPasswordHash.Text = oCliente.PasswordHash;
                txtPasswordSalt.Text = oCliente.PasswordSalt;
            }
        }

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnInfo_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int CustId = Convert.ToInt32(txtCustomerId.Text);

                if (CustId <= 0)
                {
                    //Insertar
                    Insertar();
                }
                else
                {
                    //Actualizar
                    Actualizar();
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                CargarGrid();
            }
        }

        private void Actualizar()
        {
            int CustId = Convert.ToInt32(txtCustomerId.Text);

            using (AdbEntities context = new AdbEntities())
            {
                Customer oCliente = context.Customer.SingleOrDefault(p => p.CustomerID == CustId);

                //MessageBox.Show(oCliente.LastName);

                oCliente.NameStyle = chkNameStyle.Checked;
                oCliente.Title = txtTitle.Text;
                oCliente.FirstName = txtFirstName.Text;
                oCliente.MiddleName = txtMiddleName.Text;
                oCliente.LastName = txtLastName.Text;
                oCliente.Suffix = txtSuffiix.Text;
                oCliente.CompanyName = txtCompanyName.Text;
                oCliente.SalesPerson = txtSalesPerson.Text;
                oCliente.EmailAddress = txtEmailAddress.Text;
                oCliente.Phone = txtPhone.Text;
                oCliente.PasswordHash = txtPasswordHash.Text;
                oCliente.PasswordSalt = txtPasswordSalt.Text;

                context.SaveChanges();
            }
        }

        private void Insertar()
        {
            try
            {
                using(AdbEntities context = new AdbEntities())
                {
                    Customer oCliente = new Customer
                    {
                        NameStyle = chkNameStyle.Checked,
                        Title = txtTitle.Text,
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        Suffix = txtSuffiix.Text,
                        CompanyName = txtCompanyName.Text,
                        SalesPerson = txtSalesPerson.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Phone = txtPhone.Text,
                        PasswordHash = txtPasswordHash.Text,
                        PasswordSalt = txtPasswordSalt.Text,
                        ModifiedDate = DateTime.Now
                    };

                    MessageBox.Show(string.Format("Id = {0} - LastName = {1}", oCliente.CustomerID, oCliente.LastName));

                    context.Customer.Add(oCliente);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationErrors.ValidationErrors));
                    }
                }
            }
            finally
            {
                CargarGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CustId = Convert.ToInt32(txtCustomerId.Text);

            using (AdbEntities context = new AdbEntities())
            {
                //Customer oCliente = context.Customer.SingleOrDefault(p => p.CustomerID == CustId);
                Customer oCliente = (from q in context.Customer
                                     where q.CustomerID == CustId
                                     select q).First();

                try
                {
                    context.Customer.Remove(oCliente);
                    context.SaveChanges();

                    CargarGrid();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
