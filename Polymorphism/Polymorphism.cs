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
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            fc = new FirstClass(TB_Name.Text, Convert.ToInt32(TB_Cost.Text), Convert.ToInt32(TB_Count.Text));
        }

        private void But_Show_1_Click(object sender, EventArgs e)
        {
            fc.Quality();
            TB_Result.Text = fc.ShowInf();
        }

        private void But_Show_2_Click(object sender, EventArgs e)
        {
            fc = new SecondClass(TB_Name.Text, Convert.ToInt32(TB_Cost.Text), Convert.ToInt32(TB_Count.Text), Convert.ToInt32(TB_CurYear.Text), Convert.ToInt32(TB_ProdYear.Text));
            fc.Quality();
            TB_Result.Text = fc.ShowInf();
        }
    }
}
