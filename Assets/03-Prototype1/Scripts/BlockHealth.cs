using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour
{
    public int health;
    public static float bottomY = -20f;

    void OnTriggerEnter(Collider other)
    {
        // when the trigger is hit by something
        // check to see if it's a Projectile 
        if (other.gameObject.tag == "Projectile")
        {
            // if so, set goalMet = true
            this.health--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.health<=0)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
