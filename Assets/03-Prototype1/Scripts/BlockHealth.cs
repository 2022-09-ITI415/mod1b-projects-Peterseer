using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockHealth : MonoBehaviour
{
    public int health =1;
    public int point;
    public TMP_Text scoreGT;
    public static float bottomY = -20f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            // if so, set goalMet = true
            //Destroy(other.gameObject);
            health--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreGT = GameObject.Find("ShootScore").GetComponent<TMP_Text>();
        //scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if(this.health<=0)
        {
            int score = int.Parse(scoreGT.text);
            score += point;
            scoreGT.text = score.ToString();
            Destroy(this.gameObject);
        }

        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
