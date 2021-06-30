using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.1f, 0, 0));
        Vector3 pos = transform.position;
        if (pos.x>-1&&pos.x < 1) {
            if (Input.GetKey(KeyCode.A)) {
                Destroy(mine);
                if (pos.x < 1 && pos.x > 0.7f|| pos.x < -0.7f && pos.x > -1)
                {
                    sample_game.b++;
                    sample_game.c = 0;
                }
                else if (pos.x <= 0.7f && pos.x > 0.4f|| pos.x <-0.4f  && pos.x >= -0.7f)
                {
                    sample_game.g++;
                    sample_game.c++;
                }
                else {
                    sample_game.p++;
                    sample_game.c++;
                }
            }
        }
        else if (pos.x < -2)
        {
            Destroy(mine);
            sample_game.b++;
            sample_game.c = 0;
        }
    }
}
