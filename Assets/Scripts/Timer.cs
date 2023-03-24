using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public GameObject can2;
    public float dBL;
    private float tE = 0;

    // Update is called once per frame
    void Update()
    {
        tE += Time.deltaTime;
        if (tE > dBL)
        {
            Destroy(gameObject);
            can2.SetActive(true);
        }
    }
}