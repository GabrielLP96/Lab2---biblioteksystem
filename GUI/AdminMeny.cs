﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer1;

namespace GUI
{
    public partial class AdminMeny : Form
    {
        BusinessManager businessManager = new BusinessManager();
        public AdminMeny(BusinessManager businessManager)
        {
            this.businessManager = businessManager;
            InitializeComponent();
        }

        private void Btn_HandleAlumni_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Admin_Handle_Alumni admin_Handle_Alumni = new Admin_Handle_Alumni();
            if (admin_Handle_Alumni.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Btn_handleactivities_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            AdminHandleActicites adminHandleActicites = new AdminHandleActicites();
            if (adminHandleActicites.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Btn_programs_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            AdminShowProgram adminShowProgram = new AdminShowProgram();
            if (adminShowProgram.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }
    }
}
