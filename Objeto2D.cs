using Godot;
using System;

public partial class Objeto2D : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Objeto2D ready!");
		Console.WriteLine("Objeto2D ready 0!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print("Objeto2D ready 2!");
		Console.WriteLine("Objeto2D ready 3!");
	}
}
