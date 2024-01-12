using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Slider batterySlider;
    public float progress = 1f;
    public float decreaseRate = 0.01f;

    void Start()
    {
        batterySlider.value = progress;
        UpdateSliderColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (progress > 0)
        {
            progress -= decreaseRate * Time.deltaTime;
            progress = Mathf.Max(progress, 0f);

            batterySlider.value = progress;
            UpdateSliderColor();
        }
    }

    void UpdateSliderColor()
    {
        // Calculate the color based on the progress
        Color color;

        if (progress > 0.5f)
        {
            // Green to Yellow
            color = Color.Lerp(Color.yellow, Color.green, (progress - 0.5f) * 2);
        }
        else
        {
            // Yellow to Red
            color = Color.Lerp(Color.red, Color.yellow, progress * 2);
        }

        // Set the color of the fill area
        Image fillImage = batterySlider.fillRect.GetComponent<Image>();
        fillImage.color = color;

        // Move the fill area along with the slider value
        RectTransform fillRectTransform = batterySlider.fillRect.GetComponent<RectTransform>();
        float normalizedValue = batterySlider.normalizedValue;

        // Calculate the maximum width of the fill area, clamped to the slider's width
        //float fillWidth = normalizedValue * batterySlider.GetComponent<RectTransform>().sizeDelta.x;
        //float maxWidth = Mathf.Clamp(fillWidth, 0f, batterySlider.GetComponent<RectTransform>().sizeDelta.x);

        // Set the offset to make the fill area disappear to the left when progress is less than or equal to 0
        if (progress <= 0)
        {
            fillRectTransform.offsetMin = new Vector2(0, fillRectTransform.offsetMin.y);
            fillRectTransform.offsetMax = new Vector2(0, fillRectTransform.offsetMax.y);
        }
        else
        {
            // Set the offset based on the calculated maximum width to keep it visible within bounds
            fillRectTransform.offsetMax = new Vector2(1, fillRectTransform.offsetMax.y);
        }
    }
}
