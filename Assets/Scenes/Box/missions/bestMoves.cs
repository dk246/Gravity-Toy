using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bestMoves : MonoBehaviour
{
    public Text best;
    public Text moves;
    private int levelCount;
    private string[] bestMv = new string[50];
    public dragBall count;
    // Start is called before the first frame update
    void Start()
    {
        levelCount = (SceneManager.GetActiveScene().buildIndex - 1);
        for (int x = 0; x < bestMv.Length; x++)
        {
            bestMv[x] = "move" + x.ToString();
            //PlayerPrefs.SetInt(bestMoves[x], 0);

        }

        moves.text = count.steps.ToString();
        for (int y = 0; y < bestMv.Length; y++)
        {

            if (levelCount == y + 1)
            {
                int mv = PlayerPrefs.GetInt(bestMv[y]);
                if (mv > count.steps || mv == 0)

                {

                    PlayerPrefs.SetInt(bestMv[y], count.steps);
                    best.text = PlayerPrefs.GetInt(bestMv[y]).ToString();
                }
                else
                {

                    //int mv2 = PlayerPrefs.GetInt(bestMv[y]);
                    PlayerPrefs.SetInt(bestMv[y], mv);
                    best.text = PlayerPrefs.GetInt(bestMv[y]).ToString();
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
