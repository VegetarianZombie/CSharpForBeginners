using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Beginning.CSharp;
using Jezner.CSharp;

public class HelloWorld : MonoBehaviour {
	
	IPersitable playerOne;
	Alien alien;

	void Start() {

		object[] array1 = new object[3];
		array1[0] = "Hello";
		array1[1] = 100;
		array1[2] = null;
		
		int number = (int) array1[0];
		number *= 100;

		playerOne = new Player(3, "Barney", 100);
		alien = new Alien(100, 1, false);
		playerOne.Save();
	}


	void OnDisable() {
//		Debug.Log ("Name: " + playerOne.Name + ", Score: " + playerOne.Score
//		           + ", Lives: " + playerOne.Lives);

		Debug.Log ("Is Alive: " + alien.IsAlive + ", Hit Points: " + 
		           alien.HitPoints + ", Point Value: " + alien.PointValue);

	}

}
