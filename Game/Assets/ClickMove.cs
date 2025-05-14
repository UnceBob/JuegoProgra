using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public int speed;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyMove.protawin = false;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.position = new Vector3(0, 0, 0);
           EnemyMove.protawin = true;
        }

        if (EnemyMove.protawin == true)
        {
           
        }

    }
}
