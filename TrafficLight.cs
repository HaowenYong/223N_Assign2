using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

public class TrafficLight : Form{

	private static System.Timers.Timer seiko = new System.Timers.Timer();
	
	private Button start = new Button(); // line 10
	private Button pause = new Button();
	private Button exit = new Button();

	private int counter = 0;
	private Brush brush1 = new SolidBrush(System.Drawing.Color.White);
	private Brush brush2 = new SolidBrush(System.Drawing.Color.White);
	private Brush brush3 = new SolidBrush(System.Drawing.Color.White);


	public TrafficLight() {
		Text = "Traffic Light";
		Size = new Size(1280, 720);

		start.Text = "Start";
		start.Size = new Size(85, 25);
		start.Location = new Point(150, 640);
		pause.Text = "Pause";
		pause.Size = new Size(85, 25);
		pause.Location = new Point(550, 640);
		exit.Text = "Exit";
		exit.Size = new Size(85, 25);
		exit.Location = new Point(950, 640);

		Controls.Add(start);
		Controls.Add(pause);
		Controls.Add(exit);

		start.Click += new EventHandler(start_func);
		pause.Click += new EventHandler(pause_func);
		exit.Click += new EventHandler(exit_func);

		seiko.Enabled = false;
		seiko.Elapsed += new ElapsedEventHandler(seiko_func);
		seiko.Interval = 2;
		seiko.Enabled = true;
	}
	
	protected override void OnPaint(PaintEventArgs e) {
		Graphics board = e.Graphics;

		board.FillEllipse(brush1, 20, 20, 75, 75);
		board.FillEllipse(brush2, 115, 20, 75, 75);
		board.FillEllipse(brush3, 210, 20, 75, 75);

		base.OnPaint(e);
	}

	protected void seiko_func(System.Object s, ElapsedEventArgs e){
		counter = TrafficLightAlgorithms.algorithm(counter, ref seiko, ref brush1, ref brush2, ref brush3);
		Invalidate();
	}

	protected void start_func(Object sender, EventArgs events){
		seiko.Enabled = true;
		System.Console.WriteLine("you've clicked on the start button.");
	}

	protected void pause_func(Object sender, EventArgs events){
		if(seiko.Enabled == true){
			seiko.Enabled = false;
			pause.Text = "resume";
		}
		else{
			seiko.Enabled = true;
			pause.Text = "pause";		
		}
		System.Console.WriteLine("you've clicked on the pause button.");
	}

	protected void exit_func(Object sender, EventArgs events){
		seiko.Enabled = false;
		System.Console.WriteLine("you've clicked on the exit button.");
		Close();
	}
}