using System.Drawing;
using System.Windows.Forms;
public class TrafficLightAlgorithms
{
	public static int algorithm(int count, ref System.Timers.Timer clock, ref Brush brush1, ref Brush brush2, ref Brush brush3)
	{
		switch(count)
		{
			case 0: clock.Interval = (int)5000;
				brush1 = Brushes.Red; 
				brush2 = Brushes.Black;
				brush3 = Brushes.Black; break;
			case 1: clock.Interval = (int)2000;
				brush2 = Brushes.Orange; 
				brush1 = Brushes.Black;
				brush3 = Brushes.Black; break;
			case 2: clock.Interval = (int)3000;
				brush3 = Brushes.Green; 
				brush1 = Brushes.Black;
				brush2 = Brushes.Black; break;
		}
		return (count+1)%4;
	}
}