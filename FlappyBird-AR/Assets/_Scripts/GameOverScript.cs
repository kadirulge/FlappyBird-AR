using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Ball")

        {

            PlayerDies();
        }


    }



    public void PlayerDies()
    {



        UnityEngine.SceneManagement.SceneManager.LoadScene(1);




    }
}
