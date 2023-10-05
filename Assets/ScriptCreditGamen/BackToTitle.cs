using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public void onClick(){
        SceneManager.LoadScene("title");
    }
}
