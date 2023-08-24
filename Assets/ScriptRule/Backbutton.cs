using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //ボタンを押した時の処理
    public void Click()
    {
        //ログ出力
        Debug.Log("押したよ！");
        SceneManager.LoadScene("Title");
    }
}
