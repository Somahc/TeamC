using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeClear : MonoBehaviour
{
    public void finish()
    {
        Invoke("NextScene",1f);
    }
    public void NextScene()
    {
        //読み込むシーンの名前を指定
        SceneManager.LoadScene("GameGamen");
    }
}
