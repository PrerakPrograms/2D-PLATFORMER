using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerDeath : MonoBehaviour
{
    int health=3;
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public Transform spawnpoint;
    int index;
    void Start()
    {
         index = Random.Range(1, 3);
    }

    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           health -= 1 ;
           HeatlhCheck();
           col.transform.position = spawnpoint.position;
        }
        if (col.gameObject.tag == "Barrel")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }

      public  void HeatlhCheck(){
             switch (health)
            {
                case 3:
                    h3.gameObject.SetActive(true);
                    h2.gameObject.SetActive(true);
                    h1.gameObject.SetActive(true);
                    break;
                case 2:
                    h3.gameObject.SetActive(false);
                    h2.gameObject.SetActive(true);
                    h1.gameObject.SetActive(true);
                    break;
                case 1:
                    h3.gameObject.SetActive(false);
                    h2.gameObject.SetActive(false);
                    h1.gameObject.SetActive(true);
                    break;
                case 0:
                    h3.gameObject.SetActive(false);
                    h2.gameObject.SetActive(false);
                    h1.gameObject.SetActive(false);
                    SceneManager.LoadScene(index);
                    
                    break;
                    
            }
        }
    }

    

