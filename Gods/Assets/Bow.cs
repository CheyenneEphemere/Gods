using UnityEngine;
using System.Collections;

public class Bow : MonoBehaviour {
	
	
	public GameObject Projectile;
	public Transform SpawnPoint;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(Projectile, SpawnPoint.position, this.SpawnPoint.rotation);
		}	
	}
}
