using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	
	Transform MyTransform;
	Rigidbody MyRigidbody;
	
	// Use this for initialization
	void Start () {			
		MyTransform = this.transform;
		MyRigidbody = this.GetComponent<Rigidbody>();
		MyRigidbody.AddForce(MyTransform.forward * 50, ForceMode.VelocityChange);			
	}

	void OnCollisionEnter(Collision col)
	{		
		MyRigidbody.isKinematic = true;					
	}
}
