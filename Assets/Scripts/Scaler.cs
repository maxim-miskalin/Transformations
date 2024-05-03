using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;

    private void Update()
    {
        transform.localScale += Vector3.one * _rateOfIncrease;
    }
}
