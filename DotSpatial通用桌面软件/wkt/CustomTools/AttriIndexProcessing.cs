using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Symbology;
using DotSpatial.Controls;

namespace wkt.CustomTools
{
    static class AttriIndexProcessing
    {
        //处理要素删除后Index混乱问题
        public static void CorrectIndexError(IFeatureLayer fLayer, Map _map)
        {
            fLayer.DataSet.UpdateExtent();
            fLayer.DataSet.InitializeVertices();
            if (fLayer.LabelLayer != null)
            {
                fLayer.LabelLayer.CreateLabels();
            }

            fLayer.AssignFastDrawnStates();

            if (_map != null)
            {
                _map.Refresh();
                _map.ResetBuffer();
            }
        }

        public static void CorrectIndexError(IFeatureLayer fLayer)
        {
            fLayer.DataSet.UpdateExtent();
            fLayer.DataSet.InitializeVertices();
            if (fLayer.LabelLayer != null)
            {
                fLayer.LabelLayer.CreateLabels();
            }

            fLayer.AssignFastDrawnStates();
        }
    }
}
