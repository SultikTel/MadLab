using System.Collections.Generic;
using UnityEngine;

public class CommandsContainer : MonoBehaviour
{
    [SerializeField] private CommandCell commandCellPrefab;
    [SerializeField] private int maxCommandNum;
    [SerializeField] private List<CommandCell> commandCells;

    private void Start()
    {
        for (int i = 0; i < maxCommandNum; i++)
        {
            commandCells.Add(Instantiate(commandCellPrefab, transform));
        }
        ClearAllCommands();
    }

    public void DisplayAllCommands(List<Command> commands)
    {
        ClearAllCommands();
        for (int i = 0; i < commands.Count; i++)
        {
            commandCells[i].Init(commands[i]);
            commandCells[i].gameObject.SetActive(true);
        }
    }

    private void ClearAllCommands()
    {
        foreach (CommandCell commandCell in commandCells)
        {
            commandCell.gameObject.SetActive(false);
            commandCell.Clear();
        }
    }
}