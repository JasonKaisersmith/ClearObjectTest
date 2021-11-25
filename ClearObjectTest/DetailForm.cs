using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearObjectTest
{
    public partial class DetailForm : Form
    {
        public List<MyItem> ItemList { get; }

        private DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(List<MyItem> itemList) : this()
        {
            this.ItemList = itemList;

            this.olvDetail.SetObjects(this.ItemList);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public DialogResult ShowDialog(MyItem selectedItem)
        {
            if (selectedItem == null)
                throw new ArgumentNullException("Cannot be null");

            //Clearing on SelectedObject(s) does not work!  
            this.olvDetail.SelectedObject = null;
            olvDetail.SelectedObjects = null;
            this.olvDetail.SelectedObject = selectedItem;
            this.olvDetail.Focus();

            return this.ShowDialog();
        }
    }
}
