using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LaserDeathBeam : MonoBehaviour
{

	void Start()
	{
	}

	// Update is called once per frame
	void Update()
    {
		RaycastHit hit;
		Ray landingRay = new Ray(transform.position, Vector3.back);

		if (Physics.Raycast(landingRay, out hit, 10f))
		{
			if (hit.collider.tag == "Player")
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				Debug.Log("Player has died.");
			}
		}
	}
}
