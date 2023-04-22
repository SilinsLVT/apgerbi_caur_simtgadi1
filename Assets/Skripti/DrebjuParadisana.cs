using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DrebjuParadisana : MonoBehaviour
{
    public GameObject Krekli;
    public GameObject Bikses;
    public GameObject Kurpes;


    void Start()
    {
        Krekli.SetActive(false);
        Bikses.SetActive(false);
        Kurpes.SetActive(false);
    }
    public void ParaditKreklus(bool show)
    {
        Krekli.SetActive(show);
    }

    public void ParaditBikses(bool show)
    {
        Bikses.SetActive(show);
    }

    public void ParaditKurpes(bool show)
    {
        Kurpes.SetActive(show);
    }
}