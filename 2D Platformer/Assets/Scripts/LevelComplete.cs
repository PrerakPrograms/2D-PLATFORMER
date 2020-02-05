using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
  public  KeyScript keyScript;
  public GameObject key;
    void Start()
    {
        keyScript = key.GetComponent<KeyScript>();

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Player"){
            CheckKey();
        }
        
    }
    public void CheckKey() { 
    if(keyScript.hasKey){
        SceneManager.LoadScene(4);
        Debug.Log("LevelComplete");
    }
    else
    {
        Debug.Log("Collect the key please");

    }
    }
}
