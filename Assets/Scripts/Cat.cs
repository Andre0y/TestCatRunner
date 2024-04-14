using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private int _catCost;

    public int CatCost => _catCost;
}
