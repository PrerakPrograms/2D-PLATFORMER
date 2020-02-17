using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset;
    public GameObject projectile;
    public Transform shotpoint;
    private float timebtwshots;
    public float starttime;
    void Start()
    {

    }


    void Update()
    {
        Vector3 Difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(Difference.y, Difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (timebtwshots <= 0)
        {

            if (Input.GetMouseButton(0))
            {
                Instantiate(projectile, shotpoint.position, transform.rotation);
                timebtwshots = starttime;
            }
            else
            {
                timebtwshots -= Time.deltaTime;
            }
        }
    }
}