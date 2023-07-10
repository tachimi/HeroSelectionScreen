using UnityEngine;

public class SelectedHero : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    public void SpawnHero(Hero hero)
    {
        var currentHero = _spawnPoint.GetChild(0).gameObject;
        var selectedHero = hero.GetHeroPrefab();

        if (currentHero == selectedHero) return;
        Destroy(currentHero);
        Instantiate(selectedHero, _spawnPoint);
    }
}