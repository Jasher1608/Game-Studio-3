using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace PopupSettingsPanel
{
    public class PopupWindow : VisualElement
    {
        [UnityEngine.Scripting.Preserve]
        public new class UxmlFactory : UxmlFactory<PopupWindow>
        {

        }
        


        public PopupWindow()
        {
            VisualElement window = new VisualElement();
            hierarchy.Add(window);
        }

    }

}