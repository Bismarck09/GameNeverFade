using UnityEngine;

public class EvaluationOfComputerClub : MonoBehaviour
{
    private bool _isGetComputer;

    public float ChooseLeaveReviewOrNot()
    {
        int coin = Random.Range(1, 3);

        if (coin == 1)
            return LeaveReview();
        else
            return 0;
    }

    public void GetComputer()
    {
        _isGetComputer = true;
    }

    private float LeaveReview()
    {
        if (_isGetComputer)
            return 0.1f;
        else
            return -0.1f;
    }
}

