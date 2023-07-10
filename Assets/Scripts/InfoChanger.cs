using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mainMenuHeroName;
    [SerializeField] private TextMeshProUGUI _mainMenuLevel;
    [SerializeField] private TextMeshProUGUI _mainMenuXp;

    [SerializeField] private TextMeshProUGUI _heroName;
    [SerializeField] private TextMeshProUGUI _level;
    [SerializeField] private TextMeshProUGUI _xp;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Slider _health;
    [SerializeField] private Slider _attack;
    [SerializeField] private Slider _deffense;
    [SerializeField] private Slider _speed;
    [SerializeField] private Image _icon;


    public void UpdateInfo(Hero hero)
    {
        _heroName.text = hero._name;
        _level.text = hero._level.ToString();
        _xp.text = hero._xp.ToString();
        _description.text = hero._description;
        _health.value = hero._health;
        _attack.value = hero._attack;
        _deffense.value = hero._deffense;
        _speed.value = hero._speed;
        _icon.sprite = hero.GetIcon();

    }

    public void UpdateInfoInMainMenu(Hero hero)
    {
        _mainMenuHeroName.text = hero._name;
        _mainMenuLevel.text = hero._level.ToString();
        _mainMenuXp.text = hero._xp.ToString();
    }
}