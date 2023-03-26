using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestinationCount : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.CurRank--;
    }
}
