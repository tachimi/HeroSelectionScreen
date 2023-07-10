using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private InterfaceManager _interfaceManager;
    [SerializeField] private HeroesChanger _heroesChanger;

    private void Update()
    {
        if (_heroesChanger.IsHeroSelected)
        {
            _interfaceManager.ShowMainMenu();
            _heroesChanger.IsHeroSelected = false;
        }
    }

 
}