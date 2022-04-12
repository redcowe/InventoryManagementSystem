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
    public partial class AddPart : Form
    {

        
        public AddPart()
        {
            InitializeComponent();
            
        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }

        private void btnPartCancel_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void rdbtnPartsOutsourced_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnPartsInHouse_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
