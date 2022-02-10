using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseScript : MonoBehaviour
{
    [SerializeField]
    Button BtnClose;

    // Start is called before the first frame update
    void Start()
    {
        BtnClose.onClick.AddListener(ExitFunct);
    }

    void ExitFunct()
    {
        Debug.Log("Button pressed");
        Application.Quit();
    }
}
