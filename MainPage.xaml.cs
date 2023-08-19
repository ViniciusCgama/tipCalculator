using tipCalculator;

namespace tipCalculator;

public partial class MainPage : ContentPage
{
	void CalculateTip(bool OnNormalTip ,bool OnGenarateTip, bool roundUp, bool roundDown)
	{
		double t;
		if (Double.TryParse(billInput.Text, out t) && t > 0)
		{
			double pct = Math.Round(tipPercentSlider.Value);
			double tip = Math.Round(t * (pct / 100.0), 2);

			double final = t + tip;

			if (roundUp)
			{
				final = Math.Ceiling(final);
				tip = final - t;
			}
			else if (roundDown)
			{
				final = Math.Ceiling(final);
				tip = final - t;
			}
			tipOutput.Text = final.ToString("C");
			totalOutput.Text = final.ToString("C");
		}
	}
}