using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class frmCustomerPreview : Form
    {
        public frmCustomerPreview()
        {
            InitializeComponent();
        }
        public void SetValues(String name, String Country, String Gender,
            String Hobby, String Status)
        {
            //Write code here
            label6.Text = name;
            label7.Text = Country;
            label8.Text = Gender;
            label9.Text = Hobby;
            label10.Text = Status;
        }
    }
}
