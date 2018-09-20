# DeepLearnMac

## About DeepLearnMac

![About DeepLearnMac](/Screenshots/MNIST.png)

DeepLearnMac is a user interface for classifying hand-drawn (on a computer) digits 0-9. It utilizes a trained 6 layer convolutional neural network (CNN).

These layers are

* Input layer (resized to 28x28)
* Convolution layer 1 (6 maps, each 5x5)
* Subsampling layer 1 (2x2)
* Convolution layer 2 (12 maps, each 5x5)
* Subsampling layer 2 (2x2)
* Fully connected layer

On the Classify page, you can draw patterns on the canvas or load an image for classification. Scores for each digit are computed. The drawn/loaded image is classified according to the digit with the highest score.
 
## Visualization

![Visualization](/Screenshots/Visualization.png)

After classification, the activations of each layer are shown in the Network page. Some layers only have activation maps. Convolution layers have feature maps the bias values. The fully connected layer (Feature Vector), the network weights and biases are also shown. Finally, the output layer from which the classification scores are derived are also rendered in this page.

## Inspiration

The backend of DeepLearnMac is based on the CNN component Rasmus Berg Palm's DeepLearnToolbox (https://github.com/rasmusbergpalm/DeepLearnToolbox)
