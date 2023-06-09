using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour

{
    public static int score = 0;

    public static int npcScore = 0;

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Score: " + score, scoreStyle);

        GUIStyle npcScoreStyle = new GUIStyle();
        npcScoreStyle.fontSize = 24;
        npcScoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 40, 200, 50), "NPC Score: " + npcScore, npcScoreStyle);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Cube")
        {
            GameController.npcScore--;
            collision.gameObject.SetActive(false);
        }
    }

}
