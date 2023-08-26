using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Path : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i<transform.childCount;i++)
        {
            transform.GetChild(i).name = "Point"+i;
            if(i>0)
            {
                Debug.DrawLine(transform.GetChild(i).position,transform.GetChild(i-1).position,Color.yellow);
                //transform.GetChild(i).LookAt(transform.GetChild(i-1).position);
                
            }
        }
    }
}
