using System;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameConfigurationPanel gameConfigurationPanel;
    public Action<Command> commandAdded;
    public Action startPressed;

    private void OnEnable()
    {
        foreach (CommandAddButton button in gameConfigurationPanel.commandAddButtons)
        {
            button.button.onClick.AddListener(() =>commandAdded?.Invoke(button.command));
        }
        gameConfigurationPanel.startButton.onClick.AddListener(() => startPressed?.Invoke());
    }
}
