using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSetup : MonoBehaviour
{
    public float minSpace;
    public float maxSpace;
    public GameObject top;
    public GameObject bottom;
    private GameObject renTop;
    private GameObject renBottom;
    void Start()
    {
        setup();
    }

    void Update()
    {

    }
    void setup()
    {
        renTop = top.GetComponent<GameObject>();
        renBottom = bottom.GetComponent<GameObject>();

        float temp = Random.Range(-3.3f + minSpace, 5);
        top.transform.position = new Vector2(transform.position.x, temp);
        float temp2 = Random.Range(minSpace, maxSpace);
        bottom.transform.position = new Vector2(transform.position.x, temp - temp2);

    }
    void OnBecameInvisible()
    {

        enabled = false;

    }

}
