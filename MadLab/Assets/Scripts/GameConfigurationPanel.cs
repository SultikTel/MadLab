using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameConfigurationPanel : MonoBehaviour
{
    public Button startButton;
    public List<CommandAddButton> commandAddButtons;
    [SerializeField] private CommandsContainer commandsContainer;

    public void FillCommandsContainer(List<Command> commands)
    {
        commandsContainer.DisplayAllCommands(commands);
    }
}
