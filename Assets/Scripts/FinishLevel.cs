using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private float _currentLevelMaxCatCount;
    private float _multiplier;

    private void Start()
    {
        _currentLevelMaxCatCount = Level.Instance.CatCount;
        Debug.Log($"Cat count {_currentLevelMaxCatCount}");
    }

    public float MultiplyCats(float catchedCatsCount)
    {
        _multiplier = Mathf.Round(catchedCatsCount / _currentLevelMaxCatCount * 100);
        Debug.Log($"Current multiplier is {_multiplier}");
        
        return _multiplier;
    }
}
