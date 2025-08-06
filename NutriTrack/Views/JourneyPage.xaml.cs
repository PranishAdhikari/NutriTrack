using Microsoft.Maui.Controls;
using System;

namespace NutriTrack.Views
{

	public partial class JourneyPage : ContentPage
	{
		private double startingWeight = 180.0;
		private double currentWeight = 180.0;
		public JourneyPage()
		{
			InitializeComponent();
			UpdateUI();
		}

		private void UpdateUI()
		{
			CurrentWeightLabel.Text = $"Current Weight: {currentWeight} lbs";
			double progress = startingWeight - currentWeight;
			ProgressLabel.Text = $"Progress: {progress:F1} lbs {(progress >= 0 ? "lost" : "gained")}";
		}

		private async void OnUpdateWeightClicked(object sender, EventArgs e)
		{
			string result = await DisplayPromptAsync("Update Weight", "Enter your current weight (lbs):", keyboard: Keyboard.Numeric);

			if (double.TryParse(result, out double newWeight))
			{
				currentWeight = newWeight;
				UpdateUI();
				await DisplayAlert("Success", "Weight updated.", "OK");
			} else
			{
				await DisplayAlert("Invalid Input", "Please enter a valid number.", "OK");
			}
		}
	}
}
