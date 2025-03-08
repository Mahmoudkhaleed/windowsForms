using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControl
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId.Text) && string.IsNullOrEmpty(TxtName.Text))
                return;
            ListViewItem item = new ListViewItem(TxtId.Text.Trim());
            if (radioButton1.Checked)
            {
                item.ImageIndex = 0;
            }
            else
                item.ImageIndex = 1;
            item.SubItems.Add(TxtName.Text);
            listView1.Items.Add(item);
            TxtId.Clear();
            TxtName.Clear();
            radioButton1.Checked = true;
            TxtId.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
