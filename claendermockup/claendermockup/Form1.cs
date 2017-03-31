using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claendermockup
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

            //function call to load treeNode objects from democode or text file
            treeView1.Nodes.Add(CatalogLoad.Load());
        }

        //allows dragging from treeview.  
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var node = (TreeNode)e.Item;
            if (node.Level > 0)
            {
                DoDragDrop(node.Text, DragDropEffects.Copy);
            }
        }

        //allows the drag to enter in the listbox
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //allows the dragging event to start in the text box
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string))) e.Effect = DragDropEffects.Copy;
        }


        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //Start of ListBox9
        //*******************************************************************************************************************
        private void listBox9_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        //allows items to be dropped in listbox
        private void listBox9_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                //listBox9.Items.Clear();
                //listBox9.Items.Add(str);

            }
        }

        //end of ListBox9
        //*******************************************************************************************************************


        //start of combo box manager
        //combo box1
        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label27.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label24.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label28.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label4_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label29.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label5_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label30.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label6_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label31.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox 1 

        //start of combobox2
        private void label7_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label36.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label8_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label37.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label9_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label35.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label10_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label34.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label11_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label33.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label12_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label32.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox2 
        
        //start of combobox3
        private void label13_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label45.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label14_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label46.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label15_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label44.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label16_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label43.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label17_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label42.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label18_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label41.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox3

        //start of combobox4
        private void label19_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label54.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label20_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label55.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label21_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label53.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label22_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label52.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label23_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label51.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label24_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label50.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox4

        //start of combobox5
        private void label25_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label63.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label26_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label64.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label27_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label62.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label28_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label61.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label29_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label60.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label30_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label59.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox5

        //start of combobox6
        private void label31_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label72.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label32_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label73.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label33_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label71.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label34_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label70.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label35_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label69.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label36_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label68.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox6

        //start of combobox7
        private void label37_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label81.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label38_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label82.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label39_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label80.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label40_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label79.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label41_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label78.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label42_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label77.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox7

        //start of combobox8
        private void label43_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label90.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label44_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label91.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label45_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label89.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label46_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label88.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label47_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label87.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label48_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label86.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox8
    }
}

