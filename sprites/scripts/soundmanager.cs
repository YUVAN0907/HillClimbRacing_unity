using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    private AudioSource blast, caught, gun, gameover;
    public AudioClip blastclip, gunclip, catchclip, gameoverclip;
    public static soundmanager instance;
     void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        blast = gameObject.AddComponent<AudioSource>();
        gun = gameObject.AddComponent<AudioSource>();
        gameover = gameObject.AddComponent<AudioSource>();
        caught = gameObject.AddComponent<AudioSource>();
        blast.clip = blastclip;
        gun.clip = gunclip;
        gameover.clip = gameoverclip;
        caught.clip = catchclip;
    }

    // Update is called once per frame
    public void playblast()
    {
        blast.Play();
    }
    public void playgameover()
    {
        gameover.Play();
    }
    public void playcatch()
    {
        caught.Play();
    }
    public void playgun()
    {
        gun.Play();
    }
}