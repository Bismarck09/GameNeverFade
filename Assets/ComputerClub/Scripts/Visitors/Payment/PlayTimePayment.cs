using UnityEngine;

public class PlayTimePayment : MonoBehaviour
{
    [SerializeField] private CoinsData _coinsData;
    [SerializeField] private Rating _rating;

    public void Pay(int amount)
    {
        _coinsData.AddCoin(amount * _rating.Multiplayer);
    }
}
