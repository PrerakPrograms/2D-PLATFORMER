using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCounter : MonoBehaviour
{
    Text txt;
    public static bool isdead;
    public static int gemsamount;
    void Start()
    {

        txt = GetComponent<Text>();
    }

    void Update()
    {
  
            txt.text = "x" + gemsamount.ToString();
        
    }
}
