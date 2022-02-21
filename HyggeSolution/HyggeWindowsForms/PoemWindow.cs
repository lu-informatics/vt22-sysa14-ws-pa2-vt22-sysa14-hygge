using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyggeWindowsForms
{
    public partial class PoemWindow : Form
    {
        public PoemWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String fileName = cmbPoems.SelectedItem.ToString();
            String fileContent = proxy.FetchPoem(fileName);
            txtBox.Text = fileContent;
        }
    }
}
