using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MultiSelectListView
{
	public class MultiSelectViewModel
	{

		public MultiSelectViewModel(List<SelectableData<ExampleData>> data)
		{
			DataList = data;
		}

		// As example if you need to convert
		//private void LoadData(List<ExampleData> data)
		//{
		//	var list = new List<SelectableData<ExampleData>>();

		//	foreach (var item in data)
		//		list.Add(new SelectableData<ExampleData>() { Data = item });

		//	DataList = list;
		//}

		public List<SelectableData<ExampleData>> DataList { get; set; }

		public List<SelectableData<ExampleData>> GetNewData()
		{
			var list = new List<SelectableData<ExampleData>>();

			foreach (var data in DataList)
				list.Add(new SelectableData<ExampleData>() { Data = data.Data.Clone(), Selected = data.Selected });

			return list;
		}

		public ICommand FinishCommand
		{
			get
			{
				return new Command(async () =>
				{
					MainPageViewModel.SelectedData = GetNewData();
					await App.NavPage.PopAsync();
				});
			}

		}

	}
}
