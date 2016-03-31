using UnityEngine;

namespace Jezner.CSharp {

	public struct Alien : IShootable { 

		public int PointValue { get;set; }
		public int HitPoints { get;set; }
		public bool IsAlive { get;set; }

		public Alien(int pointValue, int hitPoints, bool isAlive) : this() {
			this.PointValue = pointValue;
			this.HitPoints = hitPoints;
			this.IsAlive = isAlive;
		}

		public Alien(int pointValue) : this(pointValue, 100, true) {

		}

		public void Fire() {
			Debug.Log("Alien fires");
		}

	}

}