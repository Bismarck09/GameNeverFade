using UnityEngine;

public class Evaluation : MonoBehaviour
{
    [SerializeField] private Rating _rating;

    private ExitOnMap _exitOnMap;

    private void Awake()
    {
        _exitOnMap = GetComponent<ExitOnMap>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out EvaluationOfComputerClub evaluationOfComputerClub))
        {
            _rating.ChangeRating(evaluationOfComputerClub.ChooseLeaveReviewOrNot());
            _exitOnMap.DestroyVisitor(evaluationOfComputerClub);
        }
            
    }
}
