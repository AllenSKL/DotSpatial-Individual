using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Topology;

namespace wkt.CustomTools
{
    static class MapFunctionOperating
    {
        public static void ZoomToSpecifiedLayer(Map map,IMapLayer layerToZoom)
        {
            const double eps = 1e-7;
            IEnvelope layerEnvelope = layerToZoom.Extent.ToEnvelope();
            if (layerEnvelope.Width > eps && layerEnvelope.Height > eps)
            {
                layerEnvelope.ExpandBy(layerEnvelope.Width / 10, layerEnvelope.Height / 10); // work item #84
            }
            else
            {
                double zoomInFactor = 0.05; //fixed zoom-in by 10% - 5% on each side
                double newExtentWidth = map.ViewExtents.Width * zoomInFactor;
                double newExtentHeight = map.ViewExtents.Height * zoomInFactor;
                layerEnvelope.ExpandBy(newExtentWidth, newExtentHeight);
            }

            map.ViewExtents = layerEnvelope.ToExtent();

        }
    }
}
