using System;
using System.ComponentModel;
using Zork.Data;

namespace Zork_Builder
{
    internal class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsWorldLoaded { get; set; }
      
        public BindingList<Room> Rooms { get; set; }



        public World World
        {
            set
            {
                if (_world != value)
                {
                    _world = value;
                    if (_world != null)
                    {
                        Rooms = new BindingList<Room>(_world.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public WorldViewModel(World world = null) => World = world;

        private World _world;
    }
}
