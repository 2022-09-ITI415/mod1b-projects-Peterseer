using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBreak : MonoBehaviour
{

    public bool bol;
    private static bool isHit;

    private void Awake()
    {
        print("这个球的目前状态是: " + bol);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Rigidbody>().IsSleeping() && bol==false)
        {
            print("没了！");
            Destroy(this.gameObject);
        }
    }
}
