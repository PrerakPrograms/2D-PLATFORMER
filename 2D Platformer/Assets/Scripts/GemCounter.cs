using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCounter : MonoBehaviour
{
    pickup pkup;
    public GameObject gem;
    Text txt;
    public string str;
    void Start()
    {
        pkup = gem.GetComponent<pickup>();
        txt = GetComponent<Text>();
        str = pkup.gemscollected.ToString();
    }

    void Update()
    {
        txt.text = "x" + str;
    }
}
