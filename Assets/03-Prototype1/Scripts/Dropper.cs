using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject smallblock;
    public GameObject largeblock;
    public GameObject midblock;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    private Vector3 scaleChange, positionChange;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropBlock", 3f);
    }

    void DropBlock()
    {
        int r = Random.Range(1, 100);
        GameObject block = null;
        if(r>=1 && r<60)
        {
            block = Instantiate<GameObject>(largeblock);
        }
        else if(r >= 60 && r < 90)
        {
            block = Instantiate<GameObject>(midblock);
        }
        else
        {
            block = Instantiate<GameObject>(smallblock);
        }
        block.transform.position = transform.position;
        Invoke("DropBlock", secondsBetweenAppleDrops);
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
