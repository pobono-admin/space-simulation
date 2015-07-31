using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject objectA;
	public GameObject objectB;
	public GameObject objectC;


	// Use this for initialization
	void Start () {
	
		objectA.SetActive (false);
		objectB.SetActive (false);
		objectC.SetActive (false);


	}



	public void caseA(){
	
		objectA.SetActive (true);
		objectB.SetActive (false);
		objectC.SetActive (false);

	}
	public void caseB(){
		objectA.SetActive (false);
		objectB.SetActive (true);
		objectC.SetActive (false);
	}

	public void caseC(){
		objectA.SetActive (false);
		objectB.SetActive (false);
		objectC.SetActive (true);
	}

}
