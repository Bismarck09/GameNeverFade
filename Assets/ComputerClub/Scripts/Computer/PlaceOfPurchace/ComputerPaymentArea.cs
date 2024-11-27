using System;
using UnityEngine;

public class ComputerPaymentArea : MonoBehaviour
{
    public event Action EnteredZone;
    public event Action CameOutZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
            EnteredZone?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
            CameOutZone?.Invoke();
    }
}
