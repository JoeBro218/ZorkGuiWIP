using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Zork.Common
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Room> Rooms { get; }

        public World(IEnumerable<Room> rooms)
        {
            Rooms = new List<Room>(rooms);
        }
    }
}
