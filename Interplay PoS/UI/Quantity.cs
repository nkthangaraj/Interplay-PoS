﻿using io.cloudloom.interplay.pos.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Storage;

namespace UI
{
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {

        }

        private void btnQuantityOK_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt16(this.txtQuantity.Text);

            InterplayStorage.Cart.Add(InterplayStorage.SelectedSimpleArticle, quantity);
            this.Close();
        }
    }
}