using System;
using System.Collections.Generic;
using UnityEngine;

public class PersonalIndicatorsContainer : MonoBehaviour
{
    [SerializeField] private List<Indicator> indicators;

    public void Init(Command command)
    {
        for (int i = 0; i < command.indicators.Count; i++)
        {
            indicators.Add(Instantiate(command.indicators[i],transform));
        }
    }

    internal void Clear()
    {
        for (int i = 0; i < indicators.Count; i++)
        {
            Destroy(indicators[i].gameObject);
            indicators.Clear();
        }
    }
}
