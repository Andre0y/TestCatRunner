using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _playersCatchesCatCount;

    private bool _isAlowedMoving = true;

    private void Update()
    {
        Move(_isAlowedMoving);
    }

    private void Move(bool isAlowedMoving)
    {
        if (isAlowedMoving)
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Cat cat))
        {
            Destroy(collision.gameObject);
            _playersCatchesCatCount += cat.CatCost;
        }
        if(collision.gameObject.TryGetComponent(out FinishLevel finishLevel))
        {
            Debug.Log("Level finished!");
            _isAlowedMoving = false;
            GoToMultiplier(finishLevel.MultiplyCats(_playersCatchesCatCount));
        }
    }

    private void GoToMultiplier(float multilier)
    {
        transform.Translate(0, 0, Mathf.MoveTowards(multilier, 100f, 20));
        
        Debug.Log("You are in current multiplier!");
        Debug.Log(Mathf.MoveTowards(multilier, 100f, 20));
    }
}
