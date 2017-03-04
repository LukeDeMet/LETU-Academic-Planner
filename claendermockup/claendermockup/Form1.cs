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
            DoDragDrop(e.Item.ToString(), DragDropEffects.Copy);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Start of ListBox1
        //******************************************************************************************************************
        //adds items to be dropped in listbox
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                if (listBox1.Items.Contains((System.String)e.Data.GetData(typeof(System.String))))
                    return;
                else
                    listBox1.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        //allows items to be moved and then removed out of listbox
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox1.Items.Count == 0)
            {
                return;
            }
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox1.Items[index].ToString() == null)
                        s = listBox1.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                listBox1.Items.RemoveAt(listBox1.IndexFromPoint(e.X, e.Y));
            }
        }
        //*******************************************************************************************************************
        //end of ListBox1

        //ListBox2
        //*******************************************************************************************************************
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox2.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox2.Items.Count == 0)
            {
                return;
            }
            int index = listBox2.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox2.Items[index].ToString() == null)
                        s = listBox2.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde2 = DoDragDrop(s, DragDropEffects.All);

            if (dde2 == DragDropEffects.All)
            {
                listBox2.Items.RemoveAt(listBox2.IndexFromPoint(e.X, e.Y));
            }
        }

        //*******************************************************************************************************************
        //end of listBox2

        //Start of ListBox3
        //*******************************************************************************************************************
        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox3.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox3.Items.Count == 0)
            {
                return;
            }
            int index = listBox3.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox3.Items[index].ToString() == null)
                        s = listBox3.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde3 = DoDragDrop(s, DragDropEffects.All);

            if (dde3 == DragDropEffects.All)
            {
                listBox3.Items.RemoveAt(listBox3.IndexFromPoint(e.X, e.Y));
            }
        }
        //End of ListBox3
        //*******************************************************************************************************************

        //Start of ListBox4
        //*******************************************************************************************************************
        private void listBox4_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox4.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox4.Items.Count == 0)
            {
                return;
            }
            int index = listBox4.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox4.Items[index].ToString() == null)
                        s = listBox4.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde4 = DoDragDrop(s, DragDropEffects.All);

            if (dde4 == DragDropEffects.All)
            {
                listBox4.Items.RemoveAt(listBox4.IndexFromPoint(e.X, e.Y));
            }
        }

        //End of ListBox4
        //*******************************************************************************************************************

        //start of ListBox5
        //*******************************************************************************************************************
        private void listBox5_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox5.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox5_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox5.Items.Count == 0)
            {
                return;
            }
            int index = listBox5.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox5.Items[index].ToString() == null)
                        s = listBox5.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde5 = DoDragDrop(s, DragDropEffects.All);

            if (dde5 == DragDropEffects.All)
            {
                listBox5.Items.RemoveAt(listBox5.IndexFromPoint(e.X, e.Y));
            }
        }
        //end of ListBox5
        //*******************************************************************************************************************

        //start of ListBox6
        //*******************************************************************************************************************
        private void listBox6_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox6.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox6_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox6.Items.Count == 0)
            {
                return;
            }
            int index = listBox6.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox6.Items[index].ToString() == null)
                        s = listBox6.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde6 = DoDragDrop(s, DragDropEffects.All);

            if (dde6 == DragDropEffects.All)
            {
                listBox6.Items.RemoveAt(listBox6.IndexFromPoint(e.X, e.Y));
            }
        }
        //end of ListBox6
        //*******************************************************************************************************************

        //start of ListBox7
        //*******************************************************************************************************************
        private void listBox7_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox7.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox7_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox7.Items.Count == 0)
            {
                return;
            }
            int index = listBox7.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox7.Items[index].ToString() == null)
                        s = listBox7.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde7 = DoDragDrop(s, DragDropEffects.All);

            if (dde7 == DragDropEffects.All)
            {
                listBox7.Items.RemoveAt(listBox7.IndexFromPoint(e.X, e.Y));
            }
        }
        //end of ListBox7
        //*******************************************************************************************************************

        //start of ListBox8
        //*******************************************************************************************************************
        private void listBox8_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                listBox8.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        private void listBox8_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            if (listBox8.Items.Count == 0)
            {
                return;
            }
            int index = listBox8.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                {
                    if (listBox8.Items[index].ToString() == null)
                        s = listBox8.Items[index].ToString();
                }
            }
            else
                return;

            DragDropEffects dde8 = DoDragDrop(s, DragDropEffects.All);

            if (dde8 == DragDropEffects.All)
            {
                listBox8.Items.RemoveAt(listBox8.IndexFromPoint(e.X, e.Y));
            }
        }

        //end of ListBox8
        //*******************************************************************************************************************

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
                listBox9.Items.Clear();
                listBox9.Items.Add(str);

            }
        }
        //end of ListBox9
        //*******************************************************************************************************************
    }
}
