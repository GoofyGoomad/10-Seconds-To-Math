using Godot;
using System;

public partial class Keyboard : Sprite2D
{
	private AnimatedSprite2D keyboardAnim;
	
	public override void _Ready()
	{

		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		animatedSprite2D.Animation = "default";

		Show();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		if (Input.IsActionPressed("one_key"))
		{
			

			animatedSprite2D.Animation = "one";
			
		}
		else
		{
			animatedSprite2D.Animation = "default";
		}
	}
}
