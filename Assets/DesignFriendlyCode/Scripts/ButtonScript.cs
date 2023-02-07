using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BjPoyser.DesignFriendlyCode
{
    public class ButtonScript : MonoBehaviour
    {
        public Text numbersText;
        public Button addButton;
        public Button substractButton;

        private int currentAmount;

        private void Awake()
        {
            currentAmount = 0;
            UpdateText();

            //You can assing actions that will be execute when the button is pressed
            //You can assing multimple actions to the same button
            addButton.onClick.AddListener(Add);
            substractButton.onClick.AddListener(Substract);

            //You can assing multimple actions to the same button
            addButton.onClick.AddListener(UpdateText);
            
            //And you can assing multiple buttons to the same actions
            substractButton.onClick.AddListener(UpdateText);
        }

        private void Add()
        {
            currentAmount++;
            numbersText.text = currentAmount.ToString();
        }

        private void Substract()
        {
            currentAmount--;
            numbersText.text = currentAmount.ToString();
        }

        private void UpdateText()
        {
            numbersText.text = currentAmount.ToString();
        }
    }
}
