using System;
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
    public partial class MainForm : Form
    {
        public DetailForm DetailForm { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MyItem> items = new List<MyItem> { 
                new MyItem { Id = 1, Name = "Item 1" },
                new MyItem { Id = 2, Name = "Item 2" },
                new MyItem { Id = 3, Name = "Item 3" },
                new MyItem { Id = 4, Name = "Item 4" },
                new MyItem { Id = 5, Name = "Item 5" },
                new MyItem { Id = 6, Name = "Item 6" }
            };

            this.DetailForm = new DetailForm(items);
            this.olvMain.SetObjects(items);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DetailForm.ShowDialog(this.olvMain.SelectedObject as MyItem);

        }
    }
}
