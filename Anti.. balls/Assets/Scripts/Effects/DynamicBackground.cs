using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBackground : MonoBehaviour
{
    public float changeSpeed;
    private bool executing;
    private void Start()
    {
        executing = false;
    }
    private void Update()
    {
        if (executing == false)
        {
            executing = true;
            StartCoroutine(BackgroundColorChange());
        }
    }
    IEnumerator BackgroundColorChange()
    {
        bool increasing = true;
        float r = 0f, g = 255f, b = 0f;
        while (r < 255)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            r += changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(ColorSet(backgroundColor.r, changeSpeed), backgroundColor.g, backgroundColor.b);
            yield return null;
        }
        increasing = !increasing;
        while (g > 0)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            g -= changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(backgroundColor.r, ColorSet(backgroundColor.g, -changeSpeed), backgroundColor.b);
            yield return null;
        }
        increasing = !increasing;
        while (b < 255)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            b += changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(backgroundColor.r, backgroundColor.g, ColorSet(backgroundColor.b, changeSpeed));
            yield return null;
        }
        increasing = !increasing;
        while (r > 0)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            r -= changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(ColorSet(backgroundColor.r, -changeSpeed), backgroundColor.g, backgroundColor.b);
            yield return null;
        }
        while (g < 255)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            g += changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(backgroundColor.r, ColorSet(backgroundColor.g, changeSpeed), backgroundColor.b);
            yield return null;
        }
        increasing = !increasing;
        while (b > 0)
        {
            Color backgroundColor = GetComponent<SpriteRenderer>().color;
            b -= changeSpeed;
            GetComponent<SpriteRenderer>().color = new Color(backgroundColor.r, backgroundColor.g, ColorSet(backgroundColor.b, -changeSpeed));
            yield return null;
        }
        executing = false;
    }
    private float ColorSet(float color, float change)
    {
        float result = ((color * 255) + change) / 255;
        return result;
    }
}
