using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSEManager : MonoBehaviour
{
    public AudioClip jumpSE;
    public AudioClip iceSE;
    AudioSource audioSource;    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayJump(){
        audioSource.PlayOneShot(jumpSE);
    }

    public void PlayIce(){
        audioSource.PlayOneShot(iceSE);
    }
}
