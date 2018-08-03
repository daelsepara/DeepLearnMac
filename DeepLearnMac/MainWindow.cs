using DeepLearnCS;
using Gdk;
using Gtk;
using System;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    int Classification;
    double[] Probability = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

    ManagedCNN cnn;
    Pixbuf Digit;

    bool IsDrawing, IsErasing, IsActivated;

    string BaseDirectory = "./";

    Color White = new Color(255, 255, 255);
    Color Black = new Color(0, 0, 0);

    FileChooserDialog ImageLoader;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        InitializeNetwork();

        InitializeUI();
    }

    protected void RenderPixbuf(Gtk.Image dest, Pixbuf src)
    {
        if (dest != null && src != null)
        {
            Throw(dest.Pixbuf);

            dest.Pixbuf = src.ScaleSimple(src.Width, src.Height, InterpType.Nearest);
        }
    }

    public void RenderScaled(Gtk.Image image, Pixbuf pixbuf)
    {
        var scaled = pixbuf.ScaleSimple(image.WidthRequest, image.HeightRequest, InterpType.Nearest);

        RenderPixbuf(image, scaled);

        Throw(scaled);
    }

    protected void RenderDrawing(Gtk.Image dest, Pixbuf src)
    {
        if (dest != null && src != null)
        {
            src.CopyArea(0, 0, src.Width, src.Height, dest.Pixbuf, 0, 0);
        }
    }

    void PrepareImage(Gtk.Image image)
    {
        image.Pixbuf = new Pixbuf(Colorspace.Rgb, false, 8, image.WidthRequest, image.HeightRequest);
        image.Pixbuf.Fill(0);
    }

    void ClearDigit()
    {
        Digit = new Pixbuf(Colorspace.Rgb, false, 8, DigitBox.WidthRequest, DigitBox.HeightRequest);
        Digit.Fill(0);

        PrepareImage(DigitBox);
    }

    void InitializeNetwork()
    {
        cnn = new ManagedCNN();

        cnn.AddLayer(new ManagedLayer());
        cnn.AddLayer(new ManagedLayer(6, 5));
        cnn.AddLayer(new ManagedLayer(2));
        cnn.AddLayer(new ManagedLayer(12, 5));
        cnn.AddLayer(new ManagedLayer(2));

        // Setup layer 1 - convolution layer
        cnn.LoadFeatureMap(BaseDirectory, "Layer02FeatureMap", 1, 5, 5, 1, 6);
        cnn.LoadFeatureMapBias(BaseDirectory, "Layer02Bias", 1, 6);

        // Setup layer 3 - convolution layer
        cnn.LoadFeatureMap(BaseDirectory, "Layer04FeatureMap", 3, 5, 5, 6, 12);
        cnn.LoadFeatureMapBias(BaseDirectory, "Layer04Bias", 3, 12);

        // Load Network Weights
        cnn.LoadNetworkWeights(BaseDirectory, "NetworkWeights", 192, 10);
        cnn.LoadNetworkBias(BaseDirectory, "NetworkBias", 10);
    }

    void InitializeUI()
    {
        var os = Environment.OSVersion;
        var pid = os.Platform;

        switch(pid)
        {
            case PlatformID.MacOSX:
                this.Title = "DeepLearnUI (OSX, Mono, Beta)";
                break;
            case PlatformID.Unix:
                this.Title = "DeepLearnUI (Unix/Linux/OSX, Mono, Beta)";
                break;
            case PlatformID.Xbox:
                this.Title = "DeepLearnUI (Xbox, Beta)";
                break;
            case PlatformID.WinCE:
                this.Title = "DeepLearnUI (WinCE x86/x64, Beta)";
                break;
            case PlatformID.Win32NT:
                this.Title = "DeepLearnUI (WinNT x86/x64, Beta)";
                break;
            case PlatformID.Win32Windows:
                this.Title = "DeepLearnUI (Win x86/x64, 1.0)";
                break;
            default:
                this.Title = "DeepLearnUI (Unknown OS, Beta)";
                break;
        }

        ImageLoader = new FileChooserDialog(
            "Load image",
            this,
            FileChooserAction.Open,
            "Cancel", ResponseType.Cancel,
            "Open", ResponseType.Accept
        );

        ClearDigit();

        CopyDrawing(Digit);

        CopyClassification();

        ProbabilityZ.IsEditable = false;
        Probability1.IsEditable = false;
        Probability2.IsEditable = false;
        Probability3.IsEditable = false;
        Probability4.IsEditable = false;
        Probability5.IsEditable = false;
        Probability6.IsEditable = false;
        Probability7.IsEditable = false;
        Probability8.IsEditable = false;
        Probability9.IsEditable = false;

        ScoreBox.ModifyFont(Pango.FontDescription.FromString("Verdana 16"));
        ClassificationBox.ModifyFont(Pango.FontDescription.FromString("Verdana 16"));

        for (int i = 0; i < cnn.Layers.Count; i++)
        {
            switch (cnn.Layers[i].Type)
            {
                case LayerTypes.Input:
                    NetworkLayers.AppendText(String.Format("{0} Input", i));
                    break;
                case LayerTypes.Convolution:
                    NetworkLayers.AppendText(String.Format("{0} Convolution", i));
                    break;
                case LayerTypes.Subsampling:
                    NetworkLayers.AppendText(String.Format("{0} Subsampling / Pooling", i));
                    break;
            }
        }

        PrepareImage(ActivationMap);
        PrepareImage(FeatureVector);
        PrepareImage(Output);
        PrepareImage(Weights);
        PrepareImage(NetworkBias);
        PrepareImage(FeatureMap);
        PrepareImage(BiasMap);

        NetworkLayers.Sensitive = false;
        ActivationMapScroll.Sensitive = false;

        HideFeatureMaps();
    }

    void HideFeatureMaps()
    {
        FeatureMapLabel.Hide();
        FeatureMap.Hide();

        FeatureMapI.Hide();
        FeatureMapILabel.Hide();
        FeatureMapIText.Hide();

        FeatureMapJ.Hide();
        FeatureMapJLabel.Hide();
        FeatureMapJText.Hide();

        FeatureMapXText.Hide();
        FeatureMapXLabel.Hide();
        FeatureMapYText.Hide();
        FeatureMapYLabel.Hide();

        BiasMap.Hide();
        BiasLabel.Hide();
    }

    void ShowFeatureMaps()
    {
        FeatureMapLabel.Show();
        FeatureMap.Show();

        FeatureMapI.Show();
        FeatureMapILabel.Show();
        FeatureMapIText.Show();

        FeatureMapJ.Show();
        FeatureMapJLabel.Show();
        FeatureMapJText.Show();

        FeatureMapXText.Show();
        FeatureMapXLabel.Show();
        FeatureMapYText.Show();
        FeatureMapYLabel.Show();

        BiasMap.Show();
        BiasLabel.Show();
    }

    void CopyClassification()
    {
        ProbabilityZ.Text = Probability[0].ToString("g10", ManagedMatrix.ci);
        Probability1.Text = Probability[1].ToString("g10", ManagedMatrix.ci);
        Probability2.Text = Probability[2].ToString("g10", ManagedMatrix.ci);
        Probability3.Text = Probability[3].ToString("g10", ManagedMatrix.ci);
        Probability4.Text = Probability[4].ToString("g10", ManagedMatrix.ci);
        Probability5.Text = Probability[5].ToString("g10", ManagedMatrix.ci);
        Probability6.Text = Probability[6].ToString("g10", ManagedMatrix.ci);
        Probability7.Text = Probability[7].ToString("g10", ManagedMatrix.ci);
        Probability8.Text = Probability[8].ToString("g10", ManagedMatrix.ci);
        Probability9.Text = Probability[9].ToString("g10", ManagedMatrix.ci);

        ScoreBox.Text = String.Format("{0}%", (Probability[Classification] * 100).ToString("00.00", ManagedMatrix.ci));
        ClassificationBox.Text = String.Format("{0}", Classification.ToString("D", ManagedMatrix.ci));
    }

    public void CopyDrawing(Pixbuf bitmap)
    {
        RenderDrawing(DigitBox, bitmap);
    }

    protected void DrawEllipse(Gdk.GC gc, Gdk.Window dest, int X, int Y, int a, int b, bool filled = false)
    {
        dest.DrawArc(gc, filled, X, Y, a, b, 0, 360 * 64);
    }

    protected void DrawEvent(double x, double y)
    {
        var xx = Convert.ToInt32(x);
        var yy = Convert.ToInt32(y);

        var dest = DigitBox.GdkWindow;
        var gc = new Gdk.GC(dest);

        var SelectedColor = IsDrawing ? White : Black;

        gc.RgbFgColor = SelectedColor;
        gc.RgbBgColor = SelectedColor;

        DrawEllipse(gc, dest, xx, yy, 16, 16, true);
    }

    public void DrawActivationMap(int layer, int map)
    {
        if (IsActivated)
        {
            var pixbuf = Activation.Get(cnn, layer, map);

            RenderScaled(ActivationMap, pixbuf);

            Throw(pixbuf);

            ActivationX.Text = cnn.Layers[layer].Activation.x.ToString("D", ManagedMatrix.ci);
            ActivationY.Text = cnn.Layers[layer].Activation.y.ToString("D", ManagedMatrix.ci);

            if (cnn.Layers[layer].Type == LayerTypes.Convolution)
            {
                var bias = Bias.Get(cnn, layer);

                RenderScaled(BiasMap, bias);

                Throw(bias);
            }
        }
    }

    public void DrawFeatureMap(int layer, int i, int j)
    {
        if (IsActivated)
        {
            var pixbuf = Feature.Get(cnn, layer, i, j);

            FeatureMapIText.Text = i.ToString("D", ManagedMatrix.ci);
            FeatureMapJText.Text = j.ToString("D", ManagedMatrix.ci);

            if (pixbuf != null)
            {
                FeatureMapXText.Text = pixbuf.Width.ToString("D", ManagedMatrix.ci);
                FeatureMapYText.Text = pixbuf.Height.ToString("D", ManagedMatrix.ci);
            }

            RenderScaled(FeatureMap, pixbuf);

            Throw(pixbuf);
        }
    }

    private void FeatureMapEvent(int layer)
    {
        if (layer >= 0 && layer < cnn.Layers.Count && cnn.Layers[layer].Type == LayerTypes.Convolution)
        {
            ShowFeatureMaps();

            FeatureMapI.Sensitive = true;
            FeatureMapJ.Sensitive = true;

            var i = Convert.ToInt32(FeatureMapI.Value);
            var j = Convert.ToInt32(FeatureMapJ.Value);

            DrawFeatureMap(layer, i, j);
        }
        else
        {
            FeatureMapI.Sensitive = false;
            FeatureMapJ.Sensitive = false;

            HideFeatureMaps();
        }
    }

    private void DrawFullyConnectedLayers()
    {
        var featurevector = FullyConnected.Get(cnn.FeatureVector);
        var output = FullyConnected.Get(cnn.Output);
        var weights = FullyConnected.Get(cnn.Weights, false);
        var bias = FullyConnected.Get(cnn.Bias, false);

        if (IsActivated)
        {
            RenderScaled(FeatureVector, featurevector);
            RenderScaled(Output, output);
            RenderScaled(Weights, weights);
            RenderScaled(NetworkBias, bias);
        }

        Throw(featurevector, output, weights, bias);
    }

    protected void OnDigitEventBoxButtonPressEvent(object o, ButtonPressEventArgs args)
    {
        if (args.Event.Button == 1)
        {
            IsDrawing = true;
            IsErasing = false;

            DrawEvent(args.Event.X, args.Event.Y);
        }
        else if (args.Event.Button == 3)
        {
            IsErasing = true;
            IsDrawing = false;

            DrawEvent(args.Event.X, args.Event.Y);
        }
    }

    protected void OnDigitEventBoxButtonReleaseEvent(object o, ButtonReleaseEventArgs args)
    {
        IsDrawing = false;
        IsErasing = false;

        Digit.GetFromDrawable(DigitBox.GdkWindow, Rgb.Colormap, 0, 0, 0, 0, Digit.Width, Digit.Height);

        RenderDrawing(DigitBox, Digit);
    }

    protected void OnDigitEventBoxMotionNotifyEvent(object o, MotionNotifyEventArgs args)
    {
        if (IsDrawing || IsErasing)
        {
            DrawEvent(args.Event.X, args.Event.Y);
        }
    }

    protected void OnButtonClassifyClicked(object sender, EventArgs e)
    {
        // Classify image
        Digit.GetFromDrawable(DigitBox.GdkWindow, Rgb.Colormap, 0, 0, 0, 0, Digit.Width, Digit.Height);
        Classify.Pixbuf(Digit, cnn, ref Classification, ref Probability);

        CopyClassification();

        if (IsActivated)
        {
            var layer = NetworkLayers.Active;
            var map = Convert.ToInt32(ActivationMapScroll.Value);

            if (layer >= 0 && layer < cnn.Layers.Count && map >= 0 && map < cnn.Layers[layer].Activation.i)
            {
                DrawActivationMap(layer, map);

                FeatureMapEvent(layer);
            }
        }

        IsActivated = true;

        NetworkLayers.Sensitive = true;

        DrawFullyConnectedLayers();
    }

    protected void OnClearButtonClicked(object sender, EventArgs e)
    {
        if (Digit != null)
            Throw(Digit);

        ClearDigit();

        CopyDrawing(Digit);
    }

    protected void OnLoadButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ImageLoader.Filename))
        {
            var directory = System.IO.Path.GetDirectoryName(ImageLoader.Filename);

            if (Directory.Exists(directory))
            {
                ImageLoader.SetCurrentFolder(directory);
            }
        }

        if (ImageLoader.Run() == Convert.ToInt32(ResponseType.Accept))
        {
            if (!string.IsNullOrEmpty(ImageLoader.Filename))
            {
                var FileName = ImageLoader.Filename;

                try
                {
                    if (Digit != null)
                    {
                        var temp = new Pixbuf(FileName);

                        if (temp != null)
                        {
                            ClearDigit();

                            Digit = temp.ScaleSimple(DigitBox.WidthRequest, DigitBox.HeightRequest, InterpType.Hyper);
                        }

                        Throw(temp);

                        RenderPixbuf(DigitBox, Digit);
                    }
                }
                catch (Exception ex)
                {
                    Throw(Digit, DigitBox.Pixbuf);

                    Console.WriteLine("Error: {0}", ex.Message);

                    ClearDigit();
                }
            }
        }

        ImageLoader.Hide();
    }

    protected void OnActivationMapScrollValueChanged(object sender, EventArgs e)
    {
        var layer = NetworkLayers.Active;
        var map = Convert.ToInt32(ActivationMapScroll.Value);

        ActivationMapsTextBox.Text = map.ToString("D", ManagedMatrix.ci);

        DrawActivationMap(layer, map);
    }

    protected void OnNetworkLayersChanged(object sender, EventArgs e)
    {
        if (IsActivated)
        {
            var layer = NetworkLayers.Active;

            ActivationMapScroll.Sensitive = true;
            ActivationMapScroll.Value = 0;
            ActivationMapScroll.Adjustment.Lower = 0;
            ActivationMapScroll.Adjustment.Upper = cnn.Layers[layer].Activation.i;

            var map = Convert.ToInt32(ActivationMapScroll.Value);

            ActivationMapsTextBox.Text = map.ToString("D", ManagedMatrix.ci);

            DrawActivationMap(layer, map);

            if (layer >= 0 && layer < cnn.Layers.Count && cnn.Layers[layer].Type == LayerTypes.Convolution)
            {
                FeatureMapI.Value = 0;
                FeatureMapI.Adjustment.Lower = 0;
                FeatureMapI.Adjustment.Upper = cnn.Layers[layer].FeatureMap.i;

                FeatureMapJ.Value = 0;
                FeatureMapJ.Adjustment.Lower = 0;
                FeatureMapJ.Adjustment.Upper = cnn.Layers[layer].FeatureMap.j;
            }

            FeatureMapEvent(layer);
        }
    }

    protected void OnFeatureMapJValueChanged(object sender, EventArgs e)
    {
        if (IsActivated)
        {
            FeatureMapEvent(NetworkLayers.Active);
        }
    }

    protected void OnFeatureMapIValueChanged(object sender, EventArgs e)
    {
        if (IsActivated)
        {
            FeatureMapEvent(NetworkLayers.Active);
        }
    }

    protected void CleanUpUI()
    {
        // Dispose Pixbufs
        Throw(Digit, DigitBox.Pixbuf, ActivationMap.Pixbuf, FeatureMap.Pixbuf, BiasMap.Pixbuf);
        Throw(FeatureVector.Pixbuf, Weights.Pixbuf, Output.Pixbuf, NetworkBias.Pixbuf);

        // Dispose Dialogs
        Throw(ImageLoader);
    }

    protected void CleanUpNetwork()
    {
        cnn.Free();
    }

    protected void CleanShutdown()
    {
        CleanUpUI();

        CleanUpNetwork();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        CleanShutdown();

        Application.Quit();

        a.RetVal = true;
    }

    protected void Throw(params IDisposable[] trash)
    {
        foreach (var item in trash)
        {
            if (item != null)
                item.Dispose();
        }
    }
}
