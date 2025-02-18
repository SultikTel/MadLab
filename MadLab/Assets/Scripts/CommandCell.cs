using UnityEngine;
using UnityEngine.UI;

public class CommandCell : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private IndicatorsContainer indicatorsContainer;

    public void Init(Command command)
    {
        image.sprite = command.image;
        indicatorsContainer.Init(command);
    }

    public void Clear()
    {
        indicatorsContainer.Clear();
    }
}
