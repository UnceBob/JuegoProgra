using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices.WindowsRuntime;

public class EnemyMove : MonoBehaviour
{

   public static bool protaclick;
   public static bool enemywin;
    public static bool winwindow;
    public float timer;
    public float RandomRangeA;
    public float RandomRangeB;
    public float drawtime;
    private bool drawtimerunning;
    private bool timerunning = true;
    public GameObject signal;
    public GameObject FLASH;
    public GameObject ButtonNextLevel;
    public GameObject ButtonRetryLevel;
    public GameObject ProtaIdle;
    public GameObject ProtaAttack;
    public GameObject ProtaStun;
    public GameObject EnemyIdle;
    public GameObject EnemyAttack;
    public GameObject EnemyStun;
    public TMP_Text contadordeframes;
    public float timerdelbotonfinal;

    bool duelActive;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(RandomRangeA , RandomRangeB);
        enemywin = false;
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            
        }
        else
        {
           
            timerunning = false;
            transform.localScale = new Vector3(3,3,3);
            signal.SetActive(true);
        }
        if (protaclick == true && winwindow == false)
        {
            print("TOO SOON");
            protaclick = false;
            enemywin = true;
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

            ProtaIdle.SetActive(false);
            ProtaStun.SetActive(true);
            EnemyIdle.SetActive(false);
            EnemyAttack.SetActive(true);

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
            
            
            ProtaIdle.SetActive(false);
            ProtaAttack.SetActive(true);
            EnemyIdle.SetActive(false);
            EnemyStun.SetActive(true);

            signal.SetActive(false);


            timerdelbotonfinal -= Time.deltaTime;
            if (timerdelbotonfinal < 0)
            {
            ButtonNextLevel.SetActive(true);
            }

           }
            
        contadordeframes.text = drawtime.ToString("F2");



    }
    
}
