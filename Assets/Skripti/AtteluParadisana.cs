using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject IzmeraSlaideris;
    public GameObject IzmeraSlaideris2;

    public void izkritosais(int indekss)
    {
        if (indekss == 0)

            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (indekss == 1) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

    }


    public void mainitIzmeru()
    {
        float pasreizejaisIzmers = IzmeraSlaideris.GetComponent<Slider>().value;
        float pasreizejaisIzmers1 = IzmeraSlaideris2.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(2f * pasreizejaisIzmers1,pasreizejaisIzmers);
        mainigaisAttels.transform.localScale = new Vector2(2f * pasreizejaisIzmers,1f * pasreizejaisIzmers1);
    }
}
