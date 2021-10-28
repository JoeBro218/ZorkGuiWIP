﻿using System;
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

        //---THIS IS THE CODE FROM THE ORIGONAL WORLD CLASS---//
        //public HashSet<Room> Rooms { get; set; }

        //[JsonIgnore]
        //public Dictionary<string, Room> RoomsByName => mRoomsByName;

        //public Player SpawnPlayer() => new Player(this, StartingLocation);

        //[OnDeserialized]
        //private void OnDeserialized(StreamingContext context)
        //{
        //    mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

        //    foreach (Room room in Rooms)
        //    {
        //        room.UpdateNeighbors(this);
        //    }
        //}

        //[JsonProperty]
        //private string StartingLocation { get; set; }

        //private Dictionary<string, Room> mRoomsByName;
    }
}
