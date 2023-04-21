using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	private string teksts;
	private int vecums;

	public GameObject Varda_Ievade;
	public GameObject Vecuma_Ievade;
	public GameObject tekstaAttelosana;

	void Start() {
		Varda_Ievade.GetComponent<InputField>().contentType = InputField.ContentType.Standard;
		Vecuma_Ievade.GetComponent<InputField>().contentType = InputField.ContentType.IntegerNumber;
	}

	public void UzglabatTekstu(){
		teksts = Varda_Ievade.GetComponent<Text>().text;
		vecums = int.Parse(Vecuma_Ievade.GetComponent<Text>().text);
		string vecaVecs = "gadus vecs";
		if (teksts.EndsWith("a")) {
			vecaVecs = "gadus veca";
		}
		tekstaAttelosana.GetComponent<Text> ().text = teksts + " ir " + vecums + " " + vecaVecs + "! ";
	}
}
