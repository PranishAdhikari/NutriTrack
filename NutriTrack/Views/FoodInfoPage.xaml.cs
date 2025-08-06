using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;

namespace NutriTrack.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
[QueryProperty(nameof(Food), "food")]
public partial class FoodInfoPage : ContentPage
{
    private readonly Dictionary<string, string> _nutritionData = new()
    {
        { "Apple", "Calories: 95, Carbs: 25g, Fiber: 4g, Sugar: 19g" },
        { "Banana", "Calories: 105, Carbs: 27g, Fiber: 3g, Sugar: 14g" },
        { "Carrot", "Calories: 41, Carbs: 10g, Fiber: 3g, Sugar: 5g" },
        { "Salmon", "Calories: 208, Protein: 20g, Fat: 13g" },
        { "Broccoli", "Calories: 55, Carbs: 11g, Fiber: 5g, Protein: 4g" }
    };

    private string _food;
    public string Food
    {
        get => _food;
        set
        {
            _food = value;
            UpdateFoodInfo();
        }
    }

    public FoodInfoPage()
    {
        InitializeComponent();
    }

    private void UpdateFoodInfo()
    {
        if (!string.IsNullOrWhiteSpace(_food) && _nutritionData.TryGetValue(_food, out string info))
        {
            FoodTitle.Text = _food;
            NutritionInfoLabel.Text = info;
        }
        else
        {
            FoodTitle.Text = "Food Not Found";
            NutritionInfoLabel.Text = "No nutrition information available.";
        }
    }
}
