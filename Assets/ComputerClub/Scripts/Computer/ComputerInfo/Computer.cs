using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] private int _priceForHour;

    public int PriceForHour => _priceForHour;
}
