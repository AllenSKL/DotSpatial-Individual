using DotSpatial.Controls;
using DotSpatial.Symbology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wkt.CustomTools
{
    static class GetAllLayers
    {

        public static List<ILayer> Execute(Map mapControl)
        {
            List<ILayer> layers;
            if (mapControl != null)
                layers = mapControl.GetAllLayers();//获取所有图层，添加到list
            else
            {
                layers = mapControl.GetLayers();
            }
            return layers;
        }
    }
}
