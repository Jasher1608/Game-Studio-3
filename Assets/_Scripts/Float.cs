using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    [SerializeField] private float floatSpeed = 1f; // Speed of floating
    [SerializeField] private float floatHeight = 2f; // Height of floating

    private Vector2 startPos;

    void Start()
    {
        // Store the starting position in 2D
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the object's position, preserving the X position
        transform.position = new Vector2(transform.position.x, newY);
    }
}