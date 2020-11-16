using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{

    public GameObject[] pages;
    public GameObject CurrentPage;
    public GameObject NextPage;
    public GameObject PreviousPage;

    public bool test;
    
    private void Start()
    {
        for(int i = 0; i < pages.Length ; i++)
        {
            if (pages[i] == pages[0])
            {
                pages[i].SetActive(true);
                CurrentPage = pages[i];
                NextPage = pages[i + 1];

            }
            else
            {
                pages[i].SetActive(false);
            }

        }

    }

    public void Next()
    {

        if (!test)
        {
            test = true;
        }

    }

    private void Update()
    {

        PageChange();
     
    }

    //public void Previous()
    //{
    //    for (int i = 0; i < pages.Length; i++)
    //    {
    //        if(pages[i] == pages[0])
    //        {
    //            pages[i].SetActive(false);
    //        }

    //    }
    //}

   void PageChange()
    {
        if (test)
        {
            for (int i = 0; i < pages.Length-1; i++)
            {
                PreviousPage = CurrentPage;
                PreviousPage.SetActive(false);

                CurrentPage = NextPage;
                CurrentPage.SetActive(true);
                //CurrentPage = NextPage;
                //NextPage = pages[i +1];

                //CurrentPage.SetActive(true);

                //Debug.Log(NextPage);
                test = false;
            }
        }
    }
}
