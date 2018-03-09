using System;
namespace TowerDefense
{
    public class Invader
    {
        /* known as a property. helps to encapsulate code.
            can be used to follow OOP structure, create get/set methods, etc.
            shown below:

        private MapLocation _location;

        public MapLocation Location
        {
            get {
                return _location;
            }
            set {
                _location = value;
            }
        }*/

        private readonly Path _path;
        private int _pathStep = 0;


        //this one line replaces the above property by using a C# 'auto property' shown below:
        //public MapLocation Location { get; private set; }

        //fatarrow works to return the following statement.
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; private set; } = 2;

        //True if the invader has reached the end of path.
        //public bool HasScored() => _path.endOfPath(_pathStep);
        public bool HasScored { get { return _pathStep >= _path.Length; }}

        public bool isNeutralized => Health <= 0;

        public bool IsActive => !(isNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        //fatarrow can also be used to execute the code;
        public void Move() => _pathStep++;

        public void decreaseHealth(int factor)
        {
            Health -= factor;
        }

    }
}
