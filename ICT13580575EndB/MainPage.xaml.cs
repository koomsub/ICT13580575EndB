using System;
using System.Collections.Generic;
using ICT13580575EndB.Models;

using Xamarin.Forms;

namespace ICT13580575EndB
{
    public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();

			newButton.Clicked += NewButton_Clicked;
		}
		void LoadData()
		{
			productListView.ItemsSource = App.DbHelper.GetProducts();
		}
		protected override void OnAppearing()
		{
			LoadData();
		}
		void NewButton_Clicked(object sender, EventArgs e)
		{
            Navigation.PushModalAsync(new ProductNewpage());
		}

		async void Delete_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as MenuItem;
            var car = button.CommandParameter as Product;
			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่มั้ย", "ใช่", "ไม่ใช่");
		}

		void Edit_Clicked(object sender, System.EventArgs e)
		{

			var button = sender as MenuItem;
            var car = button.CommandParameter as Product;
            Navigation.PushModalAsync(new ProductNewpage(car));
		}
	}
}
