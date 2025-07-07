using System;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    
    [SerializeField] private InputReader inputReader;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputReader.MovementEvent += HandleMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        inputReader.MovementEvent -= HandleMove;
    }

    private void HandleMove(Vector2 movementInput)
    {
        // Handle the movement input here
        Debug.Log($"Movement Input: {movementInput}");
    }
}
