using UnityEngine;

public class PlayerMoveAnimation : MonoBehaviour
{
    private const string WALK_ANIMATION = "IsWalking";

    [SerializeField] private Animator _animator;

    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        SwitchAnimation();
    }

    private void SwitchAnimation()
    {
        _animator.SetBool(WALK_ANIMATION, _playerMovement.IsMovement);
    }
}
