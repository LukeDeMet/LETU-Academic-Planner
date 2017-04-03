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

        //start of combobox9
        private void label49_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label99.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label50_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label100.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label51_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label98.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label52_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label97.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label53_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label96.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label54_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label95.Text = (string)e.Data.GetData(typeof(string));
            }
        }
        //end of combobox 9


        //start of combobox 10
        private void label55_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label108.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label56_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label109.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label57_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label107.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label58_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label106.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label59_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label105.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void label60_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                label104.Text = (string)e.Data.GetData(typeof(string));
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings1.Default.Hours1 = textBox1.Text;    Settings1.Default.Class1 = label27.Text;    Settings1.Default.Grade1 = textBox3.Text;
            Settings1.Default.Hours2 = textBox15.Text;   Settings1.Default.Class2 = label24.Text;    Settings1.Default.Grade2 = textBox6.Text;
            Settings1.Default.Hours3 = textBox14.Text;   Settings1.Default.Class3 = label28.Text;    Settings1.Default.Grade3 = textBox7.Text;
            Settings1.Default.Hours4 = textBox13.Text;   Settings1.Default.Class4 = label29.Text;    Settings1.Default.Grade4 = textBox8.Text;
            Settings1.Default.Hours5 = textBox12.Text;   Settings1.Default.Class5 = label30.Text;    Settings1.Default.Grade5 = textBox9.Text;
            Settings1.Default.Hours6 = textBox11.Text;   Settings1.Default.Class6 = label31.Text;    Settings1.Default.Grade6 = textBox10.Text;
            Settings1.Default.Hours11 = textBox19.Text;  Settings1.Default.Class11 = label36.Text;   Settings1.Default.Grade11 = textBox18.Text;
            Settings1.Default.Hours12 = textBox20.Text;  Settings1.Default.Class12 = label37.Text;   Settings1.Default.Grade12 = textBox17.Text;
            Settings1.Default.Hours13 = textBox21.Text;  Settings1.Default.Class13 = label35.Text;   Settings1.Default.Grade13 = textBox16.Text;
            Settings1.Default.Hours14 = textBox22.Text;  Settings1.Default.Class14 = label34.Text;   Settings1.Default.Grade14 = textBox5.Text;
            Settings1.Default.Hours15 = textBox23.Text;  Settings1.Default.Class15 = label33.Text;   Settings1.Default.Grade15 = textBox4.Text;
            Settings1.Default.Hours16 = textBox24.Text;  Settings1.Default.Class16 = label32.Text;   Settings1.Default.Grade16 = textBox2.Text;
            Settings1.Default.Hours21 = textBox31.Text;  Settings1.Default.Class21 = label45.Text;   Settings1.Default.Grade21 = textBox30.Text;
            Settings1.Default.Hours22 = textBox32.Text;  Settings1.Default.Class22 = label46.Text;   Settings1.Default.Grade22 = textBox29.Text;
            Settings1.Default.Hours23 = textBox33.Text;  Settings1.Default.Class23 = label44.Text;   Settings1.Default.Grade23 = textBox28.Text;
            Settings1.Default.Hours24 = textBox34.Text;  Settings1.Default.Class24 = label43.Text;   Settings1.Default.Grade24 = textBox27.Text;
            Settings1.Default.Hours25 = textBox35.Text;  Settings1.Default.Class25 = label42.Text;   Settings1.Default.Grade25 = textBox26.Text;
            Settings1.Default.Hours26 = textBox36.Text;  Settings1.Default.Class26 = label41.Text;   Settings1.Default.Grade26 = textBox25.Text;
            Settings1.Default.Hours31 = textBox43.Text;  Settings1.Default.Class31 = label54.Text;   Settings1.Default.Grade31 = textBox42.Text;
            Settings1.Default.Hours32 = textBox44.Text;  Settings1.Default.Class32 = label55.Text;   Settings1.Default.Grade32 = textBox41.Text;
            Settings1.Default.Hours33 = textBox45.Text;  Settings1.Default.Class33 = label53.Text;   Settings1.Default.Grade33 = textBox40.Text;
            Settings1.Default.Hours34 = textBox46.Text;  Settings1.Default.Class34 = label52.Text;   Settings1.Default.Grade34 = textBox39.Text;
            Settings1.Default.Hours35 = textBox47.Text;  Settings1.Default.Class35 = label51.Text;   Settings1.Default.Grade35 = textBox38.Text;
            Settings1.Default.Hours36 = textBox48.Text;  Settings1.Default.Class36 = label50.Text;   Settings1.Default.Grade36 = textBox37.Text;
            Settings1.Default.Hours41 = textBox55.Text;  Settings1.Default.Class41 = label63.Text;   Settings1.Default.Grade41 = textBox54.Text;
            Settings1.Default.Hours42 = textBox56.Text;  Settings1.Default.Class42 = label64.Text;   Settings1.Default.Grade42 = textBox53.Text;
            Settings1.Default.Hours43 = textBox57.Text;  Settings1.Default.Class43 = label62.Text;   Settings1.Default.Grade43 = textBox52.Text;
            Settings1.Default.Hours44 = textBox58.Text;  Settings1.Default.Class44 = label61.Text;   Settings1.Default.Grade44 = textBox51.Text;
            Settings1.Default.Hours45 = textBox59.Text;  Settings1.Default.Class45 = label60.Text;   Settings1.Default.Grade45 = textBox50.Text;
            Settings1.Default.Hours46 = textBox60.Text;  Settings1.Default.Class46 = label59.Text;   Settings1.Default.Grade46 = textBox49.Text;
            Settings1.Default.Hours51 = textBox67.Text;  Settings1.Default.Class51 = label72.Text;   Settings1.Default.Grade51 = textBox66.Text;
            Settings1.Default.Hours52 = textBox68.Text;  Settings1.Default.Class52 = label73.Text;   Settings1.Default.Grade52 = textBox65.Text;
            Settings1.Default.Hours53 = textBox69.Text;  Settings1.Default.Class53 = label71.Text;   Settings1.Default.Grade53 = textBox64.Text;
            Settings1.Default.Hours54 = textBox70.Text;  Settings1.Default.Class54 = label70.Text;   Settings1.Default.Grade54 = textBox63.Text;
            Settings1.Default.Hours55 = textBox71.Text;  Settings1.Default.Class55 = label69.Text;   Settings1.Default.Grade55 = textBox62.Text;
            Settings1.Default.Hours56 = textBox72.Text;  Settings1.Default.Class56 = label68.Text;   Settings1.Default.Grade56 = textBox61.Text;
            Settings1.Default.Hours61 = textBox79.Text;  Settings1.Default.Class61 = label81.Text;   Settings1.Default.Grade61 = textBox78.Text;
            Settings1.Default.Hours62 = textBox80.Text;  Settings1.Default.Class62 = label82.Text;   Settings1.Default.Grade62 = textBox77.Text;
            Settings1.Default.Hours63 = textBox81.Text;  Settings1.Default.Class63 = label80.Text;   Settings1.Default.Grade63 = textBox76.Text;
            Settings1.Default.Hours64 = textBox82.Text;  Settings1.Default.Class64 = label79.Text;   Settings1.Default.Grade64 = textBox75.Text;
            Settings1.Default.Hours65 = textBox83.Text;  Settings1.Default.Class65 = label78.Text;   Settings1.Default.Grade65 = textBox74.Text;
            Settings1.Default.Hours66 = textBox84.Text;  Settings1.Default.Class66 = label77.Text;   Settings1.Default.Grade66 = textBox73.Text;
            Settings1.Default.Hours71 = textBox91.Text;  Settings1.Default.Class71 = label90.Text;   Settings1.Default.Grade71 = textBox90.Text;
            Settings1.Default.Hours72 = textBox92.Text;  Settings1.Default.Class72 = label91.Text;   Settings1.Default.Grade72 = textBox89.Text;
            Settings1.Default.Hours73 = textBox93.Text;  Settings1.Default.Class73 = label89.Text;   Settings1.Default.Grade73 = textBox88.Text;
            Settings1.Default.Hours74 = textBox94.Text;  Settings1.Default.Class74 = label88.Text;   Settings1.Default.Grade74 = textBox87.Text;
            Settings1.Default.Hours75 = textBox95.Text;  Settings1.Default.Class75 = label87.Text;   Settings1.Default.Grade75 = textBox86.Text;
            Settings1.Default.Hours76 = textBox96.Text;  Settings1.Default.Class76 = label86.Text;   Settings1.Default.Grade76 = textBox85.Text;
            Settings1.Default.Hours81 = textBox103.Text; Settings1.Default.Class81 = label99.Text;   Settings1.Default.Grade81 = textBox102.Text;
            Settings1.Default.Hours82 = textBox104.Text; Settings1.Default.Class82 = label100.Text;  Settings1.Default.Grade82 = textBox101.Text;
            Settings1.Default.Hours83 = textBox105.Text; Settings1.Default.Class83 = label98.Text;   Settings1.Default.Grade83 = textBox100.Text;
            Settings1.Default.Hours84 = textBox106.Text; Settings1.Default.Class84 = label97.Text;   Settings1.Default.Grade84 = textBox99.Text;
            Settings1.Default.Hours85 = textBox107.Text; Settings1.Default.Class85 = label96.Text;   Settings1.Default.Grade85 = textBox98.Text;
            Settings1.Default.Hours86 = textBox108.Text; Settings1.Default.Class86 = label95.Text;   Settings1.Default.Grade86 = textBox97.Text;
            Settings1.Default.Hours91 = textBox115.Text; Settings1.Default.Class91 = label108.Text;  Settings1.Default.Grade91 = textBox114.Text;
            Settings1.Default.Hours92 = textBox116.Text; Settings1.Default.Class92 = label109.Text;  Settings1.Default.Grade92 = textBox113.Text;
            Settings1.Default.Hours93 = textBox117.Text; Settings1.Default.Class93 = label107.Text;  Settings1.Default.Grade93 = textBox112.Text;
            Settings1.Default.Hours94 = textBox118.Text; Settings1.Default.Class94 = label106.Text;  Settings1.Default.Grade94 = textBox111.Text;
            Settings1.Default.Hours95 = textBox119.Text; Settings1.Default.Class95 = label105.Text;  Settings1.Default.Grade95 = textBox110.Text;
            Settings1.Default.Hours96 = textBox120.Text; Settings1.Default.Class96 = label104.Text;  Settings1.Default.Grade96 = textBox109.Text;
           
            Settings1.Default.Save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Settings1.Default.Hours1;    textBox3.Text = Settings1.Default.Grade1;      label27.Text = Settings1.Default.Class1;
            textBox15.Text = Settings1.Default.Hours2;   textBox6.Text = Settings1.Default.Grade2;     label24.Text = Settings1.Default.Class2;
            textBox14.Text = Settings1.Default.Hours3;   textBox7.Text = Settings1.Default.Grade3;     label28.Text = Settings1.Default.Class3;
            textBox13.Text = Settings1.Default.Hours4;   textBox8.Text = Settings1.Default.Grade4;     label29.Text = Settings1.Default.Class4;
            textBox12.Text = Settings1.Default.Hours5;   textBox9.Text = Settings1.Default.Grade5;     label30.Text = Settings1.Default.Class5;
            textBox11.Text = Settings1.Default.Hours6;   textBox10.Text = Settings1.Default.Grade6;    label31.Text = Settings1.Default.Class6;
            textBox19.Text = Settings1.Default.Hours11;  textBox18.Text = Settings1.Default.Grade11;   label36.Text = Settings1.Default.Class11;
            textBox20.Text = Settings1.Default.Hours12;  textBox17.Text = Settings1.Default.Grade12;   label37.Text = Settings1.Default.Class12;
            textBox21.Text = Settings1.Default.Hours13;  textBox16.Text = Settings1.Default.Grade13;   label35.Text = Settings1.Default.Class13;
            textBox22.Text = Settings1.Default.Hours14;  textBox5.Text = Settings1.Default.Grade14;    label34.Text = Settings1.Default.Class14;
            textBox23.Text = Settings1.Default.Hours15;  textBox4.Text = Settings1.Default.Grade15;    label33.Text = Settings1.Default.Class15;
            textBox24.Text = Settings1.Default.Hours16;  textBox2.Text = Settings1.Default.Grade16;    label32.Text = Settings1.Default.Class16;
            textBox31.Text = Settings1.Default.Hours21;  textBox30.Text = Settings1.Default.Grade21;   label45.Text = Settings1.Default.Class21;
            textBox32.Text = Settings1.Default.Hours22;  textBox29.Text = Settings1.Default.Grade22;   label46.Text = Settings1.Default.Class22;
            textBox33.Text = Settings1.Default.Hours23;  textBox28.Text = Settings1.Default.Grade23;   label44.Text = Settings1.Default.Class23;
            textBox34.Text = Settings1.Default.Hours24;  textBox27.Text = Settings1.Default.Grade24;   label43.Text = Settings1.Default.Class24;
            textBox35.Text = Settings1.Default.Hours25;  textBox26.Text = Settings1.Default.Grade25;   label42.Text = Settings1.Default.Class25;
            textBox36.Text = Settings1.Default.Hours26;  textBox25.Text = Settings1.Default.Grade26;   label41.Text = Settings1.Default.Class26;
            textBox43.Text = Settings1.Default.Hours31;  textBox42.Text = Settings1.Default.Grade31;   label54.Text = Settings1.Default.Class31;
            textBox44.Text = Settings1.Default.Hours32;  textBox41.Text = Settings1.Default.Grade32;   label55.Text = Settings1.Default.Class32;
            textBox45.Text = Settings1.Default.Hours33;  textBox40.Text = Settings1.Default.Grade33;   label53.Text = Settings1.Default.Class33;
            textBox46.Text = Settings1.Default.Hours34;  textBox39.Text = Settings1.Default.Grade34;   label52.Text = Settings1.Default.Class34;
            textBox47.Text = Settings1.Default.Hours35;  textBox38.Text = Settings1.Default.Grade35;   label51.Text = Settings1.Default.Class35;
            textBox48.Text = Settings1.Default.Hours36;  textBox37.Text = Settings1.Default.Grade36;   label50.Text = Settings1.Default.Class36;
            textBox55.Text = Settings1.Default.Hours41;  textBox54.Text = Settings1.Default.Grade41;   label63.Text = Settings1.Default.Class41;
            textBox56.Text = Settings1.Default.Hours42;  textBox53.Text = Settings1.Default.Grade42;   label64.Text = Settings1.Default.Class42;
            textBox57.Text = Settings1.Default.Hours43;  textBox52.Text = Settings1.Default.Grade43;   label62.Text = Settings1.Default.Class43;
            textBox58.Text = Settings1.Default.Hours44;  textBox51.Text = Settings1.Default.Grade44;   label61.Text = Settings1.Default.Class44;
            textBox59.Text = Settings1.Default.Hours45;  textBox50.Text = Settings1.Default.Grade45;   label60.Text = Settings1.Default.Class45;
            textBox60.Text = Settings1.Default.Hours46;  textBox49.Text = Settings1.Default.Grade46;   label59.Text = Settings1.Default.Class46;
            textBox67.Text = Settings1.Default.Hours51;  textBox66.Text = Settings1.Default.Grade51;   label72.Text = Settings1.Default.Class51;
            textBox68.Text = Settings1.Default.Hours52;  textBox65.Text = Settings1.Default.Grade52;   label73.Text = Settings1.Default.Class52;
            textBox69.Text = Settings1.Default.Hours53;  textBox64.Text = Settings1.Default.Grade53;   label71.Text = Settings1.Default.Class53;
            textBox70.Text = Settings1.Default.Hours54;  textBox63.Text = Settings1.Default.Grade54;   label70.Text = Settings1.Default.Class54;
            textBox71.Text = Settings1.Default.Hours55;  textBox62.Text = Settings1.Default.Grade55;   label69.Text = Settings1.Default.Class55;
            textBox72.Text = Settings1.Default.Hours56;  textBox61.Text = Settings1.Default.Grade56;   label68.Text = Settings1.Default.Class56;
            textBox79.Text = Settings1.Default.Hours61;  textBox78.Text = Settings1.Default.Grade61;   label81.Text = Settings1.Default.Class61;
            textBox80.Text = Settings1.Default.Hours62;  textBox77.Text = Settings1.Default.Grade62;   label82.Text = Settings1.Default.Class62;
            textBox81.Text = Settings1.Default.Hours63;  textBox76.Text = Settings1.Default.Grade63;   label80.Text = Settings1.Default.Class63;
            textBox82.Text = Settings1.Default.Hours64;  textBox75.Text = Settings1.Default.Grade64;   label79.Text = Settings1.Default.Class64;
            textBox83.Text = Settings1.Default.Hours65;  textBox74.Text = Settings1.Default.Grade65;   label78.Text = Settings1.Default.Class65;
            textBox84.Text = Settings1.Default.Hours66;  textBox73.Text = Settings1.Default.Grade66;   label77.Text = Settings1.Default.Class66;
            textBox91.Text = Settings1.Default.Hours71;  textBox90.Text = Settings1.Default.Grade71;   label90.Text = Settings1.Default.Class71;
            textBox92.Text = Settings1.Default.Hours72;  textBox89.Text = Settings1.Default.Grade72;   label91.Text = Settings1.Default.Class72;
            textBox93.Text = Settings1.Default.Hours73;  textBox88.Text = Settings1.Default.Grade73;   label89.Text = Settings1.Default.Class73;
            textBox94.Text = Settings1.Default.Hours74;  textBox87.Text = Settings1.Default.Grade74;   label88.Text = Settings1.Default.Class74;
            textBox95.Text = Settings1.Default.Hours75;  textBox86.Text = Settings1.Default.Grade75;   label87.Text = Settings1.Default.Class75;
            textBox96.Text = Settings1.Default.Hours76;  textBox85.Text = Settings1.Default.Grade76;   label86.Text = Settings1.Default.Class76;
            textBox103.Text = Settings1.Default.Hours81; textBox102.Text = Settings1.Default.Grade81;  label99.Text = Settings1.Default.Class81;
            textBox104.Text = Settings1.Default.Hours82; textBox101.Text = Settings1.Default.Grade82;  label100.Text = Settings1.Default.Class82;
            textBox105.Text = Settings1.Default.Hours83; textBox100.Text = Settings1.Default.Grade83;  label98.Text = Settings1.Default.Class83;
            textBox106.Text = Settings1.Default.Hours84; textBox99.Text = Settings1.Default.Grade84;   label97.Text = Settings1.Default.Class84;
            textBox107.Text = Settings1.Default.Hours85; textBox89.Text = Settings1.Default.Grade85;   label96.Text = Settings1.Default.Class85;
            textBox108.Text = Settings1.Default.Hours86; textBox88.Text = Settings1.Default.Grade86;   label95.Text = Settings1.Default.Class86;
            textBox115.Text = Settings1.Default.Hours91; textBox114.Text = Settings1.Default.Grade91;  label108.Text = Settings1.Default.Class91;
            textBox116.Text = Settings1.Default.Hours92; textBox113.Text = Settings1.Default.Grade92;  label109.Text = Settings1.Default.Class92;
            textBox117.Text = Settings1.Default.Hours93; textBox112.Text = Settings1.Default.Grade93;  label107.Text = Settings1.Default.Class93;
            textBox118.Text = Settings1.Default.Hours94; textBox111.Text = Settings1.Default.Grade94;  label106.Text = Settings1.Default.Class94;
            textBox119.Text = Settings1.Default.Hours95; textBox110.Text = Settings1.Default.Grade95;  label105.Text = Settings1.Default.Class95;
            textBox120.Text = Settings1.Default.Hours96; textBox109.Text = Settings1.Default.Grade96;  label104.Text = Settings1.Default.Class96;

        }
    }
}

