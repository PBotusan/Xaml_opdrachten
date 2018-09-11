using Xamarin.Forms;

namespace Opdracht
{
    public partial class MainPage : ContentPage
    {
        private int counter = 0;

        private string[] quotes = new string[]
        {
            "“Don’t cry because it’s over, smile because it happened.” – Dr. Seuss",
            "“You’ve gotta dance like there’s nobody watching.” – William W. Purkey",
            "“You only live once, but if you do it right, once is enough.” – Mae West",
            "“In three words I can sum up everything I’ve learned about life, it goes on.” – Robert Frost",
            "“To live is the rarest thing in the world. Most people exist, that is all” – Oscar Wilde",
            "“It is better to be hated for what you are than to be loved for what you are not.” – Andre Gide",
            "“It does not do well to dwell on dreams and forget to live.” – J.K. Rowling",
            "“Life is what happens to us while we are making other plans.” – Allen Saunders",
            "“Good friends, good books, and a sleepy conscience: this is the ideal life.” – Mark Twain",
            "“Sometimes the questions are complicated and the answers are simple.” – Dr. Seuss",
            "“Everything you can imagine in real.” – Pablo Picasso",
            "“Today you are you, that is truer than true.” – Dr. Seuss",
            "“I’m not afraid of death, I just don’t want to be there when it happens.” – Woody Allen",
            "“Life isn’t about finding yourself. Life is about creating yourself.” – George Bernard Shaw",
            "“Life is like riding a bicycle. To keep your balance, you must keep moving.” – Albert Einstein",
            "“Things change and friends leave. Life doesn’t Stop for Anybody.” – Stephen Chbosky",
            "“If you don’t know where you’re going, any road’ll take you there.” – George Harrison",
            "“Death ends a life, not a relationship.” – Mitch Albom",
            "“You cannot find peace avoiding life.” – Virginia Woolf",
            "“Life is a book and there are a thousand pages I have not yet read.” – Cassandra Clare",
            "“Life’s under no obligation to give us what we expect.” – Margaret Mitchell",
            "“Tell the truth, or someone will tell it for you.” – Stephanie Klein"
        };

        public MainPage()
        {
            InitializeComponent();

           
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            counter++;
            if (counter >= quotes.Length)
            {
                counter = 0; 
            }
            quoteText.Text = quotes[counter];
        }

        private void fontSizeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Slider slide = sender as Slider;
            if (slide != null)
            {
                quoteText.FontSize = slide.Value;
            }
        }

      }

    
}










