using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ZombieAnimationsController : MonoBehaviour
{
    private float _speed = 1.0f;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        _animator.SetFloat("Speed", currentSpeed * _speed);
    }
}
