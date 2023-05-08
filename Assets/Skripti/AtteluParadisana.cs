using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject GarumaSlaideris;
    public GameObject PlatumaSlaideris;

    public void izkritosais(int indekss)
    {
        if (indekss == 0)

            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (indekss == 1) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

    }



    public void mainitLielumu()
    {
        float pasreizejaisIzmers1 = PlatumaSlaideris.GetComponent<Slider>().value;
        float pasreizejaisIzmers = GarumaSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(2f * pasreizejaisIzmers1, pasreizejaisIzmers);
        mainigaisAttels.transform.localScale = new Vector2(pasreizejaisIzmers, 2f * pasreizejaisIzmers1);

    }
}
