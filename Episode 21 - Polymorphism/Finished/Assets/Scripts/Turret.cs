using UnityEngine;
using System.Collections;

public struct Turret : IShootable {
	public void Fire() {
		Debug.Log("Turret fires");
	}
}
