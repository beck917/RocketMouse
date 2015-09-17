using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject targetObject;
    private float distanceToTarget;
	// Use this for initialization
	void Start () {
        this.distanceToTarget = transform.position.x - targetObject.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        float targetObjectX = targetObject.transform.position.x;

        Vector3 newCameraPosition = transform.position;
        newCameraPosition.x = targetObjectX + this.distanceToTarget;
        transform.position = newCameraPosition;
	}
}
