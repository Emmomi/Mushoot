using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sample_game : MonoBehaviour
{
    public Text point;
    static public int c=0,p=0, g=0, b=0;
    // Start is called before the first frame update
    void Start()
    {
        point.text= "c:"+c+"\np:" +p+"\ng:"+g+"\nb:"+b;
        
    }

    // Update is called once per frame
    void Update()
    {
        point.text = "c:" + c + "\np:" + p + "\ng:" + g + "\nb:" + b;
    }
}
