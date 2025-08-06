using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace NutriTrack.Views;

public partial class SearchPage : ContentPage
{
    private List<string> _foodList = new() { "Apple", "Banana", "Carrot", "Salmon", "Broccoli" };

    public SearchPage()
    {
        InitializeComponent();
        ResultsCollectionView.ItemsSource = _foodList;
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        string query = FoodSearchBar.Text?.ToLower() ?? "";
        var results = _foodList.FindAll(food => food.ToLower().Contains(query));
        ResultsCollectionView.ItemsSource = results;
    }

    private async void OnFoodSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is string selectedFood)
        {
            await Shell.Current.GoToAsync($"{nameof(FoodInfoPage)}?food={selectedFood}");
            ResultsCollectionView.SelectedItem = null;
        }
    }
}
