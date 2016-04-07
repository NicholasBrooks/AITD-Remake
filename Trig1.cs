using UnityEngine;
using System.Collections;

public class Trig1 : MonoBehaviour {


	public Camera View1;
	public Camera View2;

	void OnTriggerEnter ( Collider other )
	{

		if (other.gameObject.CompareTag ("Man"))

		{
			View2.enabled= false;
			View1.enabled= true;
		}
	
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.CompareTag ("Man"))

		{
			View2.enabled= true;
			View1.enabled= false;


		}
	}
}
