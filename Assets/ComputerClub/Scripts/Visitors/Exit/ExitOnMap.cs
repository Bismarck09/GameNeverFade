using UnityEngine;

public class ExitOnMap : MonoBehaviour
{
    public void DestroyVisitor(EvaluationOfComputerClub evaluationOfComputerClub)
    {
        Destroy(evaluationOfComputerClub.gameObject);
    }
}
