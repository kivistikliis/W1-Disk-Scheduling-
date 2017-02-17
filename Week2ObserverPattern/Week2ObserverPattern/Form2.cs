﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week2ObserverPattern
{
    public partial class Form2 : Form
    {
        Stock s = new Stock();
        Observer o;
        public Form2(Observer o)
        {
            InitializeComponent();
            this.o = o;
            s.Attach(o);
           tbCurrentValue.Text = o.newvalue.ToString();

        }
        public void UpdateForm()
        {
            tbCurrentValue.Text = o.newvalue.ToString();
        }

        private void btAttach_Click(object sender, EventArgs e)
        {
            s.Attach(o);
            lbStatus.Text = "Attached";
        }

        private void btDeatach_Click(object sender, EventArgs e)
        {
            s.Detach(o);
            lbStatus.Text = "Not Attached";
        }
    }
}
