using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burger : MonoBehaviour
{
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
        if(other.gameObject.tag == "Player" && hit == false)
        {
            soundmanager.instance.playcatch();
            hit = true;
            UImanager.instance.UpdateScore(1);
            Destroy(gameObject);
        }
    }
}
