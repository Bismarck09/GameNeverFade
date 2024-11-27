using System.Collections.Generic;
using UnityEngine;

public class AllComputers : MonoBehaviour
{
    private List<Computer> _computers;

    public int Computers => _computers.Count;

    private void Start()
    {
        _computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        _computers.Add(computer);
    }
}
