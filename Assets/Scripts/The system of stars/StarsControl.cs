using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarsControl : MonoBehaviour
{
    public GameObject star1, star2, star3, star4, star5, star6;
    public static int open_star1, open_star2, open_star3, open_star4, open_star5, open_star6;
    void Start()
    {
        open_star1 = PlayerPrefs.GetInt("stars1", 1);
        open_star2 = PlayerPrefs.GetInt("stars2", 1);
        open_star3 = PlayerPrefs.GetInt("stars3", 1);
        open_star4 = PlayerPrefs.GetInt("stars4", 1);
        open_star5 = PlayerPrefs.GetInt("stars5", 1);
        open_star6 = PlayerPrefs.GetInt("stars6", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(open_star1 == 1)
        {
            star1.SetActive(false);
        }

        if (open_star1 == 2)
        {
            star1.SetActive(true);
        }

        if (open_star2 == 1)
        {
            star2.SetActive(false);
        }

        if (open_star2 == 2)
        {
            star2.SetActive(true);
        }

        if (open_star3 == 1)
        {
            star3.SetActive(false);
        }

        if (open_star3 == 2)
        {
            star3.SetActive(true);
        }

        if (open_star4 == 1)
        {
            star4.SetActive(false);
        }

        if (open_star4 == 2)
        {
            star4.SetActive(true);
        }

        if (open_star5 == 1)
        {
            star5.SetActive(false);
        }

        if (open_star5 == 2)
        {
            star5.SetActive(true);
        }
        if (open_star6 == 1)
        {
            star6.SetActive(false);
        }

        if (open_star6 == 2)
        {
            star6.SetActive(true);
        }

        // ===================


        if (CoinText.Coin >= 1)
        {
            openStar1();
        }

        if (CoinText.Coin >= 2)
        {
            openStar2();
        }

        if (CoinText.Coin >= 3)
        {
            openStar3();
        }
        if (CoinText.Coin >= 1)
        {
            openStar4();
        }

        if (CoinText.Coin >= 2)
        {
            openStar5();
        }

        if (CoinText.Coin >= 3)
        {
            openStar6();
        }
    }


    public void openStar1()
    {
        open_star1 = 2;
        PlayerPrefs.SetInt("stars1", open_star1);
    }

    public void openStar2()
    {
        open_star2 = 2;
        PlayerPrefs.SetInt("stars2", open_star2);
    }

    public void openStar3()
    {
        open_star3 = 2;
        PlayerPrefs.SetInt("stars3", open_star3);
    }

    public void openStar4()
    {
        open_star4 = 2;
        PlayerPrefs.SetInt("stars4", open_star4);
    }

    public void openStar5()
    {
        open_star5 = 2;
        PlayerPrefs.SetInt("stars5", open_star5);
    }

    public void openStar6()
    {
        open_star5 = 2;
        PlayerPrefs.SetInt("stars5", open_star5);
    }
}
