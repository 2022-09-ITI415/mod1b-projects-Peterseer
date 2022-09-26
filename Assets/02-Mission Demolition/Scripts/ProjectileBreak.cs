using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBreak : MonoBehaviour
{

    private static bool bol;
    private static bool isHit;

    // Start is called before the first frame update
    void Start()
    {
        bol = this.GetComponent<Slingshot>().untouched;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Rigidbody>().IsSleeping() && bol==false)
        {
            print("√ª¡À£°");
            Destroy(this.gameObject);
        }
    }
}
