using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{
    public GameObject headPanel;
    public GameObject headPanel2;
    public GameObject headPanel3;
    public GameObject headPanel4;
    public GameObject headPanel5;
    public GameObject headPanel6;
    public GameObject headPanel7;
    public GameObject Help1;
    public GameObject Help2;
    public GameObject Start;
    public GameObject Wrong;
    public GameObject Right;



    public void OnClickPlay()
    {
        if (!headPanel.GetComponent<Animator>().enabled) headPanel.GetComponent<Animator>().enabled = true;
        else headPanel.GetComponent<Animator>().SetTrigger("In");
    }

    public void OnClickPlay2()
    {
        if (!headPanel2.GetComponent<Animator>().enabled) headPanel2.GetComponent<Animator>().enabled = true;
        else headPanel2.GetComponent<Animator>().SetTrigger("In2");
    }

    public void Shop1()
    {
        if (!headPanel3.GetComponent<Animator>().enabled) headPanel3.GetComponent<Animator>().enabled = true;
        else headPanel3.GetComponent<Animator>().SetTrigger("In3");
    }
    public void Shop2()
    {
        if (!headPanel4.GetComponent<Animator>().enabled) headPanel4.GetComponent<Animator>().enabled = true;
        else headPanel4.GetComponent<Animator>().SetTrigger("In4");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    
}
