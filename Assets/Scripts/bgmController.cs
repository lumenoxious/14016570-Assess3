using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmController : MonoBehaviour
{
    [SerializeField]
    private AudioClip introBGM;
    [SerializeField]
    private AudioClip normalBGM;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playBGMStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playBGMStart()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = introBGM;
        audio.Play();
        yield return new WaitForSeconds(introBGM.length);
        audio.clip = normalBGM;
        audio.Play();
        audio.loop = true;

    }
}
