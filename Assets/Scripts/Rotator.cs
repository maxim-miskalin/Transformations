using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _turningSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up, _turningSpeed);
    }
}
