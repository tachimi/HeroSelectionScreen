using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class HeroesChanger : MonoBehaviour
{
    [SerializeField] private InfoChanger _infoChanger;

    [SerializeField] private SelectedHero _selectedHero;

    [SerializeField] private ChoiceButtonsGroupController _choiceButtonsGroupController;

    [SerializeField] private Transform _spawnPoint;

    [SerializeField] private List<Hero> _heroes;

    private int _heroIndex;
    private Hero _currentHero;

    public bool IsHeroSelected { get; set; }

    private void Awake()
    {
        SpawnHero(0);

        _currentHero._isBought = true;
        _infoChanger.UpdateInfo(_currentHero);
        _infoChanger.UpdateInfoInMainMenu(_currentHero);

        _choiceButtonsGroupController.CheckButtons(_currentHero);

        _choiceButtonsGroupController.OnSelectButtonClicked += SelectHero;
        _choiceButtonsGroupController.OnBuyButtonClicked += BuyHero;
    }

    private void BuyHero()
    {
        _currentHero._isBought = true;
        _choiceButtonsGroupController.CheckButtons(_currentHero);
    }

    private void SelectHero()
    {
        _selectedHero.SpawnHero(_currentHero);
        _infoChanger.UpdateInfoInMainMenu(_currentHero);
        IsHeroSelected = true;
    }

    [UsedImplicitly]
    public void ChangeHero(int result)
    {
        switch (result)
        {
            case 1:
                if (_heroIndex == _heroes.Count - 1)
                {
                    SpawnHero(_heroIndex = 0);
                    break;
                }

                SpawnHero(_heroIndex += result);
                break;
            case -1:
                if (_heroIndex == 0)
                {
                    SpawnHero(_heroIndex = _heroes.Count - 1);
                    break;
                }

                SpawnHero(_heroIndex += result);
                break;
        }
    }

    private void SpawnHero(int index)
    {
        if (_spawnPoint.childCount > 0)
        {
            Destroy(_spawnPoint.GetChild(0).gameObject);
        }

        var heroPrefab = _heroes[index].GetHeroPrefab();
        _currentHero = _heroes[index];

        Instantiate(heroPrefab, _spawnPoint);

        _infoChanger.UpdateInfo(_currentHero);
        _choiceButtonsGroupController.CheckButtons(_currentHero);
    }
}