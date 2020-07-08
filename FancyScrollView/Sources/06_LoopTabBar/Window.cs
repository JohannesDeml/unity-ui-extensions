/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample06
{
    class Window : MonoBehaviour
    {
        [SerializeField] SlideScreenTransition transition = default;

        public void In(MovementDirection direction) => transition?.In(direction);

        public void Out(MovementDirection direction) => transition?.Out(direction);
    }
}
