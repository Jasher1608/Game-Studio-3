using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBob : MonoBehaviour
{
    [SerializeField] private float horizontalStretchToSize = 1;
    [SerializeField] private float verticalStretchToSize = 1;
    [SerializeField] private float depthStretchToSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("x", horizontalStretchToSize, "y", verticalStretchToSize, "z", depthStretchToSize, "time", 0.9, "looptype", iTween.LoopType.pingPong));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
