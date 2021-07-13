using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sample_game : MonoBehaviour
{
    public Text point;
    static public int c=0,p=0, g=0, b=0,score=0;
    // Start is called before the first frame update
    void Start()
    {
        point.text= "c:"+c+"\np:" +p+"\ng:"+g+"\nb:"+b;
        
    }

    // Update is called once per frame
    void Update()
    {
        score = Score();
        point.text = "score:"+score+"\nc:" + c + "\np:" + p + "\ng:" + g + "\nb:" + b;
    }
    int Score() {
        int point = 0,bornas=0;
        bornas = c;
        point = p*50+g*25+bornas;
        return point;
    }
}
