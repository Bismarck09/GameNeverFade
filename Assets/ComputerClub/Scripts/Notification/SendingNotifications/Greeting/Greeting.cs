using UnityEngine;

public class Greeting : MonoBehaviour
{
    [SerializeField] private GameObject _backgroundNotification;
    [SerializeField] private GameObject _resume;
    [SerializeField] private GameObject[] _slides;

    private NextSlide _nextSlide;

    private int _currentSlide;

    private void Awake()
    {
        _nextSlide = GetComponent<NextSlide>();

        _backgroundNotification.SetActive(true);
        _resume.SetActive(true);

        EnableGreeting();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _currentSlide != _slides.Length - 2)
        {
            _currentSlide++;
            EnableGreeting();
        }
    }

    private void EnableGreeting()
    {
        if (CheckLastSlide(_currentSlide, _slides.Length))
            return;

        _nextSlide.SwitchSlide(new GameObject[] { _slides[_currentSlide] });
        
    }

    private bool CheckLastSlide(int currentSlide, int numberOfSlide)
    {
        if (currentSlide == numberOfSlide - 2)
        {
            _nextSlide.SwitchSlide(new GameObject[] { _slides[currentSlide], _slides[currentSlide + 1] });
            _resume.SetActive(false);
            return true;
        }

        return false;
    }
}
