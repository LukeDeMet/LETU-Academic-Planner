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
        }

        //allows dragging from treeview.  
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item.ToString(), DragDropEffects.Copy);
        }

        //allows the drag to enter in the listbox
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

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

        //adds items to be dropped in listbox
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))

            {
                listBox2.Items.Add((System.String)e.Data.GetData(typeof(System.String)));
            }
        }

        //allows the drag to enter in the listbox
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //keeps the event going as we drag from one listbox to the other
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
    }
}
