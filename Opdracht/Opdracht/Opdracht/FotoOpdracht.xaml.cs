using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FotoOpdracht : ContentPage
	{
        private int ImageId = 1;

		public FotoOpdracht ()
		{
			InitializeComponent ();

            Left.Image = (FileImageSource)ImageSource.FromFile("Images/left.png");
            Right.Image = (FileImageSource)ImageSource.FromFile("Images/right.png");


            ImageId = 1;

            LoadMainImage();
        }

        private void LoadMainImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", ImageId)),
                CachingEnabled = false
            };
        }

        private void Left_Clicked(object sender, System.EventArgs e)
        {
            ImageId--;
            if (ImageId == 0)
            {
                ImageId = 10;
            }

            LoadMainImage();
        }

        private void Right_Clicked(object sender, System.EventArgs e)
        {

            ImageId++;
            if (ImageId == 11)
            {
                ImageId = 0;
            }

            LoadMainImage();
        }
    }
}