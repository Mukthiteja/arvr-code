using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigerrun : MonoBehaviour
{
    Animator anim;
    AudioSource Audiosource;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        Audiosource=GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    public void Therun()
    {
        anim.SetTrigger("run");
        Audiosource.Play();
    }
}