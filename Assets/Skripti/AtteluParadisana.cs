using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;

    public void izkritosais(int indekss)
    {
        if (indekss == 0)

            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (indekss == 1) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

    }
}
