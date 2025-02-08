using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Channel
    {
        public string Title { get; set; }
        public List<video> Videos { get; set; } = new List<video>();
        public void AddVideo(video video)
        {
            Videos.Add(video);// then notify all subscribers
            if (UploadVideo != null) 
            {
                UploadVideo.Invoke(this, video);
            }
        }
        public event Action<Channel,video> UploadVideo;
    }
}

