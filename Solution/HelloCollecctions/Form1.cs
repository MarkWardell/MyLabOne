using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HelloCollecctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var listLang   = ConfigurationManager.AppSettings.AllKeys;
            var ListValues = new List<String>();
            for (int i = 0; i < listLang.Length; i++)
            {
                var str = ConfigurationManager.AppSettings.Get(i);            
                ListValues.Add(str);
            }


         
            listBox1.DataSource = ListValues;
        }
    }
}
