using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class NewBehaviourScript : MonoBehaviour
{
    
    bool win;
    private float timerduration;
    public float timer;
    private bool timerunning = true;
    int minWait;
    int maxWait;
    float waittime;
    bool duelActive;
    

    
    
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(2f, 7f);
    }

    
    // Update is called once per frame
    void Update()
    {
        if (timerunning == false) return;

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            print(timer);
        }
        else
        {
            timer = 0;
            timerunning = false;
            transform.position = new Vector3(0, 0, 0);
        }

    }
}
