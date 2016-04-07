using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour 
{
	public GameObject lamp;
	public GameObject knew;


	void start()
	{
		knew.SetActive (false);
	}

	void OnTriggerEnter ( Collider other )
	{

		if (other.gameObject.CompareTag ("Man"))

		{
			Destroy(lamp);
			knew.SetActive (true);

		}

	}


}
