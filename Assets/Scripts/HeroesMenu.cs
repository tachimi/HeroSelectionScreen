using System;
using UnityEngine;
using UnityEngine.UI;

public class HeroesMenu : MonoBehaviour
{
    public Action BackButtonClicked;
    
    [SerializeField] private Button _backButton;

    private void Awake()
    {
        _backButton.onClick.AddListener((() => BackButtonClicked?.Invoke()));
    }
}
