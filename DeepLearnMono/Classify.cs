using DeepLearnCS;
using Gdk;
using System.Runtime.InteropServices;

public static class Classify
{
    public static void Pixbuf(Pixbuf Digit, ManagedCNN cnn, ref int digit, ref double[] Probability)
    {
        // Bitmap Data is transposed                
        var Transposed = new ManagedArray(28, 28, 1);
        var TestDigit = new ManagedArray(28, 28, 1);

        var ScaledDigit = Digit.ScaleSimple(28, 28, InterpType.Hyper);

        Convert(ScaledDigit, TestDigit);
        ManagedMatrix.Transpose(Transposed, TestDigit);
        cnn.FeedForward(Transposed);

        digit = 0;
        double max = double.MinValue;

        for (int y = 0; y < cnn.Output.y; y++)
        {
            var val = cnn.Output[0, y];

            Probability[y] = val;

            if (val > max)
            {
                max = val;
                digit = y;
            }
        }

        ScaledDigit.Dispose();

        ManagedOps.Free(TestDigit, Transposed);
    }

    public static void Convert(Pixbuf pixbuf, ManagedArray digit)
    {
        if (pixbuf.Width == digit.x && pixbuf.Height == digit.y)
        {
            for (int y = 0; y < digit.y; y++)
            {
                for (int x = 0; x < digit.x; x++)
                {
                    var offset = pixbuf.Pixels + y * pixbuf.Rowstride + x * pixbuf.NChannels;

                    var r = (double)Marshal.ReadByte(offset, 0);
                    var g = r;
                    var b = r;

                    if (pixbuf.NChannels > 1)
                    {
                        g = Marshal.ReadByte(offset, 1);
                    }

                    if (pixbuf.NChannels > 2)
                    {
                        b = Marshal.ReadByte(offset, 2);
                    }

                    digit[x, y] = (r * 299 + g * 587 + b * 114) / (255000);
                }
            }
        }
    }
}
