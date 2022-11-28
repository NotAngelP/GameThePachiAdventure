using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    private Vector2 angle = new Vector2(90 * Mathf.Deg2Rad,0);
    private new Camera camera;
    private Vector2 nearPlaneSize;

    public Transform follow;
    public float maxDistance;
    public Vector2 sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        camera = GetComponent<Camera>();
        CalculateNearPlaneSize();
    }

    private void  CalculateNearPlaneSize(){
        float height = Mathf.Tan(camera.fieldOfView * Mathf.Deg2Rad / 2)* camera.nearClipPlane;
        float width = height * camera.aspect;

        nearPlaneSize = new Vector2 (width, height);
    }

    private Vector3[] GetCameraCollisionPoints(Vector3 direccion){
        Vector3 position = follow.position;
        Vector3 center = position + direccion * (camera.nearClipPlane + 0.8f);

        Vector3 right = transform.right * nearPlaneSize.x;
        Vector3 up = transform.up * nearPlaneSize.y;
        return new Vector3[]{
            center - right + up,
            center + right + up,
            center - right - up,
            center + right - up
        };
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");

        if(hor !=0){
            angle.x += hor * Mathf.Deg2Rad * sensitivity.x;
        }

        float ver = Input.GetAxis("Mouse Y");

        if(ver !=0){
            angle.y += ver * Mathf.Deg2Rad * sensitivity.y;
            angle.y = Mathf.Clamp(angle.y, -5 * Mathf.Deg2Rad, 5 * Mathf.Deg2Rad);
        }

    }

    void LateUpdate() {
        Vector3 direccion = new Vector3(Mathf.Cos(angle.x) * Mathf.Cos(angle.y), -Mathf.Sin(angle.y), -Mathf.Sin(angle.x)*Mathf.Cos(angle.y));
        
        RaycastHit hit;
        float distance = maxDistance;
        Vector3[] points = GetCameraCollisionPoints(direccion);

        foreach(Vector3 point in points){
            if(Physics.Raycast(follow.position,direccion, out hit, maxDistance)){
                distance = Mathf.Min((hit.point - follow.position).magnitude, distance);
            }
        }

        transform.position = follow.position + direccion * distance;
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position);
    }
}
