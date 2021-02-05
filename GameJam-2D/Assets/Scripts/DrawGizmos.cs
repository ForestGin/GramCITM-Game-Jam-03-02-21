using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    public Color color;
    public float radius;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
