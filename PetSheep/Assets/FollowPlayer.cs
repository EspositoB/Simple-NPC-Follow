using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 2f;
    Vector3 targetDistance;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        targetDistance = target.transform.position - transform.position;
        this.transform.LookAt(target.transform.position);
        if (targetDistance.magnitude >5)
        {
            Vector3 velocity = (targetDistance.normalized * moveSpeed * Time.deltaTime);
            this.transform.position += velocity;
        }
        
    }
}
