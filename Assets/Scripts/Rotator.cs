using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(new Vector3(1, 2, 3) *15* Time.deltaTime);
	}
}
