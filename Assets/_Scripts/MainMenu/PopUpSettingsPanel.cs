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



        private const string styleResource = "PopupWindowStyleSheet";
        private const string ussPopup = "popup_window";

        public PopupWindow()
        {
            styleSheets.Add(Resources.Load<StyleSheet>(styleResource));

            VisualElement window = new VisualElement();
            window.AddToClassList(ussPopup);
            hierarchy.Add(window);
        }

    }

}