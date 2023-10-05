using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShototsuManager : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("衝突した。");
            SceneManager.LoadScene("GameOver");

        }
    }
}
