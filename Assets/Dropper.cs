using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject applePrefab;
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
        GameObject block = Instantiate<GameObject>(blockPrefab);
        block.transform.position = transform.position;
        Invoke("DropBlock", secondsBetweenAppleDrops);
    }

    void blockgenerator()
    {
        int r = Random.Range(1, 3);
        bool isHero = false;//(Random.Range(0, 2) == 1);
        if(r==1)
        {
            scaleChange = new Vector3(1f, 1f, 0f);
            this.transform.localScale.x += scaleChange;

        }
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
