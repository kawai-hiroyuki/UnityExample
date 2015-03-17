using UnityEngine;
using System.Collections;

public class ExistChildScript : MonoBehaviour {

	void Start () {
		Debug.Log ("name:" + gameObject.name);

		if (GameObject.Find ("Child").transform.IsChildOf (transform)) {
			Debug.Log ("true");
		} else {
			Debug.Log ("false");
		}
	}
}
