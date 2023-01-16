using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Movementspeed;


    private RectTransform rectTransform;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        MovementFunction();

    }

    void MovementFunction()
    {

        rectTransform.localPosition = new Vector3(rectTransform.localPosition.x - Time.deltaTime * Movementspeed, rectTransform.localPosition.y, rectTransform.localPosition.z);
         
    }
}
