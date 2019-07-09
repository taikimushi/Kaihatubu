using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GameOver");
        SceneManager.LoadScene("GameOver");
    }
}
