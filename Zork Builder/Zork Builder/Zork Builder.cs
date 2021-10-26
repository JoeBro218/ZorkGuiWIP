using System;
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
    public partial class ZorkBuilder : Form
    {
        public ZorkBuilder()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void RoomAddButton_Click(object sender, EventArgs e)
        {
            using(AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                addPlayerForm.ShowDialog();
            }
        }

        private void RoomDeleteButton_Click(object sender, EventArgs e)
        {
            using(DeletePlayerForm deletePlayerForm = new DeletePlayerForm())
            {
                deletePlayerForm.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
