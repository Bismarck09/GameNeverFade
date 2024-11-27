using UnityEngine;
using UnityEngine.UI;

public class UIRating : MonoBehaviour
{
    [SerializeField] private Image _ratingImage;

    // �.�. ���� FillAmount �� 0 �� 1, � ��� ������� �� 1 �� 5, � ���� ������� �� 5.
    public void ChangeRating(float newRating)
    {
        _ratingImage.fillAmount = newRating / 5;
    }
}
