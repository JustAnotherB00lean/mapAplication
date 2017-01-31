using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BHI.MapApp;
using System.IO;

namespace BHI.mapApp.Biz.cs
{
    class Biz
    {
        public static void getSerializer()
        {
            var file = File.ReadAllText(@"http://api.newhomesource.com/api/v2/search/communities?partnerid=1&originLat=30.5013&originLng=-97.8309&radius=25&pagesize=10&bath=2&bed=4&pool=1&page=1");
            var name = JsonConvert.DeserializeObject<Brand2>(file);
        }
    }
}
