using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public void onClick(){
        Invoke("NextScene",1f);
    }
    public void NextScene()
    {
        //読み込むシーンの名前を指定
        SceneManager.LoadScene("title");
    }
}
