using System;
using UnityEngine;

public class GameBeginning : MonoBehaviour
{
    public event Action OnGameStarted;

    public void StartGame()
    {
        OnGameStarted?.Invoke();
    }
}
