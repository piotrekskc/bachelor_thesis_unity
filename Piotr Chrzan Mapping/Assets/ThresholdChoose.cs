using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThresholdChoose : MonoBehaviour
{

    public ARController ThresholdingType;

    public Button Manual;
    public Button Median;
    public Button Otsu;
    public Button Adaptive;
    

    public Slider ManualValue;

    public Text TextThresold;

    private int ThresholdValue;
    // Use this for initialization
    void Start()
    {
        Button SetManual = Manual.GetComponent<Button>();
        Manual.onClick.AddListener(ThresholdTypeManual);



        Button SetMedian = Median.GetComponent<Button>();
        Median.onClick.AddListener(ThresholdTypeMedian);

        Button SetOtsu = Otsu.GetComponent<Button>();
        Otsu.onClick.AddListener(ThresholdTypeOtsu);

        Button SetAdaptive = Adaptive.GetComponent<Button>();
        Adaptive.onClick.AddListener(ThresholdTypeAdaptive);



    }

    // Update is called once per frame
    void Update()
    {
        TextThresold.text = "Current value:" + ThresholdValue;

    }
    public void ThresholdTypeManual()
    {
        ThresholdingType.VideoThresholdMode = ARController.ARToolKitThresholdMode.Manual;
        ThresholdValue = (int)ManualValue.value;
        ThresholdingType.VideoThreshold = ThresholdValue;
    }
    public void ThresholdTypeMedian()
    {
        ThresholdingType.VideoThresholdMode = ARController.ARToolKitThresholdMode.Median;
    }
    public void ThresholdTypeOtsu()
    {
        ThresholdingType.VideoThresholdMode = ARController.ARToolKitThresholdMode.Otsu;
    }
    public void ThresholdTypeAdaptive()
    {
        ThresholdingType.VideoThresholdMode = ARController.ARToolKitThresholdMode.Adaptive;
    }
   

}

