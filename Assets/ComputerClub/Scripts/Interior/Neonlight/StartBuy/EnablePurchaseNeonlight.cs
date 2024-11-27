using UnityEngine;

public class EnablePurchaseNeonlight : MonoBehaviour
{
    [SerializeField] private GameObject[] _neonlightObjects;

    public void EnablePurchase()
    {
        for (int i = 0; i < _neonlightObjects.Length; i++)
        {
            _neonlightObjects[i].SetActive(true);
        }
    }
}
