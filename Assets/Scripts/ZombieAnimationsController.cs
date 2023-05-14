using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ZombieAnimationsController : MonoBehaviour
{
    private float _speed = 1.0f;
    private Animator _animator;
    private static readonly int SpeedHash = Animator.StringToHash("Speed");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        _animator.SetFloat(SpeedHash, currentSpeed * _speed);
    }
}
