using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButtonsGroupController : MonoBehaviour
{
    public Action OnSelectButtonClicked;
    public Action OnBuyButtonClicked;

    [SerializeField] private Button _selectButton;
    [SerializeField] private Button _buyButton;
    public TextMeshProUGUI _cost;

    private void Awake()
    {
        _selectButton.onClick.AddListener((() => OnSelectButtonClicked?.Invoke()));
        _buyButton.onClick.AddListener((() => OnBuyButtonClicked?.Invoke()));
        
        _cost = _buyButton.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void CheckButtons(Hero hero)
    {
        var isHeroBought = hero._isBought;
        if (isHeroBought)
        {
            _buyButton.gameObject.SetActive(false);
            _selectButton.interactable = true;
        }

        if (!isHeroBought)
        {
            _buyButton.gameObject.SetActive(true);
            _selectButton.interactable = false;
        }
    }
}