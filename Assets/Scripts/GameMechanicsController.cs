using UnityEngine;
using System.Collections;

public class GameMechanicsController : MonoBehaviour {

    private int CurTime;
    PlatformController PCon;
	// Use this for initialization
	void Start () {
        PCon = gameObject.GetComponent<PlatformController>();
    }
	
	// Update is called once per frame
	void Update () {
        CurTime = (int)Time.time;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 50), CurTime.ToString());

    }
}
