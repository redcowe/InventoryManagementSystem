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
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void txtModifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }
    }
}
