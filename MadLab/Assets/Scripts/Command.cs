using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Command
{
    private float delay;
    public float Delay
    {
        set => delay = Mathf.Clamp(value, minDelay, maxDelay);
        get => delay;
    }
    public float minDelay=0;
    public float maxDelay=10;
    public Sprite image;
    public List<Indicator> indicators;
    public virtual void Apply(CommandableObject movable)
    {
        Debug.Log("MADE");
    }

    public Command(float delay)
    {
        Delay = delay;
    }
}

public class Force:Command
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

public class Scale : Command
{
    public float strength;

    public Scale(float strength, float delay) : base(delay)
    {
        this.strength = strength;
    }
}

public class Phase : Command
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
