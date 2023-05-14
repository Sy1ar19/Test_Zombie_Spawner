using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _agent;
    private FirstPersonController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<FirstPersonController>();
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _agent.SetDestination(playerController.transform.position);
    }
}
