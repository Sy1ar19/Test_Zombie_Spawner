using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _enemySpawnerPosition;
    [SerializeField] private float _repeatRate;

    private int _randomSpawnPoint;

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
            yield return new WaitForSeconds(_repeatRate);
            _randomSpawnPoint = Random.Range(0, _enemySpawnerPosition.Length);
            Instantiate(_enemy, _enemySpawnerPosition[_randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
