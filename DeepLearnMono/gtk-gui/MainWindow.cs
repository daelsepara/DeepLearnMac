
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed MainLayout;

	private global::Gtk.Notebook MainNotebook;

	private global::Gtk.Fixed LayoutClassify;

	private global::Gtk.EventBox DigitEventBox;

	private global::Gtk.Image DigitBox;

	private global::Gtk.Button ButtonClassify;

	private global::Gtk.Button LoadButton;

	private global::Gtk.Button ClearButton;

	private global::Gtk.Label ClassificationScoresLabel;

	private global::Gtk.Entry Probability1;

	private global::Gtk.Entry ProbabilityZ;

	private global::Gtk.Entry Probability2;

	private global::Gtk.Entry Probability3;

	private global::Gtk.Entry Probability4;

	private global::Gtk.Entry Probability5;

	private global::Gtk.Entry Probability6;

	private global::Gtk.Entry Probability7;

	private global::Gtk.Entry Probability8;

	private global::Gtk.Entry Probability9;

	private global::Gtk.Label LabelZ;

	private global::Gtk.Label Label1;

	private global::Gtk.Label Label2;

	private global::Gtk.Label Label3;

	private global::Gtk.Label Label4;

	private global::Gtk.Label Label5;

	private global::Gtk.Label Label6;

	private global::Gtk.Label Label7;

	private global::Gtk.Label Label8;

	private global::Gtk.Label Label9;

	private global::Gtk.Entry ScoreBox;

	private global::Gtk.Label ScoreBoxLabel;

	private global::Gtk.Label ClassificationLabel;

	private global::Gtk.Entry ClassificationBox;

	private global::Gtk.Label PageClassify;

	private global::Gtk.Fixed LayoutNetwork;

	private global::Gtk.Label NetworksLayersLabel;

	private global::Gtk.ComboBox NetworkLayers;

	private global::Gtk.Image ActivationMap;

	private global::Gtk.Label ActivationMapLabel;

	private global::Gtk.Entry ActivationMapsTextBox;

	private global::Gtk.HScrollbar ActivationMapScroll;

	private global::Gtk.Label ActivationXLabel;

	private global::Gtk.Entry ActivationX;

	private global::Gtk.Label ActivationYLabel;

	private global::Gtk.Entry ActivationY;

	private global::Gtk.Label FeatureVectorLabel;

	private global::Gtk.Image FeatureVector;

	private global::Gtk.Image Weights;

	private global::Gtk.Label WeightsLabel;

	private global::Gtk.Label OutputLabel;

	private global::Gtk.Image Output;

	private global::Gtk.Label NetworkBiasLabel;

	private global::Gtk.Image NetworkBias;

	private global::Gtk.Image FeatureMap;

	private global::Gtk.Label FeatureMapLabel;

	private global::Gtk.VScrollbar FeatureMapJ;

	private global::Gtk.HScrollbar FeatureMapI;

	private global::Gtk.Entry FeatureMapIText;

	private global::Gtk.Label FeatureMapILabel;

	private global::Gtk.Entry FeatureMapXText;

	private global::Gtk.Label FeatureMapXLabel;

	private global::Gtk.Entry FeatureMapJText;

	private global::Gtk.Entry FeatureMapYText;

	private global::Gtk.Label FeatureMapJLabel;

	private global::Gtk.Label FeatureMapYLabel;

	private global::Gtk.Image BiasMap;

	private global::Gtk.Label BiasLabel;

	private global::Gtk.Label PageNetwork;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 800;
		this.HeightRequest = 600;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("DeepLearnMAC (BETA)");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("DeepLearnMono.DeepLearn.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.MainLayout = new global::Gtk.Fixed();
		this.MainLayout.WidthRequest = 800;
		this.MainLayout.HeightRequest = 600;
		this.MainLayout.Name = "MainLayout";
		this.MainLayout.HasWindow = false;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.MainNotebook = new global::Gtk.Notebook();
		this.MainNotebook.WidthRequest = 640;
		this.MainNotebook.HeightRequest = 480;
		this.MainNotebook.CanFocus = true;
		this.MainNotebook.Name = "MainNotebook";
		this.MainNotebook.CurrentPage = 0;
		// Container child MainNotebook.Gtk.Notebook+NotebookChild
		this.LayoutClassify = new global::Gtk.Fixed();
		this.LayoutClassify.Name = "LayoutClassify";
		this.LayoutClassify.HasWindow = false;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.DigitEventBox = new global::Gtk.EventBox();
		this.DigitEventBox.WidthRequest = 256;
		this.DigitEventBox.HeightRequest = 256;
		this.DigitEventBox.Name = "DigitEventBox";
		this.DigitEventBox.BorderWidth = ((uint)(1));
		// Container child DigitEventBox.Gtk.Container+ContainerChild
		this.DigitBox = new global::Gtk.Image();
		this.DigitBox.WidthRequest = 256;
		this.DigitBox.HeightRequest = 256;
		this.DigitBox.Name = "DigitBox";
		this.DigitEventBox.Add(this.DigitBox);
		this.LayoutClassify.Add(this.DigitEventBox);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.DigitEventBox]));
		w2.X = 30;
		w2.Y = 30;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ButtonClassify = new global::Gtk.Button();
		this.ButtonClassify.WidthRequest = 160;
		this.ButtonClassify.CanFocus = true;
		this.ButtonClassify.Name = "ButtonClassify";
		this.ButtonClassify.UseUnderline = true;
		this.ButtonClassify.Label = global::Mono.Unix.Catalog.GetString("Classify");
		this.LayoutClassify.Add(this.ButtonClassify);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ButtonClassify]));
		w3.X = 330;
		w3.Y = 335;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.LoadButton = new global::Gtk.Button();
		this.LoadButton.WidthRequest = 100;
		this.LoadButton.CanFocus = true;
		this.LoadButton.Name = "LoadButton";
		this.LoadButton.UseUnderline = true;
		this.LoadButton.Label = global::Mono.Unix.Catalog.GetString("Load");
		this.LayoutClassify.Add(this.LoadButton);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.LoadButton]));
		w4.X = 166;
		w4.Y = 300;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ClearButton = new global::Gtk.Button();
		this.ClearButton.WidthRequest = 100;
		this.ClearButton.CanFocus = true;
		this.ClearButton.Name = "ClearButton";
		this.ClearButton.UseUnderline = true;
		this.ClearButton.Label = global::Mono.Unix.Catalog.GetString("Clear");
		this.LayoutClassify.Add(this.ClearButton);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ClearButton]));
		w5.X = 50;
		w5.Y = 300;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ClassificationScoresLabel = new global::Gtk.Label();
		this.ClassificationScoresLabel.Name = "ClassificationScoresLabel";
		this.ClassificationScoresLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Classification Scores</b>");
		this.ClassificationScoresLabel.UseMarkup = true;
		this.LayoutClassify.Add(this.ClassificationScoresLabel);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ClassificationScoresLabel]));
		w6.X = 332;
		w6.Y = 10;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability1 = new global::Gtk.Entry();
		this.Probability1.CanFocus = true;
		this.Probability1.Name = "Probability1";
		this.Probability1.IsEditable = false;
		this.Probability1.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability1]));
		w7.X = 330;
		w7.Y = 60;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ProbabilityZ = new global::Gtk.Entry();
		this.ProbabilityZ.CanFocus = true;
		this.ProbabilityZ.Name = "ProbabilityZ";
		this.ProbabilityZ.IsEditable = false;
		this.ProbabilityZ.InvisibleChar = '●';
		this.LayoutClassify.Add(this.ProbabilityZ);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ProbabilityZ]));
		w8.X = 330;
		w8.Y = 30;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability2 = new global::Gtk.Entry();
		this.Probability2.CanFocus = true;
		this.Probability2.Name = "Probability2";
		this.Probability2.IsEditable = false;
		this.Probability2.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability2]));
		w9.X = 330;
		w9.Y = 90;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability3 = new global::Gtk.Entry();
		this.Probability3.CanFocus = true;
		this.Probability3.Name = "Probability3";
		this.Probability3.IsEditable = false;
		this.Probability3.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability3);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability3]));
		w10.X = 330;
		w10.Y = 120;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability4 = new global::Gtk.Entry();
		this.Probability4.CanFocus = true;
		this.Probability4.Name = "Probability4";
		this.Probability4.IsEditable = false;
		this.Probability4.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability4);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability4]));
		w11.X = 330;
		w11.Y = 150;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability5 = new global::Gtk.Entry();
		this.Probability5.CanFocus = true;
		this.Probability5.Name = "Probability5";
		this.Probability5.IsEditable = false;
		this.Probability5.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability5);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability5]));
		w12.X = 330;
		w12.Y = 180;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability6 = new global::Gtk.Entry();
		this.Probability6.CanFocus = true;
		this.Probability6.Name = "Probability6";
		this.Probability6.IsEditable = false;
		this.Probability6.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability6);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability6]));
		w13.X = 330;
		w13.Y = 210;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability7 = new global::Gtk.Entry();
		this.Probability7.CanFocus = true;
		this.Probability7.Name = "Probability7";
		this.Probability7.IsEditable = false;
		this.Probability7.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability7);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability7]));
		w14.X = 330;
		w14.Y = 240;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability8 = new global::Gtk.Entry();
		this.Probability8.CanFocus = true;
		this.Probability8.Name = "Probability8";
		this.Probability8.IsEditable = false;
		this.Probability8.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability8);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability8]));
		w15.X = 330;
		w15.Y = 270;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Probability9 = new global::Gtk.Entry();
		this.Probability9.CanFocus = true;
		this.Probability9.Name = "Probability9";
		this.Probability9.IsEditable = false;
		this.Probability9.InvisibleChar = '●';
		this.LayoutClassify.Add(this.Probability9);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Probability9]));
		w16.X = 330;
		w16.Y = 300;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.LabelZ = new global::Gtk.Label();
		this.LabelZ.Name = "LabelZ";
		this.LabelZ.LabelProp = global::Mono.Unix.Catalog.GetString("0:");
		this.LayoutClassify.Add(this.LabelZ);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.LabelZ]));
		w17.X = 315;
		w17.Y = 35;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label1 = new global::Gtk.Label();
		this.Label1.Name = "Label1";
		this.Label1.LabelProp = global::Mono.Unix.Catalog.GetString("1:");
		this.LayoutClassify.Add(this.Label1);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label1]));
		w18.X = 315;
		w18.Y = 65;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label2 = new global::Gtk.Label();
		this.Label2.Name = "Label2";
		this.Label2.LabelProp = global::Mono.Unix.Catalog.GetString("2:");
		this.LayoutClassify.Add(this.Label2);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label2]));
		w19.X = 315;
		w19.Y = 95;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label3 = new global::Gtk.Label();
		this.Label3.Name = "Label3";
		this.Label3.LabelProp = global::Mono.Unix.Catalog.GetString("3:");
		this.LayoutClassify.Add(this.Label3);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label3]));
		w20.X = 315;
		w20.Y = 125;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label4 = new global::Gtk.Label();
		this.Label4.Name = "Label4";
		this.Label4.LabelProp = global::Mono.Unix.Catalog.GetString("4:");
		this.LayoutClassify.Add(this.Label4);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label4]));
		w21.X = 315;
		w21.Y = 155;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label5 = new global::Gtk.Label();
		this.Label5.Name = "Label5";
		this.Label5.LabelProp = global::Mono.Unix.Catalog.GetString("5:");
		this.LayoutClassify.Add(this.Label5);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label5]));
		w22.X = 315;
		w22.Y = 185;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label6 = new global::Gtk.Label();
		this.Label6.Name = "Label6";
		this.Label6.LabelProp = global::Mono.Unix.Catalog.GetString("6:");
		this.LayoutClassify.Add(this.Label6);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label6]));
		w23.X = 315;
		w23.Y = 215;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label7 = new global::Gtk.Label();
		this.Label7.Name = "Label7";
		this.Label7.LabelProp = global::Mono.Unix.Catalog.GetString("7:");
		this.LayoutClassify.Add(this.Label7);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label7]));
		w24.X = 315;
		w24.Y = 245;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label8 = new global::Gtk.Label();
		this.Label8.Name = "Label8";
		this.Label8.LabelProp = global::Mono.Unix.Catalog.GetString("8:");
		this.LayoutClassify.Add(this.Label8);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label8]));
		w25.X = 315;
		w25.Y = 275;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.Label9 = new global::Gtk.Label();
		this.Label9.Name = "Label9";
		this.Label9.LabelProp = global::Mono.Unix.Catalog.GetString("9:");
		this.LayoutClassify.Add(this.Label9);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.Label9]));
		w26.X = 315;
		w26.Y = 305;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ScoreBox = new global::Gtk.Entry();
		this.ScoreBox.WidthRequest = 100;
		this.ScoreBox.HeightRequest = 70;
		this.ScoreBox.Name = "ScoreBox";
		this.ScoreBox.Text = global::Mono.Unix.Catalog.GetString("00.00 %");
		this.ScoreBox.IsEditable = false;
		this.ScoreBox.InvisibleChar = '●';
		this.ScoreBox.Xalign = 0.5F;
		this.LayoutClassify.Add(this.ScoreBox);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ScoreBox]));
		w27.X = 500;
		w27.Y = 30;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ScoreBoxLabel = new global::Gtk.Label();
		this.ScoreBoxLabel.Name = "ScoreBoxLabel";
		this.ScoreBoxLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Score</b>");
		this.ScoreBoxLabel.UseMarkup = true;
		this.ScoreBoxLabel.Justify = ((global::Gtk.Justification)(2));
		this.LayoutClassify.Add(this.ScoreBoxLabel);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ScoreBoxLabel]));
		w28.X = 530;
		w28.Y = 10;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ClassificationLabel = new global::Gtk.Label();
		this.ClassificationLabel.Name = "ClassificationLabel";
		this.ClassificationLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Digit</b>");
		this.ClassificationLabel.UseMarkup = true;
		this.LayoutClassify.Add(this.ClassificationLabel);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ClassificationLabel]));
		w29.X = 530;
		w29.Y = 130;
		// Container child LayoutClassify.Gtk.Fixed+FixedChild
		this.ClassificationBox = new global::Gtk.Entry();
		this.ClassificationBox.WidthRequest = 100;
		this.ClassificationBox.HeightRequest = 70;
		this.ClassificationBox.Name = "ClassificationBox";
		this.ClassificationBox.Text = global::Mono.Unix.Catalog.GetString("0");
		this.ClassificationBox.IsEditable = false;
		this.ClassificationBox.InvisibleChar = '●';
		this.ClassificationBox.Xalign = 0.5F;
		this.LayoutClassify.Add(this.ClassificationBox);
		global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.LayoutClassify[this.ClassificationBox]));
		w30.X = 500;
		w30.Y = 150;
		this.MainNotebook.Add(this.LayoutClassify);
		// Notebook tab
		this.PageClassify = new global::Gtk.Label();
		this.PageClassify.Name = "PageClassify";
		this.PageClassify.LabelProp = global::Mono.Unix.Catalog.GetString("Classify");
		this.MainNotebook.SetTabLabel(this.LayoutClassify, this.PageClassify);
		this.PageClassify.ShowAll();
		// Container child MainNotebook.Gtk.Notebook+NotebookChild
		this.LayoutNetwork = new global::Gtk.Fixed();
		this.LayoutNetwork.Name = "LayoutNetwork";
		this.LayoutNetwork.HasWindow = false;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.NetworksLayersLabel = new global::Gtk.Label();
		this.NetworksLayersLabel.Name = "NetworksLayersLabel";
		this.NetworksLayersLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Network Layers</b>");
		this.NetworksLayersLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.NetworksLayersLabel);
		global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.NetworksLayersLabel]));
		w32.X = 30;
		w32.Y = 10;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.NetworkLayers = global::Gtk.ComboBox.NewText();
		this.NetworkLayers.WidthRequest = 210;
		this.NetworkLayers.Name = "NetworkLayers";
		this.LayoutNetwork.Add(this.NetworkLayers);
		global::Gtk.Fixed.FixedChild w33 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.NetworkLayers]));
		w33.X = 30;
		w33.Y = 30;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationMap = new global::Gtk.Image();
		this.ActivationMap.WidthRequest = 128;
		this.ActivationMap.HeightRequest = 128;
		this.ActivationMap.Name = "ActivationMap";
		this.LayoutNetwork.Add(this.ActivationMap);
		global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationMap]));
		w34.X = 30;
		w34.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationMapLabel = new global::Gtk.Label();
		this.ActivationMapLabel.Name = "ActivationMapLabel";
		this.ActivationMapLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Activation</b>");
		this.ActivationMapLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.ActivationMapLabel);
		global::Gtk.Fixed.FixedChild w35 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationMapLabel]));
		w35.X = 30;
		w35.Y = 75;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationMapsTextBox = new global::Gtk.Entry();
		this.ActivationMapsTextBox.WidthRequest = 30;
		this.ActivationMapsTextBox.HeightRequest = 30;
		this.ActivationMapsTextBox.Name = "ActivationMapsTextBox";
		this.ActivationMapsTextBox.IsEditable = false;
		this.ActivationMapsTextBox.InvisibleChar = '●';
		this.ActivationMapsTextBox.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.ActivationMapsTextBox);
		global::Gtk.Fixed.FixedChild w36 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationMapsTextBox]));
		w36.X = 128;
		w36.Y = 70;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationMapScroll = new global::Gtk.HScrollbar(null);
		this.ActivationMapScroll.WidthRequest = 128;
		this.ActivationMapScroll.HeightRequest = 30;
		this.ActivationMapScroll.Name = "ActivationMapScroll";
		this.ActivationMapScroll.Adjustment.Upper = 100D;
		this.ActivationMapScroll.Adjustment.PageIncrement = 1D;
		this.ActivationMapScroll.Adjustment.PageSize = 1D;
		this.ActivationMapScroll.Adjustment.StepIncrement = 1D;
		this.LayoutNetwork.Add(this.ActivationMapScroll);
		global::Gtk.Fixed.FixedChild w37 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationMapScroll]));
		w37.X = 30;
		w37.Y = 230;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationXLabel = new global::Gtk.Label();
		this.ActivationXLabel.Name = "ActivationXLabel";
		this.ActivationXLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>X</b>");
		this.ActivationXLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.ActivationXLabel);
		global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationXLabel]));
		w38.X = 180;
		w38.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationX = new global::Gtk.Entry();
		this.ActivationX.WidthRequest = 30;
		this.ActivationX.HeightRequest = 30;
		this.ActivationX.Name = "ActivationX";
		this.ActivationX.IsEditable = false;
		this.ActivationX.InvisibleChar = '●';
		this.ActivationX.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.ActivationX);
		global::Gtk.Fixed.FixedChild w39 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationX]));
		w39.X = 170;
		w39.Y = 120;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationYLabel = new global::Gtk.Label();
		this.ActivationYLabel.Name = "ActivationYLabel";
		this.ActivationYLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Y</b>");
		this.ActivationYLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.ActivationYLabel);
		global::Gtk.Fixed.FixedChild w40 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationYLabel]));
		w40.X = 180;
		w40.Y = 160;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.ActivationY = new global::Gtk.Entry();
		this.ActivationY.WidthRequest = 30;
		this.ActivationY.HeightRequest = 30;
		this.ActivationY.Name = "ActivationY";
		this.ActivationY.IsEditable = false;
		this.ActivationY.InvisibleChar = '●';
		this.ActivationY.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.ActivationY);
		global::Gtk.Fixed.FixedChild w41 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.ActivationY]));
		w41.X = 170;
		w41.Y = 180;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureVectorLabel = new global::Gtk.Label();
		this.FeatureVectorLabel.Name = "FeatureVectorLabel";
		this.FeatureVectorLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Feature Vector</b>");
		this.FeatureVectorLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.FeatureVectorLabel);
		global::Gtk.Fixed.FixedChild w42 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureVectorLabel]));
		w42.X = 30;
		w42.Y = 270;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureVector = new global::Gtk.Image();
		this.FeatureVector.WidthRequest = 150;
		this.FeatureVector.HeightRequest = 50;
		this.FeatureVector.Name = "FeatureVector";
		this.LayoutNetwork.Add(this.FeatureVector);
		global::Gtk.Fixed.FixedChild w43 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureVector]));
		w43.X = 30;
		w43.Y = 295;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.Weights = new global::Gtk.Image();
		this.Weights.WidthRequest = 150;
		this.Weights.HeightRequest = 50;
		this.Weights.Name = "Weights";
		this.LayoutNetwork.Add(this.Weights);
		global::Gtk.Fixed.FixedChild w44 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.Weights]));
		w44.X = 220;
		w44.Y = 295;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.WeightsLabel = new global::Gtk.Label();
		this.WeightsLabel.Name = "WeightsLabel";
		this.WeightsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Weights</b>");
		this.WeightsLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.WeightsLabel);
		global::Gtk.Fixed.FixedChild w45 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.WeightsLabel]));
		w45.X = 220;
		w45.Y = 270;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.OutputLabel = new global::Gtk.Label();
		this.OutputLabel.Name = "OutputLabel";
		this.OutputLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Output</b>");
		this.OutputLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.OutputLabel);
		global::Gtk.Fixed.FixedChild w46 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.OutputLabel]));
		w46.X = 30;
		w46.Y = 360;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.Output = new global::Gtk.Image();
		this.Output.WidthRequest = 150;
		this.Output.HeightRequest = 50;
		this.Output.Name = "Output";
		this.LayoutNetwork.Add(this.Output);
		global::Gtk.Fixed.FixedChild w47 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.Output]));
		w47.X = 30;
		w47.Y = 385;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.NetworkBiasLabel = new global::Gtk.Label();
		this.NetworkBiasLabel.Name = "NetworkBiasLabel";
		this.NetworkBiasLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Network Bias</b>");
		this.NetworkBiasLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.NetworkBiasLabel);
		global::Gtk.Fixed.FixedChild w48 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.NetworkBiasLabel]));
		w48.X = 410;
		w48.Y = 270;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.NetworkBias = new global::Gtk.Image();
		this.NetworkBias.WidthRequest = 150;
		this.NetworkBias.HeightRequest = 50;
		this.NetworkBias.Name = "NetworkBias";
		this.LayoutNetwork.Add(this.NetworkBias);
		global::Gtk.Fixed.FixedChild w49 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.NetworkBias]));
		w49.X = 410;
		w49.Y = 295;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMap = new global::Gtk.Image();
		this.FeatureMap.WidthRequest = 128;
		this.FeatureMap.HeightRequest = 128;
		this.FeatureMap.Name = "FeatureMap";
		this.LayoutNetwork.Add(this.FeatureMap);
		global::Gtk.Fixed.FixedChild w50 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMap]));
		w50.X = 260;
		w50.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapLabel = new global::Gtk.Label();
		this.FeatureMapLabel.Name = "FeatureMapLabel";
		this.FeatureMapLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Feature Map</b>");
		this.FeatureMapLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.FeatureMapLabel);
		global::Gtk.Fixed.FixedChild w51 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapLabel]));
		w51.X = 260;
		w51.Y = 75;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapJ = new global::Gtk.VScrollbar(null);
		this.FeatureMapJ.WidthRequest = 30;
		this.FeatureMapJ.HeightRequest = 128;
		this.FeatureMapJ.Name = "FeatureMapJ";
		this.FeatureMapJ.Adjustment.Upper = 100D;
		this.FeatureMapJ.Adjustment.PageIncrement = 1D;
		this.FeatureMapJ.Adjustment.PageSize = 1D;
		this.FeatureMapJ.Adjustment.StepIncrement = 1D;
		this.FeatureMapJ.Adjustment.Value = 0.765625D;
		this.LayoutNetwork.Add(this.FeatureMapJ);
		global::Gtk.Fixed.FixedChild w52 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapJ]));
		w52.X = 220;
		w52.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapI = new global::Gtk.HScrollbar(null);
		this.FeatureMapI.WidthRequest = 128;
		this.FeatureMapI.HeightRequest = 30;
		this.FeatureMapI.Name = "FeatureMapI";
		this.FeatureMapI.Adjustment.Upper = 100D;
		this.FeatureMapI.Adjustment.PageIncrement = 1D;
		this.FeatureMapI.Adjustment.PageSize = 1D;
		this.FeatureMapI.Adjustment.StepIncrement = 1D;
		this.LayoutNetwork.Add(this.FeatureMapI);
		global::Gtk.Fixed.FixedChild w53 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapI]));
		w53.X = 260;
		w53.Y = 230;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapIText = new global::Gtk.Entry();
		this.FeatureMapIText.WidthRequest = 30;
		this.FeatureMapIText.HeightRequest = 30;
		this.FeatureMapIText.Name = "FeatureMapIText";
		this.FeatureMapIText.IsEditable = false;
		this.FeatureMapIText.InvisibleChar = '●';
		this.FeatureMapIText.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.FeatureMapIText);
		global::Gtk.Fixed.FixedChild w54 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapIText]));
		w54.X = 400;
		w54.Y = 120;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapILabel = new global::Gtk.Label();
		this.FeatureMapILabel.Name = "FeatureMapILabel";
		this.FeatureMapILabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>I</b>");
		this.FeatureMapILabel.UseMarkup = true;
		this.FeatureMapILabel.Justify = ((global::Gtk.Justification)(2));
		this.LayoutNetwork.Add(this.FeatureMapILabel);
		global::Gtk.Fixed.FixedChild w55 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapILabel]));
		w55.X = 410;
		w55.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapXText = new global::Gtk.Entry();
		this.FeatureMapXText.WidthRequest = 30;
		this.FeatureMapXText.HeightRequest = 30;
		this.FeatureMapXText.Name = "FeatureMapXText";
		this.FeatureMapXText.IsEditable = false;
		this.FeatureMapXText.InvisibleChar = '●';
		this.FeatureMapXText.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.FeatureMapXText);
		global::Gtk.Fixed.FixedChild w56 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapXText]));
		w56.X = 400;
		w56.Y = 180;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapXLabel = new global::Gtk.Label();
		this.FeatureMapXLabel.Name = "FeatureMapXLabel";
		this.FeatureMapXLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>X</b>");
		this.FeatureMapXLabel.UseMarkup = true;
		this.FeatureMapXLabel.Justify = ((global::Gtk.Justification)(2));
		this.LayoutNetwork.Add(this.FeatureMapXLabel);
		global::Gtk.Fixed.FixedChild w57 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapXLabel]));
		w57.X = 410;
		w57.Y = 160;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapJText = new global::Gtk.Entry();
		this.FeatureMapJText.WidthRequest = 30;
		this.FeatureMapJText.HeightRequest = 30;
		this.FeatureMapJText.Name = "FeatureMapJText";
		this.FeatureMapJText.IsEditable = false;
		this.FeatureMapJText.InvisibleChar = '●';
		this.FeatureMapJText.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.FeatureMapJText);
		global::Gtk.Fixed.FixedChild w58 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapJText]));
		w58.X = 440;
		w58.Y = 120;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapYText = new global::Gtk.Entry();
		this.FeatureMapYText.WidthRequest = 30;
		this.FeatureMapYText.HeightRequest = 30;
		this.FeatureMapYText.Name = "FeatureMapYText";
		this.FeatureMapYText.IsEditable = false;
		this.FeatureMapYText.InvisibleChar = '●';
		this.FeatureMapYText.Xalign = 0.5F;
		this.LayoutNetwork.Add(this.FeatureMapYText);
		global::Gtk.Fixed.FixedChild w59 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapYText]));
		w59.X = 440;
		w59.Y = 180;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapJLabel = new global::Gtk.Label();
		this.FeatureMapJLabel.Name = "FeatureMapJLabel";
		this.FeatureMapJLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>J</b>");
		this.FeatureMapJLabel.UseMarkup = true;
		this.FeatureMapJLabel.Justify = ((global::Gtk.Justification)(2));
		this.LayoutNetwork.Add(this.FeatureMapJLabel);
		global::Gtk.Fixed.FixedChild w60 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapJLabel]));
		w60.X = 450;
		w60.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.FeatureMapYLabel = new global::Gtk.Label();
		this.FeatureMapYLabel.Name = "FeatureMapYLabel";
		this.FeatureMapYLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Y</b>");
		this.FeatureMapYLabel.UseMarkup = true;
		this.FeatureMapYLabel.Justify = ((global::Gtk.Justification)(2));
		this.LayoutNetwork.Add(this.FeatureMapYLabel);
		global::Gtk.Fixed.FixedChild w61 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.FeatureMapYLabel]));
		w61.X = 450;
		w61.Y = 160;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.BiasMap = new global::Gtk.Image();
		this.BiasMap.WidthRequest = 128;
		this.BiasMap.HeightRequest = 128;
		this.BiasMap.Name = "BiasMap";
		this.LayoutNetwork.Add(this.BiasMap);
		global::Gtk.Fixed.FixedChild w62 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.BiasMap]));
		w62.X = 482;
		w62.Y = 100;
		// Container child LayoutNetwork.Gtk.Fixed+FixedChild
		this.BiasLabel = new global::Gtk.Label();
		this.BiasLabel.Name = "BiasLabel";
		this.BiasLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Bias</b>");
		this.BiasLabel.UseMarkup = true;
		this.LayoutNetwork.Add(this.BiasLabel);
		global::Gtk.Fixed.FixedChild w63 = ((global::Gtk.Fixed.FixedChild)(this.LayoutNetwork[this.BiasLabel]));
		w63.X = 482;
		w63.Y = 75;
		this.MainNotebook.Add(this.LayoutNetwork);
		global::Gtk.Notebook.NotebookChild w64 = ((global::Gtk.Notebook.NotebookChild)(this.MainNotebook[this.LayoutNetwork]));
		w64.Position = 1;
		// Notebook tab
		this.PageNetwork = new global::Gtk.Label();
		this.PageNetwork.Name = "PageNetwork";
		this.PageNetwork.LabelProp = global::Mono.Unix.Catalog.GetString("Network");
		this.MainNotebook.SetTabLabel(this.LayoutNetwork, this.PageNetwork);
		this.PageNetwork.ShowAll();
		this.MainLayout.Add(this.MainNotebook);
		global::Gtk.Fixed.FixedChild w65 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.MainNotebook]));
		w65.X = 80;
		w65.Y = 60;
		this.Add(this.MainLayout);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.DigitEventBox.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.OnDigitEventBoxButtonPressEvent);
		this.DigitEventBox.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler(this.OnDigitEventBoxButtonReleaseEvent);
		this.DigitEventBox.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler(this.OnDigitEventBoxMotionNotifyEvent);
		this.ButtonClassify.Clicked += new global::System.EventHandler(this.OnButtonClassifyClicked);
		this.LoadButton.Clicked += new global::System.EventHandler(this.OnLoadButtonClicked);
		this.ClearButton.Clicked += new global::System.EventHandler(this.OnClearButtonClicked);
		this.NetworkLayers.Changed += new global::System.EventHandler(this.OnNetworkLayersChanged);
		this.ActivationMapScroll.ValueChanged += new global::System.EventHandler(this.OnActivationMapScrollValueChanged);
		this.FeatureMapJ.ValueChanged += new global::System.EventHandler(this.OnFeatureMapJValueChanged);
		this.FeatureMapI.ValueChanged += new global::System.EventHandler(this.OnFeatureMapIValueChanged);
	}
}
