using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Joshua_Cowell
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void btnModifyAddProductCancel_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }
    }
}
