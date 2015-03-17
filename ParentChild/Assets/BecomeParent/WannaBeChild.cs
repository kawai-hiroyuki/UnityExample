using UnityEngine;
using System.Collections;

public class WannaBeChild : MonoBehaviour {

	void Start () {
		transform.parent = GameObject.Find("WannaBeParent").transform;
	}
}
