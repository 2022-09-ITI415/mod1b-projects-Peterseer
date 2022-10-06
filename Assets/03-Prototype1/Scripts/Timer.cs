using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public TMP_Text Endscore;
    TMP_Text gt;

    private void Awake()
    {
        gt = this.GetComponent<TMP_Text>();
        timeRemaining = 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Endscore = GameObject.Find("EndScore").GetComponent<TMP_Text>();
        GameObject.Find("EndScore").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gt.text = timeRemaining.ToString();
        Endscore.text = "Your Score is: "+ GameObject.Find("ShootScore").GetComponent<TMP_Text>().text;
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            gt.text = "0";
            Debug.Log("Time has run out!");
            GameObject.Find("EndScore").SetActive(true);
            return;
        }
    }
}
