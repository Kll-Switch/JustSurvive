using Godot;
using System;

public partial class movement : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		Vector2 direction.X = Input.GetVector("ui_left", "ui_right");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else if (direction.Y != 0)
        {
			velocity.Y = direction.Y * Speed;
        }

		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
