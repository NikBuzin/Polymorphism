using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Polymorphism
{
    public partial class Polymorphism : Form
    {
        FirstClass fc;
        public List<FirstClass> _item = new List<FirstClass>();       
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            _item.Add(new FirstClass(TB_Name.Text, Convert.ToInt32(TB_Cost.Text), Convert.ToInt32(TB_Count.Text)));
        }

        private void But_Show_1_Click(object sender, EventArgs e)
        {
            TB_Result.Text = fc.ShowInf(_item);
        }
    }
}
