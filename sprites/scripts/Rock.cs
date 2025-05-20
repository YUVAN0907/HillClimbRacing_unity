using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject rockexpo;
    private bool hit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && hit == false )
        {
            hit = true;
            playercontroller.instance.damage();
            Instantiate(rockexpo,transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        if (other.gameObject.tag == "laser")
        {
            soundmanager.instance.playblast();
            Instantiate(rockexpo, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
