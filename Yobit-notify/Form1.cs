using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yobit_notify
{
    public partial class MainForm : Form
    {
        Yobit yobit;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            yobit = new Yobit();
            yobit.getPairsList();
            if (yobit.valutes.Count > 0)
            {
                List<string> keys = yobit.valutes.Keys.ToList();
                listBoxValutes.DataSource = keys;
            }
        }
    }
}
