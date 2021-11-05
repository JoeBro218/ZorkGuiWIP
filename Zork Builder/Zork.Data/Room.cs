using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Zork.Data
{
    class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }

        public string Description { get; set; }

        public string Neighbors { get; set; }

        public Room()
        {

        }

        public Room(string name = null)
        {
            Name = name;
        }
    }
}
