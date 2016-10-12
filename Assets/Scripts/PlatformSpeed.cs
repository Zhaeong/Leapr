using UnityEngine;
using System.Collections;

public class PlatformSpeed : MonoBehaviour {
    public Vector3 endPos;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        if (transform.position == endPos)
            Destroy(gameObject);	
	}
}
