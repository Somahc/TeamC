using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void NextScene()
    {
        //読み込むシーンの名前を指定
        SceneManager.LoadScene("GameGamen");
    }
}
