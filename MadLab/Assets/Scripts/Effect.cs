using UnityEngine;

public class Effect
{
    public float delay;

    public virtual void Apply(CommandableObject movable)
    {
        Debug.Log("MADE");
    }

    public Effect(float delay)
    {
        this.delay = delay;
    }
}

public class Force:Effect
{
    public float strength;
    public Vector2 direction;
                
    public override void Apply(CommandableObject movable)
    {
        base.Apply(movable);
        if (movable.rb != null)
        {
            movable.rb.AddForce(direction.normalized * strength, ForceMode2D.Impulse);
        }
    }

    public Force(float strength, Vector2 direction, float delay) : base(delay)
    {
        this.strength = strength;
        this.direction = direction;
    }

}

public class Scale : Effect
{
    public float strength;

    public Scale(float strength, float delay) : base(delay)
    {
        this.strength = strength;
    }
}

public class Phase : Effect
{
    public float duration;

    public Phase(float duration, float delay) : base(delay)
    {
        this.duration = duration;
    }
}
public interface IClickable
{
    public void OnClick();
}
