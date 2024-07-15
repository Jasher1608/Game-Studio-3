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
        private const string ussPopupContainer = "popup_container";
        private const string ussHorContainer = "horizontal_container";
        private const string ussPopupMsg = "popup_msg";

        public PopupWindow()
        {
            styleSheets.Add(Resources.Load<StyleSheet>(styleResource));
            AddToClassList(ussPopupContainer);

            VisualElement window = new VisualElement();
            window.style.backgroundColor = new StyleColor(Color.blue); // Temporary style for visibility
            window.AddToClassList(ussPopup);
            hierarchy.Add(window);

            // Text Section
            VisualElement horizontalContainerText = new VisualElement();
            horizontalContainerText.style.backgroundColor = new StyleColor(Color.green); // Temporary style for visibility
            horizontalContainerText.AddToClassList(ussHorContainer);
            window.Add(horizontalContainerText);

            Label msgLabel = new Label();
            Debug.Log("reached message label");

            msgLabel.text = "Do you really want the red pill?";
            msgLabel.style.color = Color.yellow; // Temporary style for visibility
            msgLabel.AddToClassList(ussPopupMsg);
            horizontalContainerText.Add(msgLabel);

            
        }

    }

}