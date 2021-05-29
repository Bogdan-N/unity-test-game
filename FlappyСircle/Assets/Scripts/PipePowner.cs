using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePowner : MonoBehaviour
{
    public float maxTime = 3;
    public GameObject pipe;
    public float hight; 
    private float timer = 0;

    void Start()
    {
        //GameObject newpipe = Instantiate(pipe);
        //newpipe.transform.position = transform.position + new Vector3(-7, Random.Range( -hight, hight), 0);
        //Destroy(newpipe, 9);
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(-8, Random.Range(-hight, hight), 0);
            Destroy(newpipe, 9);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
