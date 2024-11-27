using UnityEngine;

public class FreeComputers : MonoBehaviour
{
    private Vector3 _targetToMove;
    private float _offset = 0.55f;

    public bool IsFree;

    public void ChangeState(bool state)
    {
        IsFree = state;
    }

    public Vector3 GetTagetToMove()
    {
        _targetToMove = new Vector3(transform.position.x - _offset, transform.position.y, transform.position.z - _offset);
        return _targetToMove;
    }
}
