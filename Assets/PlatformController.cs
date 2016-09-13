using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

    public GameObject platformBasic;
    public Transform StartPos;
    public Transform EndPos;
    public float platSpeed = 5.0f;

    //Plat spawn speed in seconds
    public float spawnSpeed = 2.0f;
    
    private float stepSpeed = 0.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        stepSpeed += Time.deltaTime;

        if (stepSpeed > spawnSpeed)
        {
            SpawnPlat();
            SpawnPlat();

            stepSpeed = 0.0f;

        }
        

    }

    void SpawnPlat()
    {
        float varX = Random.Range(-10, 10);

        Vector3 SpawnPos = new Vector3(varX, StartPos.position.y, StartPos.position.z);
        Vector3 SpawnEndPos = new Vector3(varX, EndPos.position.y, EndPos.position.z);
        GameObject Pla1 = (GameObject)Instantiate(platformBasic, SpawnPos, Quaternion.identity);

        Pla1.GetComponent<PlatformSpeed>().endPos = SpawnEndPos;
        Pla1.GetComponent<PlatformSpeed>().speed = platSpeed;

    }


}
