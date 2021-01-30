using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dropbox05
{
    public partial class Form1 : Form
    {
        private List<Inventory> allInventory = new List<Inventory>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("inventory.txt"))
            {
                string sku;
                while ((sku = sr.ReadLine()) != null)
                {
                    string iName = sr.ReadLine();
                    int numOnHand = int.Parse(sr.ReadLine());
                    // creat the inventory
                    Inventory i = new Inventory(sku, iName, numOnHand);
                    allInventory.Add(i);
                    skuComboBox.Items.Add(i.SKU);
                }
            }
        }

        private void skuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // detect which product is selected
            int selectedIndex = skuComboBox.SelectedIndex;
            inventoryListBox.Items.Clear();
            string[] multipleLines = allInventory[selectedIndex].ToString().Split(',');
            foreach (string s in multipleLines)
            {
                inventoryListBox.Items.Add(s);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
