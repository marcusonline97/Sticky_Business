using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public KeyCode ResetButton;
    public GameObject[] EnterExitButtons;

    public EnterExitMenu[] EnterExitMenu;
    public Buyable buyable;
    public GameObject HoneyJar;

    float[] TimeScales = { 0, 1 };
    void Start()
    {

        for (int i = 0; i < EnterExitButtons.Length; i++)
        {
            EnterExitMenu[i] = EnterExitButtons[i].GetComponent<EnterExitMenu>();
        }

    }

    void Update()
    {
        PauseGame();
        ResetGame();

        if (buyable.ItemBought)
        {
            GameObject Jar = Instantiate(HoneyJar);
            Jar.transform.SetParent(GameObject.FindGameObjectWithTag("SpawnManager").transform, false);

        }

        void PauseGame()
        {
            for (int i = 0; i < EnterExitButtons.Length; i++)
            {
                if (EnterExitMenu[i].MenuActive)
                {
                    Time.timeScale = TimeScales[0];
                    break;
                }
                else
                {
                    Time.timeScale = TimeScales[1];

                }
            }
        }

        void ResetGame()
        {
            if (Input.GetKey(ResetButton))
            {
                PlayerPrefs.DeleteAll(); // Save this information
            }
        }
    }
}
