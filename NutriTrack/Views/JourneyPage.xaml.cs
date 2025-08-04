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
	}
}