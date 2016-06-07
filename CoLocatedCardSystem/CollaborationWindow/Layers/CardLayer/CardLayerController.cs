﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoLocatedCardSystem.CollaborationWindow.Layers
{
    /// <summary>
    /// A controller to manage the card layer
    /// </summary>
    class CardLayerController
    {
        CardLayer cardLayer;
        private ViewControllers viewControllers;

        internal CardLayer CardLayer
        {
            get
            {
                return cardLayer;
            }
        }

        public CardLayerController(ViewControllers vctrl)
        {
            this.viewControllers = vctrl;
        }
        /// <summary>
        /// Initialize the CardLayer
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void Init(int width, int height)
        {
            cardLayer = new CardLayer(this);
            cardLayer.Init(width, height);
        }
        /// <summary>
        /// Destroy the CardLayer
        /// </summary>
        public void Deinit()
        {
            cardLayer.Deinit();
        }
    }
}