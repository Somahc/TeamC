using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Creditbutton : MonoBehaviour
{

    public void onClick(){
        SceneManager.LoadScene("CreditGamen");
    }
    // public void delay(){
    //     Invoke("Click",1f);
    // }

    // //ボタンを押した時の処理
    // public void Click()
    // {
    //     //ログ出力
    //     Debug.Log("押したよ！");
    //     SceneManager.LoadScene("CreditGamen");
    // }
}
