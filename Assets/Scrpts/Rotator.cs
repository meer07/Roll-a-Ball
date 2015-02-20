using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	public Vector3 offset;
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (offset * Time.deltaTime);
	}
}
