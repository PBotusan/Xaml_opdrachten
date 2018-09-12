using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataCell : ViewCell
	{
		public DataCell ()
		{
			InitializeComponent ();
		}
	}
}