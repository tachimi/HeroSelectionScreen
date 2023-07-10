using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private HeroesMenu _heroesMenu;
    [SerializeField] private GameObject _mainMenuHeroCamera;
    [SerializeField] private GameObject _heroesMenuHeroCamera;

    private void Awake()
    {
        _mainMenu.HeroesButtonClicked += ShowHeroesMenu;
        _heroesMenu.BackButtonClicked += ShowMainMenu;
    }

    public void ShowMainMenu()
    {
        _mainMenu.gameObject.SetActive(true);
        _heroesMenu.gameObject.SetActive(false);
        _mainMenuHeroCamera.SetActive(true);
        _heroesMenuHeroCamera.SetActive(false);
        
    }

    private void ShowHeroesMenu()
    {
        _mainMenu.gameObject.SetActive(false);
        _heroesMenu.gameObject.SetActive(true);
        _mainMenuHeroCamera.SetActive(false);
        _heroesMenuHeroCamera.SetActive(true);
        
    }
}
