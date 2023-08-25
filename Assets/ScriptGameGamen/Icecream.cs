using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecream : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("アイス取得");

            // AtsusaTiManagerオブジェクトを探して取得
            AtsusaTiManager atsusaTiManager = FindObjectOfType<AtsusaTiManager>();

            // アイスの取得で暑さ値を減らす
            if (atsusaTiManager != null)
            {
                atsusaTiManager.KaihukuAtsusaTi();
            }
            
            // アイスを取得したら消す
            Destroy(gameObject);
        }
    }
}
