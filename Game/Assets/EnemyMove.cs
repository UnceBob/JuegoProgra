using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class EnemyMove : MonoBehaviour
{

   public static bool protawin;
   public static bool enemywin;
    public static bool winwindow;
    public float timer;
    public float drawtime;
    private bool drawtimerunning;
    private bool timerunning = true;
    

    bool duelActive;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(2f, 5f);
        drawtime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemywin == false && protawin == false)
        {
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            
        }
        else
        {
            timer = 0;
            timerunning = false;
            transform.position = new Vector3(4, 1, 0);
        }
        if (timerunning == false)
        {
            draw();
        }

    }
        void draw()
    {
        drawtimerunning = true;
        if (drawtime > 0)
        {
            drawtime -= Time.deltaTime;
            print("AHORA");
            winwindow = true;
        }
        else
        {
            drawtime = 0;
            drawtimerunning = false;
            transform.position = new Vector3(0, 0, 0);

           if (drawtimerunning == false && protawin == false)
            {
                enemywin = true;
            }


        }
           if(winwindow == true && protawin == true)
            {
                enemywin = false;
                print("Ganaste pendejo");
            }
             if (enemywin == true)
            {
                print("gano el malo");
                winwindow = false;
            }

       
        
    }

}
