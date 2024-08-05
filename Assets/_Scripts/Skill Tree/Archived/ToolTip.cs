using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TooltipController : MonoBehaviour
{
    public VisualElement button;
    public Label tooltip;
    private bool isHovered;

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        button = root.Q<VisualElement>("Button");
        tooltip = root.Q<Label>("Tooltip");

        button.RegisterCallback<MouseEnterEvent>(evt => OnMouseEnter());
        button.RegisterCallback<MouseLeaveEvent>(evt => OnMouseLeave());
        tooltip.RegisterCallback<MouseEnterEvent>(evt => OnTooltipMouseEnter());
        tooltip.RegisterCallback<MouseLeaveEvent>(evt => OnTooltipMouseLeave());

        HideTooltip();
    }

    private void OnMouseEnter()
    {
        isHovered = true;
        ShowTooltip();
    }

    private void OnMouseLeave()
    {
        isHovered = false;
        StartCoroutine(HideTooltipWithDelay());
    }

    private void OnTooltipMouseEnter()
    {
        isHovered = true;
        ShowTooltip();
    }

    private void OnTooltipMouseLeave()
    {
        isHovered = false;
        StartCoroutine(HideTooltipWithDelay());
    }

    private void ShowTooltip()
    {
        tooltip.RemoveFromClassList("tooltip-hidden");
        tooltip.AddToClassList("tooltip-visible");
    }

    private IEnumerator HideTooltipWithDelay()
    {
        yield return new WaitForSeconds(0.1f);
        if (!isHovered)
        {
            HideTooltip();
        }
    }

    private void HideTooltip()
    {
        tooltip.RemoveFromClassList("tooltip-visible");
        tooltip.AddToClassList("tooltip-hidden");
    }
}
