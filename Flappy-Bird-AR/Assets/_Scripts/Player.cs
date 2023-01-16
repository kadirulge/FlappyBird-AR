using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rB;
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    void Update()
    {


    }


    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Pipes")

        {

            PlayerDies();
        }


    }



    public void PlayerDies()
    {



        UnityEngine.SceneManagement.SceneManager.LoadScene(1);




    }

}
