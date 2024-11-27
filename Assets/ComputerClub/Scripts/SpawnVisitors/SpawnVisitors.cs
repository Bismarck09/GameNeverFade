using System.Collections;
using UnityEngine;

public class SpawnVisitors : MonoBehaviour
{
    [SerializeField] private Visitor _visitor;
    [SerializeField] private AllComputers _allComputers;
    [SerializeField] private Vector3 _spawnPosition;

    private float _elapsedTimeOfLastSpawned;
    private float _spawnTime;
    private int _spawnVisitorCount;
    private int _startTimeSpawn = 10;
    private int _startNumberOfComputers = 5;
    private bool _isStartSpawning;

    private void Update()
    {
        if (_isStartSpawning)
        {
            _elapsedTimeOfLastSpawned += Time.deltaTime;

            if (_elapsedTimeOfLastSpawned >= _spawnTime)
            {
                StartCoroutine(Spawn());
                CalculateSpawnTime();

                _elapsedTimeOfLastSpawned = 0;
            }
        }
    }

    private IEnumerator Spawn()
    {
        _spawnVisitorCount = Random.Range(1, 6);

        for (int i = 0; i < _spawnVisitorCount; i++)
        {
            Instantiate(_visitor, _spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void CalculateSpawnTime()
    {
        if (_allComputers.Computers > 0)
            _spawnTime = _startTimeSpawn * _startNumberOfComputers / _allComputers.Computers;
        else
            _spawnTime = _startTimeSpawn;
    }

    public void StartSpawn()
    {
        _isStartSpawning = true;

        CalculateSpawnTime();
        _elapsedTimeOfLastSpawned = _spawnTime;
    }
}
