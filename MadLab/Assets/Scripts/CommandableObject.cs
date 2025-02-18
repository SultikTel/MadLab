using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandableObject : MonoBehaviour, IClickable
{
    public List<Command> commands;
    public Rigidbody2D rb;
    public Action<CommandableObject> clicked;

    public void ApplyAllCommands()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        for (int i = 0; i < commands.Count; i++)
        {
            StartCoroutine(StartWithDelay(commands[i]));
        }
    }

    public IEnumerator StartWithDelay(Command effect)
    {
        yield return new WaitForSeconds(effect.Delay);
        effect.Apply(this);
    }

    public void OnClick()
    {
        clicked?.Invoke(this);
    }
}

