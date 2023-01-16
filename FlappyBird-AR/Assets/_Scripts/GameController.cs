using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{


    [SerializeField]
    private GameObject HurdlePrefab;
    [SerializeField]
    private Transform HurdleParent;

    [SerializeField]
    private GameObject GameResetPanel;

    [SerializeField]
    private PlayerController playerController;

    void Start()
    {
        GameResetPanel.SetActive(false);

        StartCoroutine(SpawnHurdle());
    }

 


    IEnumerator SpawnHurdle()
    {
        yield return new WaitForSeconds(4.0f);
        while (true)
        {
            
            Instantiate(HurdlePrefab, HurdleParent, false);
            yield return new WaitForSeconds(3.0f);
        }
    }


  


    public void HandleGameOver()
    {
        playerController.EnablePlayerMovement = false;
        Time.timeScale = 0;
        GameResetPanel.SetActive(true);
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
