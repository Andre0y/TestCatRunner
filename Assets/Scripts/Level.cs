using UnityEngine;

public class Level : MonoBehaviour
{
    private int _catCount;
    private Cat[] _cats;
    
    public static Level Instance;

    public int CatCount => _catCount;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        FindCatCount();
    }

    private void FindCatCount()
    {
        _cats = FindObjectsOfType<Cat>();
        _catCount = _cats.Length;
    }
}
