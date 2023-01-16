using GoogleARCore.Examples.AugmentedFaces;
using UnityEngine;


[RequireComponent(typeof(ARCoreAugmentedFaceMeshFilter))]
public class FaceOrientation : MonoBehaviour
{
    private Transform facefilterTransform;

    private void Awake()
    {
        facefilterTransform = GetComponent<Transform>();
    }

    public float GetFaceOrientation_Xasxis()
    {
        return facefilterTransform.eulerAngles.x;
    }
}
