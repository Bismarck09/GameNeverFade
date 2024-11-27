using UnityEngine;

public class StartMovement : MonoBehaviour
{
    [SerializeField] private GameObject _joystic;
    [SerializeField] private GameBeginning _gameBeginning;

    private void OnEnable()
    {
        _gameBeginning.OnGameStarted += EnableJoystic;
    }

    private void OnDisable()
    {
        _gameBeginning.OnGameStarted -= EnableJoystic;
    }

    private void EnableJoystic()
    {
        _joystic.SetActive(true);
    }
}
