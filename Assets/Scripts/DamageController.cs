using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
