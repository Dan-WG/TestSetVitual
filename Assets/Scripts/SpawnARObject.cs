using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class SpawnARObject : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject spawnedObject;

    [SerializeField] private GameObject PlaceablePrefab;

    //AR Session
    public ARSession Session;

    //AR Plane Manager
    private ARPlaneManager planeManager;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit> ();

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        planeManager = GetComponent<ARPlaneManager>();
    }

    private void Update()
    {
        if(!GetTouchPosition(out Vector2 TouchPosition))
        {
            return;
        }
            

        if(raycastManager.Raycast(TouchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPos = s_Hits[0].pose;
            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(PlaceablePrefab, hitPos.position, hitPos.rotation);
                spawnedObject.transform.rotation = Quaternion.Euler(-90f, 0, 0);
                
            }
            else
            {
                this.gameObject.GetComponent<ARPlaneManager>().enabled = false;

                foreach (ARPlane plane in planeManager.trackables)
                {
                    plane.gameObject.SetActive(false);
                }
            }
            

        }
    }

    bool GetTouchPosition(out Vector2 TouchPos)
    {
        if (Input.touchCount > 0)
        {
            TouchPos = Input.GetTouch(0).position;
            return true;
        }

        TouchPos = default;
        return false;
    }

    //buttons

    public void ResetSession()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
            this.gameObject.GetComponent<ARPlaneManager>().enabled = true;
        }
        Session.Reset();
    }
}
