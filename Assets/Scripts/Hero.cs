using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed = 5;
    private Vector3 targetPosition;
    private bool isMoving;
    private Rigidbody RigidBodyComponent;
    const int RIGHT_MOUSE_BUTTON = 1;


    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position; //acquisition de la position de depart
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(RIGHT_MOUSE_BUTTON)) {
            setTargetPosition();
        }
        if (isMoving) {
            MovePlayer();}
    }

    void setTargetPosition() {
        
        float point = 0f;
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);

        isMoving = true;

    }
    void MovePlayer() {
       //transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed*Time.deltaTime);
    
    
    }






    
}
