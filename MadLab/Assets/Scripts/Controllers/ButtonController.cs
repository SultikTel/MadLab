using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button startGame;
    [SerializeField] private List<Button> effectsButtons;
    [SerializeField] private CommandableObject hero;

    private void OnEnable()
    {
        startGame.onClick.AddListener(() => hero.ApplyAll());
        foreach (Button button in effectsButtons)
        {
            button.onClick.AddListener(() => {
                hero.effects.Add(new Force(10, new Vector2(1, 1),3f));
                hero.effects.Add(new Force(15, new Vector2(0, 1),5f));
            });
        }
    }
}
