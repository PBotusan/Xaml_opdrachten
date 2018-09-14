using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Opdracht.Sqlite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sqlite : ContentPage
    {

        [Table("Recipes")]
        public class Recipe
        {

            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(255)]
            public string Name { get; set; }
            //public string Taste { get; set; }
            ///public string Rating { get; set; }
        }

        private SQLiteAsyncConnection _connection;

        public Sqlite()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        protected override async void OnAppearing()
        {
            //_connection.CreateTableAsync<Recipe>();
            await _connection.CreateTableAsync<Recipe>();

            _connection.Table<Recipe>.ToListAsync();

            //  var recipe =  _connection.CreateTableAsync<Recipe>();
            recipesListView.ItemsSource = recipes;


            base.OnAppearing();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
        }

        async void Update_Clicked(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe" + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {

        }
    }
}