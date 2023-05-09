using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{

    [SerializeField] private OVRPassthroughLayer passthrough;
    [SerializeField] private List<Gradient> colorMapGradient;

    public void SetPassthrough()
    {
        passthrough.hidden = !passthrough.hidden;
    }

    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }

    public void SetColorMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = colorMapGradient[index];
    }

    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
    }
    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
    }
    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }

    public void SetEdgeRendering(bool val)
    {
        passthrough.edgeRenderingEnabled = val;
    }
    public void SetEdgeRed(float value)
    {
        Color color = new Color(value, passthrough.edgeColor.g, passthrough.edgeColor.b);
        passthrough.edgeColor = color;
    }
    public void SetEdgeGreen(float value)
    {
        Color color = new Color(passthrough.edgeColor.r, value, passthrough.edgeColor.b);
        passthrough.edgeColor = color;
    }
    public void SetEdgeBlue(float value)
    {
        Color color = new Color(passthrough.edgeColor.r, passthrough.edgeColor.g, value);
        passthrough.edgeColor = color;
    }
}
