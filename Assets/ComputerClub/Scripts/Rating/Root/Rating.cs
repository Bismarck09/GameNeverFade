using UnityEngine;

public class Rating : MonoBehaviour
{
    private UIRating _ratingUI;

    private float _multiplayer;
    private float _standard;

    public float Multiplayer => _multiplayer;

    private void Awake()
    {
        _ratingUI = GetComponent<UIRating>();

        _multiplayer = 1;
        _ratingUI.ChangeRating(_multiplayer);
    }

    public void ChangeRating(float currentOfNewRating)
    {
        _multiplayer += currentOfNewRating;

        if (CheckRating(currentOfNewRating))
            _multiplayer = _standard;

        _ratingUI.ChangeRating(_multiplayer);
    }

    private bool CheckRating(float currentOfNewRating)
    {
        if (_multiplayer < 0.5f)
        {
            _standard = 0.5f;
            return true;
        }

        if (_multiplayer > 5)
        {
            _standard = 5;
            return true;
        }

        return false;
    }
}
