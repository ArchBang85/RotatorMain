using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject outerWheel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.A))
        {
            outerWheel.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
        }
        if(Input.GetKey(KeyCode.D))
        {
            outerWheel.transform.Rotate(Vector3.forward * Time.deltaTime * -10);
        }
	
	}
}
