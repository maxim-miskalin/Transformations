using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_speed, 0, 0);
    }
}
