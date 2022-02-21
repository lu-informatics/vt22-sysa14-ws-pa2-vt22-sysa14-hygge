using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyggeWindowsForms.HyggeService;

namespace HyggeWindowsForms
{
    public partial class PoemWindow : Form
    {
        private HyggeServiceSoapClient proxy; // Added SoapClient as instance variable so that components can access it
        public PoemWindow()
        {
            InitializeComponent();
            proxy = new HyggeServiceSoapClient(); // Initialize the SoapClient
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try // Try/catch to catch any errors when fetching the file name
            {
                String fileName = cmbPoems.SelectedItem.ToString(); // Get selected poem from combobox cmbPoems
                String fileContent = proxy.FetchPoem(fileName); // Use proxy (SoapClient) and the file name to get file content
                txtBox.Text = fileContent; // Return the file content
            } 
            catch (NullReferenceException ex) // Catch NullReferenceException which will be thrown if cmbPoems.SelectedItem is null.
            {
                MessageBox.Show(ex.Message + " Please choose a poem from the drop down menu."); // Add message to make it clear to the user 
            }                                                                                   // that they should choose poems from the drop down
        }
    }
}
