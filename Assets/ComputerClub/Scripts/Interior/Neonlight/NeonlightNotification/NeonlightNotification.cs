using Cinemachine;
using UnityEngine;

public class NeonlightNotification : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _cameraNeonNotification;
    [SerializeField] private CameraSwitcher _cameraSwitcher;
    [SerializeField] private GameObject _buttonTapCoins;
    [SerializeField] private SpawnVisitors _spawnVisitors;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            OpenClub();
    }

    public void OpenClub()
    {
        _cameraSwitcher.ChangeCamera(_cameraNeonNotification);
        _buttonTapCoins.SetActive(true);
        _spawnVisitors.StartSpawn();

        gameObject.SetActive(false);
    }
}
