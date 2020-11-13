using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject BeehiveEnterButton;
    EnterExitBeehive EnterExitBeehive;
    float[] TimeScales = { 0, 1 };
    void Start()
    {
        EnterExitBeehive = BeehiveEnterButton.GetComponent<EnterExitBeehive>();
    }

    void Update()
    {
        PauseGame();
    }

  void PauseGame()
    {
        if (EnterExitBeehive.BeehiveMenuActive)
        {
            Time.timeScale = TimeScales[0];
        }
        else
        {
            Time.timeScale = TimeScales[1];

        }
    }
}
