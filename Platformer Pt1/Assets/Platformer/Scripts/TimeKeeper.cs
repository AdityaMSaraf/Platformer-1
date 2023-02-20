using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Time\n" + Math.Floor(500.00f - Time.realtimeSinceStartup);
    }
}
