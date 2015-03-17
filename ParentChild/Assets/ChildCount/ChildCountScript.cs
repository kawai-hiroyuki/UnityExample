using UnityEngine;
using System.Collections;

// 親オブジェクトにAddComponent
public class ChildCountScript : MonoBehaviour {

	void Start () {
		int count = transform.childCount;
		Debug.Log ("Count=" + count);
	}
}
