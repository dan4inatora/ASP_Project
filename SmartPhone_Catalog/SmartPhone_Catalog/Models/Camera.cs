using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class Camera
    {
        [XmlElement("specs")]
        public string Specs;
        [XmlElement("features")]
        public string Features;
        [XmlElement("video_quality")]
        public string VideoQuality;

        public Camera()
        {
        }

        public Camera(string specs, string features, string videoQuality)
        {
            if (!String.IsNullOrEmpty(specs))
            {
                Specs = specs;
            }

            if (!String.IsNullOrEmpty(features))
            {
                Features = features;
            }

            if (!String.IsNullOrEmpty(videoQuality))
            {
                VideoQuality = videoQuality;
            }
        }
    }
}
