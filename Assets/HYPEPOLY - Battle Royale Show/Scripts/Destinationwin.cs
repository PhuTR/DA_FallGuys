using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destinationwin : MonoBehaviour
{
    public GameObject roundOver;
    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().name == "InGame")
        {
                //SceneManager.LoadScene("EndGame");
                roundOver.SetActive(true);
                Time.timeScale = 0;
        }

    }
}
