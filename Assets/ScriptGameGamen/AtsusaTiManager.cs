using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AtsusaTiManager : MonoBehaviour
{
    // slider型宣言
    Slider atsusaSlider;

    // 暑さ値の最大値
    [SerializeField] int maxAtsusaTi = 100;

    // アイスをとったら減少する暑さ値
    [SerializeField] int kaihukuAtsusaTi = 20;


    // ゲームオーバーしたかのフラグ
    private bool isGameOver = false;

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
                // 暑さ値を1秒ごとに15ずつ増やす
                atsusaTi += Time.deltaTime * 15.0f;
            }
            
            // 暑さ値をゲージに反映
            atsusaSlider = GameObject.Find("Slider").GetComponent<Slider>();
            atsusaSlider.value = atsusaTi/100;
        }
    }

    public float GetAtsusaTi()
    {
        return atsusaTi;
    }

    public void SetAtsusaTi(float atsusaTi)
    {
        this.atsusaTi = atsusaTi;
    }

    public void KaihukuAtsusaTi()
    {   
        if(atsusaTi >= kaihukuAtsusaTi){
            this.atsusaTi -= kaihukuAtsusaTi;
        }else
        {
            this.atsusaTi = 0;
        }
    }
}
