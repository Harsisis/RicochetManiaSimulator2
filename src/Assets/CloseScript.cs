using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseScript : MonoBehaviour
{

    Button BtnClose;
    Button BtnQuit;

    // Start is called before the first frame update
    void Start()
    {
        BtnClose = GameObject.Find("BtnClose").GetComponent<Button>();
        BtnClose.onClick.AddListener(ExitFunct);

        BtnQuit = GameObject.Find("BtnQuit").GetComponent<Button>();
        BtnQuit.onClick.AddListener(ExitFunct);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitFunct()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
    }
}
