using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egenskaber.Person p = new Egenskaber.Person();
            //p.Alder = 10;
            p.Navn = "Mikkel";
            propertyGrid1.SelectedObject = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Egenskaber.Person p = propertyGrid1.SelectedObject as Egenskaber.Person;

        }
    }
}
