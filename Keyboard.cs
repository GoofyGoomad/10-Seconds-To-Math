using Godot;
using System;

public partial class Keyboard : Node
{
	private AnimatedSprite2D keyboardAnim;
	
	public override void _Ready()
	{
		keyboardAnim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		keyboardAnim.Play(default);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
