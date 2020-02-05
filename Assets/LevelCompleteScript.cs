using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("IM UPDATING");
        if(GoalDetection.endgame == true){
            Debug.Log("endgame is true");
            this.enabled = true;
            this.GetComponent<TextMesh>().text = "Congratulations, you win with " + Golfer.score + " points";
        }*/
    }
}
