using UnityEngine;

public class PaymentForNeonlightArea : MonoBehaviour
{
    private PaymentForNeonlight _paymentForNeonlight;

    private void Awake()
    {
        _paymentForNeonlight = GetComponent<PaymentForNeonlight>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
            _paymentForNeonlight.StartDecreasePrice();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
            _paymentForNeonlight.StopDecreasePrice();
    }
}
