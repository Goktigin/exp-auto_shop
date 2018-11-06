using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        AutoShopEntities db = new AutoShopEntities();

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (var item in db.Countries)
            {
                cmbCountry.Items.Add(item);

            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country country = cmbCountry.SelectedItem as Country;

            foreach(var item in country.Markas)
            {
                cmbMarka.Items.Add(item);
            }
            
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marka marka = cmbMarka.SelectedItem as Marka;

            foreach(var item in marka.Models)
            {
                cmbModel.Items.Add(item);
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model model = cmbModel.SelectedItem as Model;

            carinfo.Text = "Name:"+model.Name +"\n" + model.Price + "\n"  + model.Marka + "\n"  + model.Motor + "\n" +model.Type + "\n"  + model.Year;
        }
    }
}
