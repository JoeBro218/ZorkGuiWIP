﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork_Builder
{
    public partial class DeleteRoomForm : Form
    {
        public DeleteRoomForm()
        {
            InitializeComponent();
        }

        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
