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
    public partial class show_recentiesForm : Form
    {
        public show_recentiesForm()
        {
            InitializeComponent();
            CarClass class_of_car = new CarClass();
            class_of_car.recently(ricshowrecenties.Text);
            ricshowrecenties.Text = class_of_car.list_recently;
        }
    }
}
