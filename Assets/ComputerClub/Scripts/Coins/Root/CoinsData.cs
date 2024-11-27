using System;
using UnityEngine;

public class CoinsData : MonoBehaviour
{
    [SerializeField] private DecreaseCostOfComputer _decreaseCostOfComputer;

    private float _numberOfCoins;

    public float NumberOfCoins => _numberOfCoins;

    public event Action<string, float> ChangedNumberOfCoins;


    private void OnEnable()
    {
        _decreaseCostOfComputer.DecreasedPrice += RemoveCoin;
    }

    private void OnDisable()
    {
        _decreaseCostOfComputer.DecreasedPrice -= RemoveCoin;
    }

    public void RemoveCoin(float coins)
    {
        if (coins <= _numberOfCoins)
        {
            _numberOfCoins -= coins;
            ChangedNumberOfCoins?.Invoke("-", coins);
        }
    }

    public void AddCoin(float coins)
    {
        _numberOfCoins += coins;
        ChangedNumberOfCoins?.Invoke("+", coins);
    }
}
