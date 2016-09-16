using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform CameraAnchor;
    public float CamX = 14;
    public float CamY = 10;
    public float CamZ = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(CamX, CamY, CamZ);
        transform.LookAt(CameraAnchor);
	
	}
}
