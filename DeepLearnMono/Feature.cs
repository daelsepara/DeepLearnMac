using DeepLearnCS;
using Gdk;
using System;
using System.Runtime.InteropServices;

public static class Feature
{
    public static Pixbuf Get(ManagedCNN cnn, int layer, int i, int j)
    {
        if (layer >= 0 && layer < cnn.Layers.Count && cnn.Layers[layer].Type == LayerTypes.Convolution && i >= 0 && i < cnn.Layers[layer].FeatureMap.i && j >= 0 && j < cnn.Layers[layer].FeatureMap.j)
        {
            var FeatureMap = new ManagedArray(cnn.Layers[layer].FeatureMap.x, cnn.Layers[layer].FeatureMap.y, cnn.Layers[layer].FeatureMap.z);
            var Transposed = new ManagedArray(FeatureMap);
            var pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, FeatureMap.y, FeatureMap.x);

            ManagedOps.Copy4DIJ2D(FeatureMap, cnn.Layers[layer].FeatureMap, i, j);
            ManagedMatrix.Transpose(Transposed, FeatureMap);

            // Get normalization values
            double min = Double.MaxValue;
            double max = Double.MinValue;

            FullyConnected.GetNormalization(Transposed, ref min, ref max);

            Activation.Draw(pixbuf, Transposed, min, max);

            ManagedOps.Free(Transposed);

            return pixbuf;
        }

        // return empty pixbuf
        return new Pixbuf(Colorspace.Rgb, false, 8, 1, 1);
    }
}
