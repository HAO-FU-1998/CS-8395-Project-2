using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class testvb : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        text1.SetActive(true);
        text2.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour Vb)
    {
        text1.SetActive(true);
        text2.SetActive(false);
    }

}
