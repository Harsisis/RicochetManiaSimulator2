using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeGaletColor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject galet;

    Button BtnRed;
    Button BtnGreen;
    Button BtnBlue;
    Button BtnWhite;
    Button BtnBlack;

    Renderer galetRenderer;
    void Start()
    {
        galetRenderer = galet.GetComponent<Renderer>();

        BtnRed = GameObject.Find("BtnRed").GetComponent<Button>();
        BtnGreen = GameObject.Find("BtnGreen").GetComponent<Button>();
        BtnBlue = GameObject.Find("BtnBlue").GetComponent<Button>();
        BtnWhite = GameObject.Find("BtnWhite").GetComponent<Button>();
        BtnBlack = GameObject.Find("BtnBlack").GetComponent<Button>();

        BtnRed.onClick.AddListener(ChangeRed);
        BtnBlue.onClick.AddListener(ChangeBlue);
        BtnGreen.onClick.AddListener(ChangeGreen);
        BtnWhite.onClick.AddListener(ChangeWhite);
        BtnBlack.onClick.AddListener(ChangeBlack);
    }

    void ChangeRed()
    {
        if (galet != null)
        {
            galetRenderer.material.SetColor("_Color", Color.red);
        }
    }

    void ChangeBlue()
    {
        if (galet != null)
        {
            var galetRenderer = galet.GetComponent<Renderer>();
            galetRenderer.material.SetColor("_Color", Color.blue);
        }
    }

    void ChangeGreen()
    {
        if (galet != null)
        {
            var galetRenderer = galet.GetComponent<Renderer>();
            galetRenderer.material.SetColor("_Color", Color.green);
        }
    }

    void ChangeWhite()
    {
        if (galet != null)
        {
            
            galetRenderer.material.SetColor("_Color", Color.white);
        }
    }

    void ChangeBlack()
    {
        if (galet != null)
        {
            var galetRenderer = galet.GetComponent<Renderer>();
            galetRenderer.material.SetColor("_Color", Color.black);
        }
    }


}
