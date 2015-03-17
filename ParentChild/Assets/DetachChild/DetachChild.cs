using UnityEngine;
using System.Collections;

public class DetachChild : MonoBehaviour {

	void Start () {
		transform.parent = null;
	}

}
