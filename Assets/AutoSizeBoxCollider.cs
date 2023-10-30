using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSizeBoxCollider : MonoBehaviour
{
    private void Start()
    {
        // Get the renderer or mesh filter attached to the GameObject
        Renderer renderer = GetComponent<Renderer>();
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        if (renderer != null)
        {
            // If a renderer is found, set the Box Collider size based on the renderer's bounds
            BoxCollider boxCollider = GetComponent<BoxCollider>();
            if (boxCollider != null)
            {
                boxCollider.size = renderer.bounds.size;
            }
        }
        else if (meshFilter != null)
        {
            // If a MeshFilter is found, set the Box Collider size based on the mesh's bounds
            BoxCollider boxCollider = GetComponent<BoxCollider>();
            if (boxCollider != null)
            {
                boxCollider.size = meshFilter.mesh.bounds.size;
            }
        }
        else
        {
            Debug.LogWarning("No Renderer or MeshFilter found on the GameObject.");
        }
    }
}
