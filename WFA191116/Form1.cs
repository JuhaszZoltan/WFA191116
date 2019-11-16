using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//!!!!
//using WFA191116.Properties;

namespace WFA191116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.BackgroundImage = Properties.Resources.kutya;
            button1.BackgroundImage = Image.FromFile("delfin.jpg");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.cica;
        }

    /*
         vagy MouseEnter vagy MouseHover (inkább enter)

        1) kell kép, amire váltasz
        2) fontos, hogy a képet úgy nevezd el, hogy a neve változónév lesz!
        3) be kell másolni a képet a /Properties/Recourses-be
    	-> Project fül 
    	-> legalul [projekt neve] properties 
    	-> felugró ablakban bel oldali menüben recourses (források)
    	(ha ide másolsz valamit, hozzáad a projet szerkezetéhez egy mabbát, amiben a programban használt forráselemek lesznek majd
    	(ikonok, stringek, képek, file-ok stb...)
	
    	fontos elmenteni az "ablakot" bezárás előtt
	
        4) annak a controlnak (most a gomb) a képtulajdonságait úgy kell beállítani, hogy az jó legyen ->
        alapértelmezés, hogy a képet a bal felsőbe illeszti
        (egy a BackgrounkImageLayout property)

        :(
    */
    }
}
