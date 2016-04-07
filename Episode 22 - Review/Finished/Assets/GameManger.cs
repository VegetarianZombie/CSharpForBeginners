using UnityEngine;
using System.Collections;
using Jezner.CSharp;
using Beginning.CSharp;

public class GameManger : MonoBehaviour {

	private IShootable[] enemies = new IShootable[4];
	private IPersistable[] savedItems = new IPersistable[3];
	
	void Start () {
		Alien alienOne = new Alien();
		Turret turret = new Turret();
		Player player = new Player();

		savedItems[0] = alienOne;
		savedItems[1] = turret;
		savedItems[2] = player;
	}

	void OnDisable() {
		foreach (IPersistable persistable in savedItems) {
			persistable.Save();
		}
	}


}
