using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public float TargetDistance;
    private GameObject targetObject;
    public GameObject door;
    private Animation doorAnim;
    public static bool shotCheck;
    private Color color;

    private void Awake()
    {
        doorAnim = door.GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                TargetDistance = hit.distance;
                targetObject = hit.collider.gameObject;
                if(hit.transform.tag == "TargetCube") 
                {
                    targetObject.GetComponent<Renderer>().material.color = Color.cyan;
                    doorAnim.Play("Door");
                    shotCheck = true;
                }
            }
        }
    }


}
