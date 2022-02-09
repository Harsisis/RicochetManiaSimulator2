using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartScript : MonoBehaviour
{
    TMP_Text TxtTitle;
    Button BtnStart;
    Button BtnClose;

    GameObject sphere;

    GameObject BtnRed;
    GameObject BtnGreen;
    GameObject BtnBlue;
    GameObject BtnBlack;
    GameObject BtnWhite;
    GameObject BtnSend;
    GameObject BtnQuit;

    GameObject SliderScaleX;
    GameObject SliderScaleY;
    GameObject SliderScaleZ;

    void Start()
    {
        BtnStart = GameObject.Find("BtnStart").GetComponent<Button>();
        BtnStart.onClick.AddListener(SwitchGameScene);
        BtnClose = GameObject.Find("BtnClose").GetComponent<Button>();
        TxtTitle = GameObject.Find("TxtTitle").GetComponent<TMP_Text>();

        sphere = GameObject.Find("Galet");

        GameObject.Find("BtnClose").SetActive(true);
        GameObject.Find("BtnStart").SetActive(true);
        TxtTitle.enabled = true;

        BtnRed = GameObject.Find("BtnRed");
        BtnRed.SetActive(false);
        BtnGreen = GameObject.Find("BtnGreen");
        BtnGreen.SetActive(false);
        BtnBlue = GameObject.Find("BtnBlue");
        BtnBlue.SetActive(false);
        BtnBlack = GameObject.Find("BtnBlack");
        BtnBlack.SetActive(false);
        BtnWhite = GameObject.Find("BtnWhite");
        BtnWhite.SetActive(false);
        BtnSend = GameObject.Find("BtnSend");
        BtnSend.SetActive(false);
        BtnQuit = GameObject.Find("BtnQuit");
        BtnQuit.SetActive(false);

        SliderScaleX = GameObject.Find("SliderScaleX");
        SliderScaleX.SetActive(false);
        SliderScaleY = GameObject.Find("SliderScaleY"); 
        SliderScaleY.SetActive(false);
        SliderScaleZ = GameObject.Find("SliderScaleZ"); 
        SliderScaleZ.SetActive(false);

        sphere.SetActive(false);

    }

    void Update()
    {
        
    }

    void SwitchGameScene()
    {

        // hide main menu
        GameObject.Find("BtnClose").SetActive(false);
        GameObject.Find("BtnStart").SetActive(false);
        TxtTitle.enabled = false;

        // move galet
        BtnRed.SetActive(true);
        BtnGreen.SetActive(true);
        BtnBlue.SetActive(true);
        BtnBlack.SetActive(true);
        BtnWhite.SetActive(true);
        BtnSend.SetActive(true);

        SliderScaleX.SetActive(true);
        SliderScaleY.SetActive(true);
        SliderScaleZ.SetActive(true);

        sphere.SetActive(true);


    }
}
