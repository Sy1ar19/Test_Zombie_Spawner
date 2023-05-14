using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _enemySpawnerPosition;
    [SerializeField] private float _repeatRate;

    private int _randomSpawnPoint;
    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new WaitForSeconds(_repeatRate);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out FirstPersonController player))
        {
            StartCoroutine(Spawn());
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return _wait;
            _randomSpawnPoint = Random.Range(0, _enemySpawnerPosition.Length);
            Instantiate(_enemy, _enemySpawnerPosition[_randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
