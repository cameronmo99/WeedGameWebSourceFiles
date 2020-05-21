using UnityEngine;
using System.Collections;

public class ForwardMove : MonoBehaviour
{

	void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
	}
}
