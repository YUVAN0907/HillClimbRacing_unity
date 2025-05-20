using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private bool isgrounded;
    public float jumpforce;
    public GameObject laser;
    private int playerdamage = 3;
    public static playercontroller instance;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JumpRide()
    {
        if(isgrounded)
        {
            rb.freezeRotation = true;
            rb.AddForce(new Vector3(0f, jumpforce));

        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            isgrounded = true;
        }

       
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            isgrounded = false;
        }


    }
    public void shoot()
    {
        soundmanager.instance.playgun();
        Vector3 pos = new Vector3(0f,1f,0f);
        Instantiate(laser,transform.position + pos, Quaternion.identity);
    }
    public void damage()
    {
        playerdamage = playerdamage - 1;
        UImanager.instance.UpdateLife(playerdamage);
        if(playerdamage == 0)
        {
            UImanager.instance.show();
            gameObject.SetActive(false);

        }
    }

}
