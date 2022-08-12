using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShapeOnCollisic : MonoBehaviour
{
    [SerializeField]
    private Mesh changeMeshTo;

    private void OnCollisionEnter()
    {
        var meshFilter = GetComponent<MeshFilter>();

        meshFilter.mesh = changeMeshTo;
    }
    
}
