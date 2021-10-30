using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ColorLogo : MonoBehaviour
{
    public Text textLogo;
    public bool color = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Thread.Sleep(1500);
        if(!color){
            textLogo.color = new Color(0,191,255);
            color = true;
        }else{
            textLogo.color = new Color(0,1,0);
            color = false;
        }
    }
}
