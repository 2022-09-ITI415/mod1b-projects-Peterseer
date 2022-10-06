using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBreak : MonoBehaviour
{

    public bool bol = true;
    private static bool isHit;
    public static float bottomY = -20f;

    private void Awake()
    {
        print("State: " + bol);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.GetComponent<Rigidbody>().IsSleeping() || this.transform.position.y < bottomY) && bol == false)
        {
            print("Ã»ÁË£¡");
            Destroy(this.gameObject);
        }
    }
}
