using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoute : MonoBehaviour
{
    [SerializeField] float speed=5.0f;
    [SerializeField] bool activeRoute ;
    public Transform target;
    public List<GameObject> routes;
    public Waypoint routeObject;
    public bool isFirst=true;
    public int i = 0;
    public bool llego = false;
    // Start is called before the first frame update
    void Start()
    {
        routeObject = routes[0].GetComponentInChildren<Waypoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeRoute == true)
        {
            routes[0].SetActive(true);
            target = routeObject.waypointTransform[i].transform;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
            if (!llego)
            {
                transform.Translate(new Vector3(0, 0, speed + Time.deltaTime));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "waypoint")
        {
            i++;
            isFirst = false;
            target = routeObject.waypointTransform[i].transform;
            if (target)
            {
                transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
            }
            else
            {
                i = 0;
                llego = true;
            }
        }
    }

}
