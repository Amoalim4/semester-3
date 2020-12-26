using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharpecoursework
{
    public partial class List_SellsForm : Form
    {
        public List_SellsForm()
        {
            InitializeComponent();
            SellsClass sellIt = new SellsClass();
            sellIt.list();
            ricBoxShowDetails.Text = sellIt.sellsInfo;
        }

        private void ricBoxShowDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
