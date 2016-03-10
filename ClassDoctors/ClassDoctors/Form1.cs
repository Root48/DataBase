using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDoctors
{
    public partial class Form1 : Form
    {
        HospitalEntities H;

        public Form1()
        {
            InitializeComponent();
        }

        private void dOCTORS_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            H.SaveChanges();
            this.Validate();
            this.dOCTORS_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            H = new HospitalEntities ();
            DOCTORS_1BindingSource.DataSource = H.DOCTORS_1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.DOCTORS_1". При необходимости она может быть перемещена или удалена.
            // this.dOCTORS_1TableAdapter.Fill(this.hospitalDataSet.DOCTORS_1);


        }
    }
}
