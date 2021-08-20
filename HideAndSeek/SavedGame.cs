﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HideAndSeek
{
    class SavedGame
    {
        public string PlayerLocation { get; set; }
        public Dictionary<string, string> OpponentLocations { get; set; }
        public List<string> FoundOpponents { get; set; }
        public int MoveNumber { get; set; }
    }
}