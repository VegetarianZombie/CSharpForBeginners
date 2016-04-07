using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Beginning.CSharp;
using Jezner.CSharp;

public class HelloWorld : MonoBehaviour {
	

	void Start() {

		object[] array1 = new object[3];
		array1[0] = "Hello";
		array1[1] = 100;
		array1[2] = null;
		
		int number = (int) array1[0];
		number *= 100;

	}


	void OnDisable() {
//		Debug.Log ("Name: " + playerOne.Name + ", Score: " + playerOne.Score
//		           + ", Lives: " + playerOne.Lives);


	}

}
