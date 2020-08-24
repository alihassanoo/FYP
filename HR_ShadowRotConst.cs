
using UnityEngine;
using System.Collections;

public class HR_ShadowRotConst : MonoBehaviour {

	private Transform root;

	void Start () {

		root = transform.parent;
	
	}

	void Update () {

		transform.rotation = Quaternion.Euler(90, root.eulerAngles.y, 0);
	
	}

}
