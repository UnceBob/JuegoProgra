using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices.WindowsRuntime;

public class EnemyMove : MonoBehaviour
{

   public static bool protaclick;
   public static bool enemywin;
   public static bool toosoon;
    public static bool winwindow;
    public float timer;
    public float RandomRangeA;
    public float RandomRangeB;
    public float drawtime;
    private bool drawtimerunning;
    private bool timerunning = true;
   
    public GameObject signal;
    public GameObject FLASH;
    public GameObject Strike;
    public GameObject ButtonNextLevel;
    public GameObject ButtonRetryLevel;
    public GameObject ProtaIdle;
    public GameObject ProtaAttack;
    public GameObject ProtaStun;
    public GameObject EnemyIdle;
    public GameObject EnemyAttack;
    public GameObject EnemyStun;

    public GameObject TUTO;
    public GameObject LetreroTOOSOON;
    public GameObject LetreroYOUWIN;
    public GameObject LetreroYOULOSE;

    public float timerdelbotonfinal;

    bool duelActive;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(RandomRangeA , RandomRangeB);
        enemywin = false;
        toosoon = false;
        Strike.SetActive(false);

        print(winwindow);
        print(protaclick);
        print(timerunning);
        print(enemywin);
        print(drawtimerunning);

        //tru tru tru fal fal
        winwindow = false;
        protaclick = false;
        timerunning = true;
        enemywin = false;
        drawtimerunning = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            
        }

        else if (timer <= 0 && toosoon == false)
        {
           
            timerunning = false;
            
            signal.SetActive(true);
            FLASH.SetActive(true);
        }
        if (protaclick == true && winwindow == false)
        {
            print("TOO SOON");
            protaclick = false;
            enemywin = true;
            Strike.SetActive(true);

            ProtaIdle.SetActive(false);
            ProtaStun.SetActive(true);
            EnemyIdle.SetActive(false);
            EnemyAttack.SetActive(true);

            TUTO.SetActive(false);
            LetreroTOOSOON.SetActive(true);
            signal.SetActive(false);
        }

        if (timerunning == false && enemywin == false)
        {
            draw();
        }

        if (enemywin == true)
        {
            timerdelbotonfinal -= Time.deltaTime;
            if (timerdelbotonfinal < 0)
            {
                ButtonRetryLevel.SetActive(true);
               
            }
        }
    }
        public void  draw()
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
           
            
        }

          
        if (drawtimerunning == false && protaclick == false)
            {
                enemywin = true;
            } 
        
        if (enemywin == true)
        {
          print("YOU LOSE");
          winwindow = false;
            Strike.SetActive(true);

            ProtaIdle.SetActive(false);
            ProtaStun.SetActive(true);
            EnemyIdle.SetActive(false);
            EnemyAttack.SetActive(true);

            TUTO.SetActive(false);

            LetreroYOULOSE.SetActive(true);
            signal.SetActive(false);


            timerdelbotonfinal -= Time.deltaTime;
            if (timerdelbotonfinal < 0)
            {
                ButtonRetryLevel.SetActive(true);
                timerdelbotonfinal -= Time.deltaTime;
            }
            
        }

           if(winwindow == true && protaclick == true)
           {
            enemywin = false;
            print("YOU WIN");
            
            
            Strike.SetActive(true);
      
            ProtaIdle.SetActive(false);
            ProtaAttack.SetActive(true);
            EnemyIdle.SetActive(false);
            EnemyStun.SetActive(true);

            TUTO.SetActive(false);

            signal.SetActive(false);
            LetreroYOUWIN.SetActive(true);


            timerdelbotonfinal -= Time.deltaTime;
            if (timerdelbotonfinal < 0)
            {
            ButtonNextLevel.SetActive(true);
            }

           }
            
        



    }
    
}
