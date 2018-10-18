using DeepLearnCS;
using Gdk;
using System;

public static class FullyConnected
{
    public static Pixbuf Get(ManagedArray layer, bool transpose = true)
    {
        if (transpose)
        {
            var Transposed = new ManagedArray(layer, false);
            ManagedMatrix.Transpose(Transposed, layer);

            var pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, Transposed.x, Transposed.y);

            double min = Double.MaxValue;
            double max = Double.MinValue;

            GetNormalization(Transposed, ref min, ref max);

            Activation.Draw(pixbuf, Transposed, min, max);

            ManagedOps.Free(Transposed);

            return pixbuf;
        }
        else
        {
            var pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, layer.x, layer.y);

            double min = Double.MaxValue;
            double max = Double.MinValue;

            GetNormalization(layer, ref min, ref max);

            Activation.Draw(pixbuf, layer, min, max);

            return pixbuf;
        }
    }

    public static void GetNormalization(ManagedArray array, ref double min, ref double max)
    {
        for (int y = 0; y < array.y; y++)
        {
            for (int x = 0; x < array.x; x++)
            {
                if (array[x, y] > max)
                    max = array[x, y];

                if (array[x, y] < min)
                    min = array[x, y];
            }
        }
    }
}
