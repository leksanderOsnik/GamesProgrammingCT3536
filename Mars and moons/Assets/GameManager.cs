using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject marsObject;
    public GameObject phobosObject;
    public GameObject deimosObject;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = new Vector3(0, 0, -150);
        Camera.main.transform.LookAt(marsObject.transform);
        Rigidbody marsrb = marsObject.GetComponent<Rigidbody>();
        marsrb.angularVelocity = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        phobosObject.transform.RotateAround(marsObject.GetComponent<Transform>().position, Vector3.up, 90 * Time.deltaTime);
        deimosObject.transform.RotateAround(marsObject.GetComponent<Transform>().position, Vector3.up, 60 * Time.deltaTime);
        marsObject.transform.RotateAround(marsObject.GetComponent<Transform>().position, Vector3.up, -Input.GetAxis("Horizontal") * 180 * Time.deltaTime);
        marsObject.transform.RotateAround(marsObject.GetComponent<Transform>().position, Vector3.right, -Input.GetAxis("Vertical") * 180 * Time.deltaTime);
    }
}
