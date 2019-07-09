using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("game scene");
        }
        
    }
}
