using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Level Snow")
        {
            FindObjectOfType<Controller>().stopMove();
            Invoke("LoadScene", 1);
        }
    }

    void LoadScene() {
        SceneManager.LoadScene(0);
    }
}
