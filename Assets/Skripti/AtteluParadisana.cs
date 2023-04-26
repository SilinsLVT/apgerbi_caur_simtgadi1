﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject IzmeraSlaideris;

    public void izkritosais(int indekss)
    {
        if (indekss == 0)

            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (indekss == 1) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

    }


    public void mainitGarumu()
    {

        float pasreizejaisIzmers = IzmeraSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);

    }
    public void mainitPlatumu()
    {

        float pasreizejaisIzmers = IzmeraSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);

    }
}
