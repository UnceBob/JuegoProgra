using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public int speed;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyMove.protaclick = false;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.Space))
        {
            
            EnemyMove.protaclick = true;
        }
        
        /*
        if (EnemyMove.protawin == true && EnemyMove.winwindow == false)
        {
            EnemyMove.protawin = false;
            print("TOO SOON");
           
        }
        */

    }
}
