﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class FormAnbar : Form
    {
        public FormAnbar()
        {
            InitializeComponent();
        }
        StimulsoftEntities context = new StimulsoftEntities();

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }
    }
}
