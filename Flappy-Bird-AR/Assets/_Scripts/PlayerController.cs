using UnityEngine;
using System.Collections;
using TMPro;


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FaceOrientation faceOrientation;

    private float PlayerPosition_Yaxis;

    private float FaceOrientation_Xaxis;

    private float ScreenHeight;

    private int FaceOrientationCap;

    [SerializeField]
    private Camera _camera;

    [Space(5)]
    [Range(0, 100)]
    [SerializeField]
    private int MovementSestivity=50;
    [Space(5)]
    public RectTransform _rectTransform;

    public bool EnablePlayerMovement { get; set; }


    [SerializeField]
    private TextMeshProUGUI _Score;

    private int Score;
    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        ScreenHeight = CanvasManager.Instance.GetHeight();

        FaceOrientationCap = (100 * (MovementSestivity / 100));

        EnablePlayerMovement = true;

        Score = 0;
        _Score.text = Score.ToString();
        StartCoroutine(UpdateScore());
    }

    private IEnumerator UpdateScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);

            Score += Random.Range(10,20);
            _Score.text = Score.ToString();
        }

    }

    private void Update()
    {

        if (EnablePlayerMovement)
        {
            FaceOrientation_Xaxis = faceOrientation.GetFaceOrientation_Xasxis();

            if (FaceOrientation_Xaxis >= 2 && FaceOrientation_Xaxis < 180)
            {
                PlayerPosition_Yaxis = Mathf.Clamp(MapFaceOrientationToScreenY(FaceOrientation_Xaxis, 0, FaceOrientationCap, 0, ScreenHeight), 0, ScreenHeight);
            }

            else if (FaceOrientation_Xaxis <= 358 && FaceOrientation_Xaxis >= 180)
            {
                PlayerPosition_Yaxis = Mathf.Clamp(MapFaceOrientationToScreenY(FaceOrientation_Xaxis, 360 - FaceOrientationCap, 360, -ScreenHeight, 0), -ScreenHeight, 0);
            }

            else
            {
                PlayerPosition_Yaxis = 0;
            }

            _rectTransform.localPosition = new Vector3(_rectTransform.localPosition.x, PlayerPosition_Yaxis, _rectTransform.localPosition.z);

        }

       

    }

    float MapFaceOrientationToScreenY(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }


}
