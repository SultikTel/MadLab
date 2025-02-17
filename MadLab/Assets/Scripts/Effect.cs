using UnityEngine;

[System.Serializable]
public class Effect
{
    public float delay;

    public virtual void Apply(MovableObject movable)
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
                
    public override void Apply(MovableObject movable)
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