using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.FIFA
{
    internal class Ball
    {
        public int Id { get; set; }

		private location location;
        //public List<Player> Players { get; set; } = new List<Player>();
        //public List<Refree> refrees { get; set; } = new List<Refree>();
		public location Location
		{
            
			get { return location; }
            
			set 
            {
                //foreach (var player in Players)
                //{
                //    player.Run(this);
                //}
                //foreach (var item in refrees)
                //{
                //    item.look(this);
                //}

                if (!location.Equals(value))
                {
                    location = value;
                if (BallLocationChanges != null) BallLocationChanges.Invoke(this);
                }

            }
		}
        public event Action<Ball> BallLocationChanges;  // default value of delegate equals null 
        public override string ToString()
        {
            return $"id: {Id} , Location: {location}";
        }

    }
}
