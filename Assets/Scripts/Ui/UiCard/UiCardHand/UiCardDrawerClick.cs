﻿using Tools.Input.Mouse;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tools.UI.Card
{
    [RequireComponent(typeof(IMouseInput))]
    public class UiCardDrawerClick : MonoBehaviour
    {
        UiCardUtils CardDrawer { get; set; }
        IMouseInput Input { get; set; }

        void Awake()
        {
            CardDrawer = transform.parent.GetComponentInChildren<UiCardUtils>();
            Input = GetComponent<IMouseInput>();
            Input.OnPointerClick += DrawCard;
        }

        void DrawCard(PointerEventData obj) => CardDrawer.DrawCard();
    }
}