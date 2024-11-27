using System;
using System.Collections;
using UnityEngine;

public class PaymentForNeonlight : MonoBehaviour
{
    [SerializeField] private GameObject _neonlight;
    [SerializeField] private CoinsData _coins;
    [SerializeField] private float _priceOfNeonlight;

    private PaymentForNeonlightText _paymentForNeonlightText;

    private Coroutine _decreasePriceCoroutine;
    private float _currentPaymentAmount;
    private float _decreaseMultiplier;
    private bool _isOverpaymend;

    private void Awake()
    {
        _paymentForNeonlightText = GetComponent<PaymentForNeonlightText>();
    }

    public void StartDecreasePrice()
    {
        _currentPaymentAmount = 0;
        _isOverpaymend = false;

        _decreasePriceCoroutine = StartCoroutine(DecreasePrice(_coins.NumberOfCoins));
    }

    public void StopDecreasePrice()
    {
        StopCoroutine(_decreasePriceCoroutine);
        _coins.RemoveCoin(_currentPaymentAmount);
        _currentPaymentAmount = 0;
    }

    private void CheckOverpayment()
    {
        if (_currentPaymentAmount >= _priceOfNeonlight)
        {
            _currentPaymentAmount = _priceOfNeonlight;
            _isOverpaymend = true;

            CheckNeonlightBuy();
        }
    }

    private IEnumerator DecreasePrice(float coins)
    {
        _decreaseMultiplier = 1;

        while (coins > _currentPaymentAmount)
        {
            if (_isOverpaymend)
                yield break;

            _currentPaymentAmount += Convert.ToInt32(_decreaseMultiplier);

            _paymentForNeonlightText.ChangePriceText(_priceOfNeonlight - _currentPaymentAmount);

            yield return new WaitForSeconds(0.05f / _decreaseMultiplier);
            _decreaseMultiplier += 5;

            CheckOverpayment();
        }

        if (!(_currentPaymentAmount == _priceOfNeonlight))
            EquateCurrentPaymentAmount(coins);
    }

    private void EquateCurrentPaymentAmount(float coins)
    {
        _currentPaymentAmount = coins;
        _coins.RemoveCoin(_currentPaymentAmount);

        _paymentForNeonlightText.ChangePriceText(_priceOfNeonlight - coins);
        _currentPaymentAmount = 0;
    }

    private void CheckNeonlightBuy()
    {
        if (_currentPaymentAmount == _priceOfNeonlight)
        {
            _coins.RemoveCoin(_currentPaymentAmount);

            _neonlight.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
