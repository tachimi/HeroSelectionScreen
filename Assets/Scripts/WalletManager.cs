using TMPro;
using UnityEngine;

public class WalletManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coins;
    [SerializeField] private ChoiceButtonsGroupController _choiceButtonsGroupController;

    private void Awake()
    {
        _choiceButtonsGroupController.OnBuyButtonClicked += ChangeCoins;
    }

    private void ChangeCoins()
    {
        int.TryParse(_choiceButtonsGroupController._cost.text, out var cost);
        int.TryParse(_coins.text, out var coins);

        int result = coins - cost;
        _coins.text = result.ToString();
    }
}