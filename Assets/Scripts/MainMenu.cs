using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Action HeroesButtonClicked;

    [SerializeField] private Button _heroesButton;

    private void Awake()
    {
        _heroesButton.onClick.AddListener((() => HeroesButtonClicked?.Invoke()));
    }
}
