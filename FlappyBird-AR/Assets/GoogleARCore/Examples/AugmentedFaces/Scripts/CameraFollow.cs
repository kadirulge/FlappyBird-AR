using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        offset = transform.position - Player.transform.position;

        
    }

    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }


    void Update()
    {
       

    }


    public GameObject Player;
    Vector3 offset;
}

