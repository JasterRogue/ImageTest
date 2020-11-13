using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTest : MonoBehaviour
{
    public Texture2D villageImage;
    int startX = 225;
    int endX = 937;
    int startY = 470;
    int endY = 998;
    int hsvValue;
    float v;
    float h;
    float s;
    Color currentPixelColour;
    Color currentPixelRGBVal;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = startX; i < endX + 1; i++)
        {
            for(int j = startY; j < endY + 1; j++)
            {
                currentPixelColour = villageImage.GetPixel(i, j);
                currentPixelRGBVal = new Color(currentPixelColour.r, currentPixelColour.g, currentPixelColour.b);
                Color.RGBToHSV(currentPixelRGBVal, out h, out s, out v);
                Debug.Log("Brightness value: " + v);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
