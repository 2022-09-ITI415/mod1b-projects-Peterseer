using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBreak : MonoBehaviour
{

    private static bool bol;
    // Start is called before the first frame update
    void Start()
    {
        bol = this.GetComponent<Slingshot>().aimingMode;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Rigidbody>().IsSleeping() && bol==false)
        {
            Destroy(this.gameObject);
        }
    }
}
