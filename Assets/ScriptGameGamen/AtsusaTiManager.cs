using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AtsusaTiManager : MonoBehaviour
{

    // 暑さ値の最大値
    [SerializeField] int maxAtsusaTi = 100;

    // ゲームオーバーしたかのフラグ
    private bool isGameOver = false;

    // 暑さ値の表示用テキスト
    [SerializeField] Text atsusaTiText;

    // 暑さ値
    private float atsusaTi;

    void Update()
    {
        if(!isGameOver){

            if(atsusaTi >= maxAtsusaTi)
            {
                Debug.Log("暑さ値が最大値に達したのでゲームオーバー");
                isGameOver = true;
                SceneManager.LoadScene("GameOver");
            }else
            {
                // 暑さ値を1秒ごとに0.01ずつ増やす
                atsusaTi += Time.deltaTime + 0.01f;
            }
            atsusaTiText.text = $"暑さ値:{atsusaTi.ToString("F2")}";
        }
    }
}
