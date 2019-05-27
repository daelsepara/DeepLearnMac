using DeepLearnCS;
using Gdk;
using System;
using System.Runtime.InteropServices;

public static class Activation
{
    public static Pixbuf Get(ManagedCNN cnn, int layer, int map)
    {
        if (layer >= 0 && layer < cnn.Layers.Count && map >= 0 && map < cnn.Layers[layer].Activation.i)
        {
            var Activation = new ManagedArray(cnn.Layers[layer].Activation.x, cnn.Layers[layer].Activation.y, cnn.Layers[layer].Activation.z);
            var Transposed = new ManagedArray(Activation);
            var pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, Activation.y, Activation.x);

            ManagedOps.Copy4D2D(Activation, cnn.Layers[layer].Activation, 0, map);
            ManagedMatrix.Transpose(Transposed, Activation);

            // Get normalization values
            double min = Double.MaxValue;
            double max = double.MinValue;

            for (int y = 0; y < Transposed.y; y++)
            {
                for (int x = 0; x < Transposed.x; x++)
                {
                    if (Transposed[x, y] > max)
                        max = Transposed[x, y];

                    if (Transposed[x, y] < min)
                        min = Transposed[x, y];
                }
            }

            Draw(pixbuf, Transposed, min, max);

            ManagedOps.Free(Activation, Transposed);

            return pixbuf;
        }

        // return empty pixbuf
        return new Pixbuf(Colorspace.Rgb, false, 8, 1, 1);
    }

    public static void Draw(Pixbuf pixbuf, ManagedArray Activation, double min, double max)
    {
        for (int y = 0; y < Activation.y; y++)
        {
            for (int x = 0; x < Activation.x; x++)
            {
                var offset = pixbuf.Pixels + y * pixbuf.Rowstride + x * pixbuf.NChannels;

                var DoubleVal = 255 * (Activation[x, y] - min) / (max - min);
                var ByteVal = Convert.ToByte(DoubleVal);

                Marshal.WriteByte(offset, ByteVal);

                if (pixbuf.NChannels > 1)
                    Marshal.WriteByte(offset + 1, ByteVal);

                if (pixbuf.NChannels > 2)
                    Marshal.WriteByte(offset + 2, ByteVal);
            }
        }
    }
}
