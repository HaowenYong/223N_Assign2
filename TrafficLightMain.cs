using System;
using System.Drawing;
using System.Windows.Forms;

public class TrafficLightMain : Form{
	static void Main(string[] args){
		System.Console.WriteLine("assignment 2");
		TrafficLight s = new TrafficLight();
		Application.Run(s);
		System.Console.WriteLine("end of assignment 2");
	}
}