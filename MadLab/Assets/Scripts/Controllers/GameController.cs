using System;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CommandableObject currentSelectedObject;
    public List<CommandableObject> commandableObjects;
    public Action<CommandableObject> currentCommandableObjectChanged;
    public ButtonController buttonController;
    [SerializeField] private GameConfigurationPanel gameConfigurationPanel;

    private void Start()
    {
        foreach (CommandableObject commandableObject in commandableObjects)
        {
            commandableObject.clicked += SetNewCurrentObject;
        }
    }

    public void StartTheGame()
    {
        foreach (CommandableObject commandableObject in commandableObjects)
        {
            commandableObject.ApplyAllCommands();
        }
    }

    public void SetNewCurrentObject(CommandableObject commandableObject)
    {
        currentSelectedObject = commandableObject;
        gameConfigurationPanel.FillCommandsContainer(currentSelectedObject.commands);
        currentCommandableObjectChanged?.Invoke(commandableObject);
    }

    public void AddNewCommandToCurrentCommandableObject(Command command)
    {
        currentSelectedObject.commands.Add(command);
        gameConfigurationPanel.FillCommandsContainer(currentSelectedObject.commands);
    }

    private void OnEnable()
    {
        buttonController.commandAdded += AddNewCommandToCurrentCommandableObject;
        buttonController.startPressed += StartTheGame;
    }
}
