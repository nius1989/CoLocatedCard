﻿using CoLocatedCardSystem.CollaborationWindow.DocumentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoLocatedCardSystem.CollaborationWindow.InteractionModule
{
    class Layer3:LayerBase
    {
        public Layer3(Card card) : base(card)
        {
        }

        internal override async Task SetArticle(Document doc)
        {
            await base.SetArticle(doc);
        }
    }
}
