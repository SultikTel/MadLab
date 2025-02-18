using System;
using System.Collections;
using UnityEngine;

public class IndicatorsContainer : MonoBehaviour
{
    [SerializeField] private SliderIndicator delayIndicator;
    [SerializeField] private PersonalIndicatorsContainer personalIndicator;
    public void Init(Command command)
    {
        delayIndicator.SetLink(command);
        personalIndicator.Init(command);
    }

    internal void Clear()
    {
        personalIndicator.Clear();
    }
}
