using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public List<Effect> effects;
    public Rigidbody2D rb;

    private void Start()
    {
    }

    public void ApplyAll()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        for (int i = 0; i < effects.Count; i++)
        {
            StartCoroutine(StartWithDelay(effects[i]));
        }
    }

    public IEnumerator StartWithDelay(Effect effect)
    {
        yield return new WaitForSeconds(effect.delay);
        effect.Apply(this);
    }
}

