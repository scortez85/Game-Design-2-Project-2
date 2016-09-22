using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {
    private GameObject cam, camThrird;
    private Vector3 topDownCamPos;
    private Quaternion topDownCamRot;
    public int camAngle;
    private float camSpeed = 100;

	void Start () {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        camThrird = GameObject.Find("thirdCam");
        topDownCamPos = new Vector3(0, 140, 0);
        topDownCamRot = new Quaternion(0.7071068f, 0, 0, 0.7071068f);
	
	}
    public void setCamera(int num)
    {
        if (num.Equals(0))
        {
            cam.transform.position = topDownCamPos;
            cam.transform.rotation = topDownCamRot;
        }
        else if (num.Equals(1))
        {
            cam.transform.position = camThrird.transform.position;
            cam.transform.rotation = camThrird.transform.rotation;
        }
        else if (num.Equals(2))
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, topDownCamPos, camSpeed * Time.deltaTime);
            cam.transform.rotation = topDownCamRot;
        }
        else if (num.Equals(3))
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, camThrird.transform.position, camSpeed * Time.deltaTime);
            cam.transform.rotation = camThrird.transform.rotation;
        }
     
    }
	
	// Update is called once per frame
	void Update () {
        
        setCamera(camAngle);

    }
}
