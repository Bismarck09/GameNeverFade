using UnityEngine;

public class NextSlide : MonoBehaviour
{
    private GameObject[] _currentSlide;

    public void SwitchSlide(GameObject[] slides)
    {
        if (_currentSlide != null)
            TurnOffSlides(_currentSlide);

        _currentSlide = slides;
        TurnOnSlides(_currentSlide);
    }

    private void TurnOnSlides(GameObject[] slides)
    {
        foreach (GameObject slide in slides)
        {
            slide.SetActive(true);
        }
    }

    private void TurnOffSlides(GameObject[] slides)
    {
        foreach (GameObject slide in slides)
        {
            slide.SetActive(false);
        }
    }
}
