using UnityEngine;

public class TapCoins : MonoBehaviour
{
    [SerializeField] private CoinsData _coinsData;
    [SerializeField] private Rating _rating;

    private float _numberOfCoinsForTap = 50;

    public void Tap()
    {
        _coinsData.AddCoin(_numberOfCoinsForTap * _rating.Multiplayer);
    }
}
