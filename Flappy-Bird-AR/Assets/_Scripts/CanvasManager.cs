using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }

    public float GetHeight()
    {
        return GetComponent<RectTransform>().sizeDelta.y;
    }
}
