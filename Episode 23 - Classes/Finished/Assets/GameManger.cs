using UnityEngine;
using System.Collections;
using Jezner.CSharp;
using Beginning.CSharp;

public class GameManger : MonoBehaviour {

	void OnDisable() {
		Alien alien = new Alien();
		alien.HitPoints = 100;

		Alien anotherAlien = alien;
		anotherAlien.HitPoints = 150;

		Debug.Log("Alien 1 Hit Points: " + alien.HitPoints);
		Debug.Log("Alien 2 Hit Points: " + anotherAlien.HitPoints);

		Player playerOne = new Player();
		playerOne.Name = "Brian";
		Player playerTwo = playerOne;
		playerTwo.Name = "Max";

		Debug.Log("Player 1's Name: " + playerOne.Name);
		Debug.Log("Player 2's Name: " + playerTwo.Name);

		playerOne = null;
		Debug.Log("Player 2's Name: " + playerTwo.Name);

	}


}
