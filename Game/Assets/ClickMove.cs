using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public int speed;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove.protawin = false;

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
