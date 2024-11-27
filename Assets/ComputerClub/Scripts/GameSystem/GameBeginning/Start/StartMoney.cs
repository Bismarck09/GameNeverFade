using UnityEngine;

public class StartMoney : MonoBehaviour
{
    [SerializeField] private GameBeginning _gameBeginning;
    [SerializeField] private CoinsData _coinsData;

    private float _startCoins = 500000;

    private void OnEnable()
    {
        _gameBeginning.OnGameStarted += GiveStartCoins;
    }

    private void OnDisable()
    {
        _gameBeginning.OnGameStarted -= GiveStartCoins;
    }

    private void GiveStartCoins()
    {
        _coinsData.AddCoin(_startCoins);
    }
}
