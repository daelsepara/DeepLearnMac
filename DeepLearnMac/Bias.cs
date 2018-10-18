using DeepLearnCS;
using Gdk;
using System;
using System.Runtime.InteropServices;

public static class Bias
{
    public static Pixbuf Get(ManagedCNN cnn, int layer)
    {
        if (layer >= 0 && layer < cnn.Layers.Count && cnn.Layers[layer].Type == LayerTypes.Convolution)
        {
            var Transposed = new ManagedArray(cnn.Layers[layer].Bias);
            ManagedMatrix.Transpose(Transposed, cnn.Layers[layer].Bias);

            var pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, Transposed.x, Transposed.y);

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
