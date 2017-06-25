using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiSelectListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MultiSelect : ContentPage
	{
		public MultiSelect(List<SelectableData<ExampleData>> data)
		{
			InitializeComponent();
			BindingContext = new MultiSelectViewModel(data);
		}
	}
}