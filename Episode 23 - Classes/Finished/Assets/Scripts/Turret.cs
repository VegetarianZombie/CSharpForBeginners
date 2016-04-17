using UnityEngine;
using System.Collections;

public struct Turret : IShootable, IPersistable {
	public void Fire() {
		Debug.Log("Turret fires");
	}
	public void Save() {
		Debug.Log("Turret Saves");
	}

}
