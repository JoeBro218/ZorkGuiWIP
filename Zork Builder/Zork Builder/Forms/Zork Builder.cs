using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork_Builder
{
    public partial class ZorkBuilder : Form
    {
        private bool IsWorldLoaded
        {
            get
            {
                return _viewmodel.IsWorldLoaded;
            }
            set
            {
                _viewmodel.IsWorldLoaded = value;


                foreach (var control in _worldDependentControls)
                {
                    control.Enabled = _viewmodel.IsWorldLoaded;
                }
                foreach (var menuItem in _worldDependentMenuItem)
                {
                    menuItem.Enabled = _viewmodel.IsWorldLoaded;
                }

            }
        }
        private WorldViewModel ViewModel
        {
            get => _viewmodel;
            set
            {
                if (_viewmodel != value)
                {
                    _viewmodel = value;
                    worldViewModelBindingSource.DataSource = _viewmodel;
                }
            }
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();

            _worldDependentControls = new Control[]
            {
                RoomAddButton,
                RoomDeleteButton,
                RoomsListGroupBox,
                RoomInfoGroupBox,
                ExtraInfoGroupBox,
                ItemInfoGroupBox
            };
            _worldDependentMenuItem = new ToolStripMenuItem[]
            {
                closeWorldToolStripMenuItem,
                saveToolStripMenuItem
            };

            IsWorldLoaded = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(OpenFileDialog.FileName);
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                    IsWorldLoaded = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void RoomAddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void RoomDeleteButton_Click(object sender, EventArgs e)
        {
            using (DeleteRoomForm deleteRoomForm = new DeleteRoomForm())
            {
                if (deleteRoomForm.ShowDialog() == DialogResult.OK)
                {

                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private WorldViewModel _viewmodel;
        private Control[] _worldDependentControls;
        private ToolStripMenuItem[] _worldDependentMenuItem;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
