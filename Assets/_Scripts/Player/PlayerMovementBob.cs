using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBob : MonoBehaviour
{
    [SerializeField] private float horizontalStretchToSize = 1;
    [SerializeField] private float verticalStretchToSize = 1;
    [SerializeField] private float depthStretchToSize = 1;
    [SerializeField] private float animationTime = 2f; // Increase this to make it slower
    [SerializeField] private iTween.EaseType easeType = iTween.EaseType.easeInOutSine; // Smooth easing

    // Start is called before the first frame update
    void Start()
    {
        iTween.ScaleTo(gameObject, iTween.Hash(
            "x", horizontalStretchToSize,
            "y", verticalStretchToSize,
            "z", depthStretchToSize,
            "time", animationTime, // Slower animation time
            "looptype", iTween.LoopType.pingPong,
            "easetype", easeType)); // Smoother easing
    }

    // Update is called once per frame
    void Update()
    {

    }
}





