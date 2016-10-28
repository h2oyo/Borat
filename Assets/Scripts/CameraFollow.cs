using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public Transform leftBound;
    public Transform rightBound;
    private float arrowX;
    public float speed = 5.0f;

	
	void Update () {
        arrowX = Input.GetAxis("Horizontal");
        Transform cam = GetComponent<Transform>();
        if(arrowX == 0)
        {
            Vector3 newPos = transform.position;
            newPos.x = target.transform.position.x;
            newPos.x = Mathf.Clamp(newPos.x, leftBound.transform.position.x, rightBound.transform.position.x);
            transform.position = newPos;
        }
	if(arrowX !=0)
        {
            cam.position = cam.position + (Vector3.right * speed * Time.deltaTime);
            float camX = cam.position.x;
            camX = Mathf.Clamp(camX, leftBound.transform.position.x, rightBound.transform.position.x);
            cam.position = new Vector3(camX, cam.position.y, cam.position.z);
        }
	}
}
