using UnityEngine;
using System.Collections;
using Jezner.CSharp;

public class GameManger : MonoBehaviour {

	private IShootable[] enemies = new IShootable[4];
	
	void Start () {
		Alien alienOne = new Alien();
		Alien alienTwo = new Alien();
		Alien alienThree = new Alien();
		Turret turret = new Turret();

		enemies[0] = alienOne;
		enemies[1] = alienTwo;
		enemies[2] = alienThree;
		enemies[3] = turret;
	}

	void OnDisable() {
		foreach (IShootable shootable in enemies) {
			shootable.Fire();
		}
	}


}
