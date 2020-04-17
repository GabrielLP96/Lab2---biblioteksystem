﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AlumniMyActivities : Form
    {
        public AlumniMyActivities()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            AlumniActivities alumnActivities = new AlumniActivities();
            if (alumnActivities.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }
    }
}
