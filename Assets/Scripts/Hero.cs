using UnityEngine;

[CreateAssetMenu (fileName = "Hero")]
public class Hero : ScriptableObject
{
    public string _name;
    public string _description;
    
    public int _level;
    public int _xp;
    public int _health;
    public int _attack;
    public int _deffense;
    public int _speed;
    public bool _isBought;
    
    
    [SerializeField] private GameObject _heroPrefab;
    [SerializeField] private Sprite _icon;

    public GameObject GetHeroPrefab()
    {
        return _heroPrefab;
    }

    public Sprite GetIcon()
    {
        return _icon;
    }

}
