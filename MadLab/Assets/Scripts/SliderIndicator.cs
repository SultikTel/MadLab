using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderIndicator : Indicator
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text text;

    private Command command;

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(Change);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(Change);
    }

    public void SetLink(Command command)
    {
        this.command = command;
        slider.value = command.Delay/command.maxDelay;
        text.text = ((int)command.Delay).ToString();
    }

    public void Change(float value)
    {
        command.Delay = (int)(value * command.maxDelay);
        text.text = ((int)command.Delay).ToString();
    }
}
