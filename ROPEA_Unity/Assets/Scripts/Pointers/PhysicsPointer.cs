using UnityEngine;

public class PhysicsPointer : MonoBehaviour
{
    public float defaultLength = 3f;
    private LineRenderer lineRenderer = null;
    private void Awake() {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update() {
        updateLength();
    }
    private void updateLength() 
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, CalculateEnd());
    }
    private Vector3 CalculateEnd()
    {
        RaycastHit hit = CreateForwardRayCast();
        Vector3 endPosition = DefaultEnd(defaultLength);
        if (hit.collider)
        {
            endPosition = hit.point;
        }
        return endPosition;
    }
    private RaycastHit CreateForwardRayCast()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, defaultLength);
        return hit;
    }
    private Vector3 DefaultEnd(float length)
    {
        return transform.position + (transform.forward * length);
    }
}
